using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.Owin.BuilderProperties;
using WSIET.Enums;

namespace WSIET.Models
{
    public class LocationModel
    {
        [Key]
        public int LocationId { get; set; }
        public string Name { get; set; }
        public LocationType BaseType { get; set; }
        public Address Address { get; set; }
        public IEnumerable<VisitModel> Visits { get; set; }

    }
}