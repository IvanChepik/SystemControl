using System.ComponentModel.DataAnnotations;

namespace Models.MainModels
{
    public class MainCompetition
    {
        [Key] public int Id { get; set; }
        [Required] public string DateCompetition { get; set; }
        [Required] public string Fullname { get; set; }
        [Required] public int Group { get; set; }
        [Required] public string NameCompetition { get; set; }
        [Required] public string Storage { get; set; }
    }
}