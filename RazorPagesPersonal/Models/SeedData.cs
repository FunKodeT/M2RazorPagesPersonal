using Microsoft.EntityFrameworkCore;
using RazorPagesPersonal.Data;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesPersonal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesPersonalContext(
                    serviceProvider.GetRequiredService<
                        DbContextOptions<
                            RazorPagesPersonalContext
                        >
                    >()
            ))
            {
                if(context == null || context.Predictions == null)
                {
                    throw new ArgumentNullException("Null RazorPagesPersonalContext");
                }
                // Look for ANY predictions;
                if (context.Predictions.Any())
                {
                    return;
                    // DB has been seeded;
                }
                context.Predictions.AddRange(
                    new Prediction
                    { 
                        Created = DateTime.Parse("2024-10-07"),
                        Question = "Can I go home?",
                        Predictions = "Not Likely",
                        True = false,
                        WhenComplete = DateTime.Parse("2024-10-07")
                    },
                    new Prediction
                    {
                        Created = DateTime.Parse("2024-10-08"),
                        Question = "Can I win?",
                        Predictions = "Ask again.",
                        True = true,
                        WhenComplete = DateTime.Parse("2024-10-08")
                    },
                    new Prediction
                    {
                        Created = DateTime.Parse("2024-10-08"),
                        Question = "Will this work?",
                        Predictions = "Certainly.",
                        True = true,
                        WhenComplete = DateTime.Parse("2024-10-08")
                    },
                    new Prediction
                    {
                        Created = DateTime.Parse("2024-10-08"),
                        Question = "Will it rain today?",
                        Predictions = "Not likely.",
                        True = true,
                        WhenComplete = DateTime.Parse("2024-10-08")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
