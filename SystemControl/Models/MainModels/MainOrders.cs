using System.ComponentModel.DataAnnotations;

namespace Models.MainModels
{
    public class MainOrders
    {
        [Key] public int Id { get; set; }
        [Required] public string NameOrder { get; set; }
        [Required] public string DateOrder { get; set; }
        [Required] public string Status { get; set; }
    }
}