using System.ComponentModel.DataAnnotations;

namespace Models.PersonnelModels
{
    public class PersonnelVacation
    {
        [Key] public int Id { get; set; }
        [Required] public string Position { get; set; }
        [Required] public string FullName { get; set; }
        [Required] public string PersonnelNumber { get; set; }
        [Required] public int CountDay { get; set; }
        [Required] public string PlanDate { get; set; }
        [Required] public string FactDate { get; set; }
        [Required] public string Notes { get; set; }
    }
}