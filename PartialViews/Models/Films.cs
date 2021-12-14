using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartialViews.Models
{
    public class Films
    {

        public string Title { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
    }
}
