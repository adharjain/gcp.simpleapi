using gcp.angular.first.Data;
using gcp.angular.first.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace gcp.angular.first.Controllers
{
    [EnableCors(@"http://localhost:4200","*","*")]
    public class UserProfileController : ApiController
    {
        public IHttpActionResult GetUserProfiles()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    return Ok(context.userProfiles.ToList());
                }
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IHttpActionResult CreateUser([FromBody] UserProfile user)
        {
            try
            {
                if(!ModelState.IsValid)
                    return BadRequest(ModelState);
                using (var context = new AppDbContext())
                {
                    context.userProfiles.Add(user);
                    context.SaveChangesAsync();
                    return Ok("user profile is created");
                }    
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IHttpActionResult UpdateUser(int id, [FromBody] UserProfile user)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                using (var context = new AppDbContext())
                {
                    UserProfile dbuser = context.userProfiles.FirstOrDefault(s=>s.UserProfileId == user.UserProfileId);
                    if (dbuser == null) return BadRequest("User not found");
                    
                    dbuser.EmailId = user.EmailId;
                    dbuser.Name = user.Name;
                    dbuser.Address = user.Address;
                    dbuser.Phone = user.Phone;
                    context.SaveChangesAsync();
                    return Ok("user profile is updated");                   
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
