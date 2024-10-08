using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesPersonal.Models
{
    public class Prediction
    {
        public int Id { get; set; }

        [Display(Name = "Created On"), DataType(DataType.Date)]
        public DateTime? Created { get; set; }
        
        public string? Question { get; set; }

        [Display(Name = "Prediction")]
        public string? Predictions {  get; set; }

        [Display(Name = "True?")]
        public bool? True { get; set; }

        [Display(Name = "Completed Date"), DataType(DataType.Date)]
        public DateTime? WhenComplete { get; set; }

        public string GetPrediction()
        {
            string[] answers =
            {
                "Maybe.",
                "Certainly not.",
                "I hope so.",
                "Not in your wildest dreams.",
                "There is a good chance.",
                "Quite likely.",
                "I think so.",
                "I hope not.",
                "I hope so.",
                "Never!",
                "Fuhgeddaboudit.",
                "Ahaha! Really?!?",
                "Pfft.",
                "Sorry, bucko.",
                "Hell, yes.",
                "Hell to the no.",
                "The future is bleak.",
                "The future is uncertain.",
                "I would rather not say.",
                "Who cares?",
                "Possibly.",
                "Never, ever, ever.",
                "There is a small chance.",
                "Yes!"
            };

            Random assign = new Random();
            int index = assign.Next(0, answers.Length);

            string selection = answers[index];
            return selection;
        }
    }
}
