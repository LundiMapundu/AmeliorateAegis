using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AmeliorateAegis.Models
{
    public class ApplicationUser : IdentityUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [ForeignKey(nameof(CentreId))]
        public Centre Centre { get; set; }
        public long? CentreId { get; set; }
    }
}
