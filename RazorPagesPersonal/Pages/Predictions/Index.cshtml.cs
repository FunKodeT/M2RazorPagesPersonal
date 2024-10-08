using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesPersonal.Data;
using RazorPagesPersonal.Models;

namespace RazorPagesPersonal.Pages.Predictions
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesPersonal.Data.RazorPagesPersonalContext _context;

        public IndexModel(RazorPagesPersonal.Data.RazorPagesPersonalContext context)
        {
            _context = context;
        }

        public IList<Prediction> Predictions { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Completed {  get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Filter { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of predictions.
            IQueryable<string> predictionQuery = from p in _context.Predictions orderby p.Id select p.Question;
            var predictions = from p in _context.Predictions select p;

            if (!string.IsNullOrEmpty(SearchString))
            {
                predictions = predictions.Where(s => s.Question.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(Filter))
            {
                predictions = predictions.Where(x => x.Question == Filter);
            }
            Completed = new SelectList(await  predictionQuery.Distinct().ToListAsync());
            Predictions = await _context.Predictions.ToListAsync();
        }
    }
}
