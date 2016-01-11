using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSIET.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public IEnumerable<VisitModel> Visits { get; set; }
    }
}
