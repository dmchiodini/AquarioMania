using AquarioMania.DataContext;
using AquarioMania.Utils;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using AquarioMania.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.DependencyInjection;


/*var builder = WebApplication.CreateBuilder(args);

var provider = builder.Services.BuildServiceProvider();
var _configuration = provider.GetRequiredService<IConfiguration>();*/

var environment = "";

if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") is null)
{
    Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Development");
    environment = "Development";
    Console.WriteLine("ASPNETCORE_ENVIRONMENT does not exists! Setting up Development Value: " + Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
}
else
{
    Console.WriteLine("ASPNETCORE_ENVIRONMENT Value: " + Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"));
    environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
}

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    Args = args,
    ApplicationName = typeof(Program).Assembly.FullName,
    ContentRootPath = Directory.GetCurrentDirectory(),
    EnvironmentName = environment,
    WebRootPath = "wwwroot"
});

builder.Services.Configure<AquarioManiaSettings>(builder.Configuration.GetSection("Settings"));

// Add services to the container.
builder.Services.AddSingleton<DapperContext>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

RegistryDependency.RegisterRepository(builder.Services);
RegistryDependency.RegisterServices(builder.Services);


var privateKey = builder.Configuration.GetSection("Settings").GetSection("PrivateKey").Value;

builder.Services
    .AddAuthentication(x =>
    {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(x =>
    {
        x.RequireHttpsMetadata = false;
        x.SaveToken = true;
        x.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(privateKey)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });


builder.Services.AddSwaggerGen(config =>
{
    config.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "AquarioMania API",
        Description = "Documentação da API do Microserviço de Integração com AquarioMania",
    });
    config.AddSecurityDefinition("Bearer",
            new OpenApiSecurityScheme
            {
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                Description = "JWT Authorization header using the Bearer scheme (Example: 'Bearer 12345abcdef')",
            });
    config.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
             new OpenApiSecurityScheme
          {
            Reference = new OpenApiReference
              {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
              },
            },
            Array.Empty<string>()
        }
    });
});


builder.Services.AddHealthChecks();
builder.Services.AddAuthorization();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
