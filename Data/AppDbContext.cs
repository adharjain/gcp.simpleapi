using gcp.angular.first.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace gcp.angular.first.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(): base("name=AdvancedConnection")
        {

        }

        [Key]
        public DbSet<UserProfile> userProfiles { get; set; }
    }
}