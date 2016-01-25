using System;
using System.Collections.Generic;
using WSIET.Models;

namespace WSIET.ViewModels
{
    public class VisitCreateViewModel
    {
        public IEnumerable<LocationViewModel> Locations { get; set; }
        public DateTime Date { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
    }
}