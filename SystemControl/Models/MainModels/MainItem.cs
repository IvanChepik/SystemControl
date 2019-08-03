using System.ComponentModel.DataAnnotations;

namespace Models.MainModels
{
    public class MainItem
    {
        [Key] public int Id { get; set; }
        [Required] public string NameItem { get; set; }
        [Required] public string ItemNumber { get; set; }
        [Required] public int Quantity { get; set; }
        [Required] public string DateItem { get; set; }
        [Required] public string NumberAct { get; set; }
        [Required] public string Notes { get; set; }
    }
}