using System.ComponentModel.DataAnnotations;

namespace Models.ChildModels
{
    public class ChildOrder
    {
        [Key] public int Id { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Date { get; set; }
        [Required] public string FullName { get; set; }
        [Required] public string Status { get; set; }
    }
}