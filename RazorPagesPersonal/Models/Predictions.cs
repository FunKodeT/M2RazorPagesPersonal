using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesPersonal.Models
{
    public class Prediction
    {
        public int Id { get; set; }

        [Display(Name = "Created On")]
        [DataType(DataType.Date)]
        public DateTime? Created {  get; set; }
        
        public string? Question { get; set; }

        [Display(Name = "Prediciton")]
        public string? Predictions {  get; set; }

        public bool? True { get; set; }

        [Display(Name = "Completed Date")]
        public DateTime? WhenComplete { get; set; }
    }
}
