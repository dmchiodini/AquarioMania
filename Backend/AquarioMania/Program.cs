using AquarioMania.DataContext;
using AquarioMania.Repository;
using AquarioMania.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using MySqlConnector;
using System.Text;

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

// Add services to the container.
builder.Services.AddSingleton<DapperContext>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ILivingBeingInterface, LivingBeingService>();
builder.Services.AddScoped<ILivingBeingRepository, LivingBeingRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserInterface, UserService>();
builder.Services.AddScoped<ISessionInterface, SessionService>();


var privateKey = builder.Configuration.GetSection("PrivateKey").Value;


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
