using System.ComponentModel.DataAnnotations;

namespace Models.MainModels
{
    public class MainCleaning
    {
        [Key] public int Id { get; set; }
        [Required] public string HoldingPlace { get; set; }
        [Required] public string PlannedDate { get; set; }
        [Required] public string NameDisinfectant { get; set; }
        [Required] public string FactDate { get; set; }
        [Required] public string Executor { get; set; }
    }
}