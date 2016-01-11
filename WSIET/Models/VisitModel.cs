using System;
using System.ComponentModel.DataAnnotations;

namespace WSIET.Models
{
    public class VisitModel
    {
        [Key]
        public int VisitId { get; set; }

        [Required]
        public LocationModel Location { get; set; }

        public UserModel User { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy")]
        public DateTime Date { get; set; }

        [Range(1, 10)]
        public int Rating { get; set; }

        [DataType(DataType.MultilineText)]
        public string Review { get; set; }
    }
}