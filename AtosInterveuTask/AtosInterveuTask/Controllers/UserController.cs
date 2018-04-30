using AtosInterveuTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AtosInterveuTask.Controllers
{
    public class UserController : ApiController
    {
        private UserOrderContext db = new UserOrderContext();

        [HttpPost]
        [Route("api/User/{Name}")]
        public IHttpActionResult Post(string Name)
        {
            if (ModelState.IsValid)
            {
                var user = new User()
                {
                    Name = Name
                };

                db.Users.Add(user);
                db.SaveChanges();

                return Ok(user);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpGet]
        [Route("api/User/")]
        public IHttpActionResult Get()
        {
            if (ModelState.IsValid)
            {
                return Ok(db.Users.ToList());
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/User/{Name}")]
        public IHttpActionResult Get(string Name)
        {
            if (ModelState.IsValid)
            {
                var user = db.Users.SingleOrDefault((x) => x.Name.Equals(Name));
                return Ok(user);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
