using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesPersonal.Models
{
    public class Prediction
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public string? Created {  get; set; }
        
        public string? Question { get; set; }

        public string? Predictions {  get; set; }

        public bool? True { get; set; }

        public DateTime? WhenComplete { get; set; }
    }
}
