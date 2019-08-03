using System.ComponentModel.DataAnnotations;

namespace Models.PersonnelModels
{
    public class PersonnelOrder
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Position { get; set; }
        [Required] public string FullName { get; set; }
        [Required] public string Date { get; set; }
        [Required] public string Status { get; set; }
    }
}