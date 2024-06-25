using AquarioMania.Enums;
using System.ComponentModel.DataAnnotations;

namespace AquarioMania.Models;

public class LivingBeingModel
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Scientific_name { get; set; }
    public string? Family { get; set; }
    public string? Origin { get; set; }
    public string? Life_expectancy { get; set; }
    public string Ph { get; set; }
    public string? Hardness { get; set; }
    public BehaviorEnum Behavior { get; set; }
    public TypeOfWaterEnum Type_of_water { get; set; }
    public TypeOfLifeEnum Type_of_life { get; set; }
    public string? Description { get; set; }
    public DateTime? Created_at { get; set; } = DateTime.Now.ToLocalTime();
    public DateTime? Updated_at { get; set; } = DateTime.Now.ToLocalTime();


}
