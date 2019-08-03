using System.ComponentModel.DataAnnotations;

namespace Models.MainModels
{
    public class MainEquipment
    {
        [Key] public int Id { get; set; }
        [Required] public string DateEquipment { get; set; }
        [Required] public string StatusEquipment { get; set; }
        [Required] public string Problems { get; set; }
        [Required] public string DateProblems { get; set; }
        [Required] public string RepairPerson { get; set; }
        [Required] public string EndStatus { get; set; }
    }
}