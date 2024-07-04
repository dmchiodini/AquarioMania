using System.ComponentModel.DataAnnotations;

namespace AquarioMania.Models.LivingBeing;
public class ListLivingBeingModel
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Scientific_name { get; set; }
    public string? Family { get; set; }
    public string? Origin { get; set; }
    public int? Life_expectancy { get; set; }
    public string Ph { get; set; }
    public string? Hardness { get; set; }
    public int Behavior_id { get; set; }
    public string? Behavior { get; set; }
    public int Type_of_water_id { get; set; }
    public string? Type_of_water { get; set; }
    public int Type_of_life_id { get; set; }
    public string? Type_of_life { get; set; }
    public string? Description { get; set; }
    public DateTime? Created_at { get; set; } = DateTime.Now.ToLocalTime();
    public DateTime? Updated_at { get; set; } = DateTime.Now.ToLocalTime();
}

