using System.ComponentModel.DataAnnotations;

namespace Models.ChildModels
{
    public class ChildCard
    {
        [Key] public int Id { get; set; }
        [Required] public string FullName { get; set; }
        [Required] public string DateBirth { get; set; }
        [Required] public string PlaceBirth { get; set; }
        [Required] public string Address { get; set; }
        [Required] public string NumberAccount { get; set; }
        [Required] public string FullNameParents { get; set; }
        [Required] public string HomePhoneNumber { get; set; }
        [Required] public string CellPhoneNumber { get; set; }
        [Required] public string Mail { get; set; }
        [Required] public string Notes { get; set; }
    }
}