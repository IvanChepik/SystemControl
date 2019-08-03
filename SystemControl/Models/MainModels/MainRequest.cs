using System.ComponentModel.DataAnnotations;

namespace Models.MainModels
{
    public class MainRequest
    {
        [Key] public int Id { get; set; }
        [Required] public string RequestDate { get; set; }
        [Required] public string RequestTime { get; set; }
        [Required] public string RequestContent { get; set; }
        [Required] public string RequestApplicant { get; set; }
        [Required] public string AdmissionTime { get; set; }
        [Required] public string Notes { get; set; }
    }
}