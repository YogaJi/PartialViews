using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.CompilerServices;
using PartialViews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViews.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Films> Film;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Film = new List<Films>();
            Film.Add(new Films() { Title = "Back to the Outback", Duration = "1h 32m", Description= "Tired of being locked in a reptile house where humans gawk at them like they’re monsters, a ragtag group of Australia’s deadliest creatures plot a daring escape from their zoo to the Outback, a place where they’ll fit in without being judged for their scales and fangs." } );
            Film.Add(new Films() { Title = "Don't Look Up", Duration = "2h 25m", Description = "Kate Dibiasky (Jennifer Lawrence), an astronomy grad student, and her professor Dr. Randall Mindy (Leonardo DiCaprio) make an astounding discovery of a comet orbiting within the solar system. The problem — it’s on a direct collision course with Earth. The other problem? No one really seems to care." });
            Film.Add(new Films() { Title = "The Duke", Duration = "1h 36m", Description = " In 1961, Kempton Bunton, a 60-year old taxi driver, stole Goya’s portrait of the Duke of Wellington from the National Gallery in London. It was the first (and remains the only) theft in the Gallery’s history. Kempton sent ransom notes saying that he would return the painting on condition that the government agreed to provide television for…" });
        }

        public void OnGet()
        {

        }
    }
}
