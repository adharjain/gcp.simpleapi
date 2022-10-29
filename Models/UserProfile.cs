using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gcp.angular.first.Models
{
    public class UserProfile
    {
        [Key]
        public int UserProfileId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        public string Phone { get; set; }
    }
}