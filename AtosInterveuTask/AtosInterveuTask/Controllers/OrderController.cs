using AtosInterveuTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AtosInterveuTask.Controllers
{
    public class OrderController : ApiController
    {
        private UserOrderContext db = new UserOrderContext();

        [HttpPost]
        [Route("api/Order/{userID}/{orderName}")]
        public IHttpActionResult Post(int userID, string orderName)
        {
            if (ModelState.IsValid)
            {
                var userObject = from userObj in db.Users
                                 where userObj.ID == userID
                                 select userObj;

                var order = new Order()
                {
                    OrderName = orderName,
                    User = userObject.SingleOrDefault<User>(),
                    User_ID = userObject.SingleOrDefault<User>().ID
                };

                db.Orders.Add(order);
                db.SaveChanges();

                return Ok(order);
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("api/Order/{userID}")]
        public IHttpActionResult Get(int userID)
        {
            if (ModelState.IsValid)
            {
                var userOrders = from userorder in db.Orders
                                 where userorder.User_ID.Equals(userID)
                                 select userorder;

                return Ok(userOrders.ToList());
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpGet]
        [Route("api/Order/")]
        public IHttpActionResult Get()
        {
            if (ModelState.IsValid)
            {
                var orders = from ord in db.Orders
                         select ord;
                return Ok(orders.ToList());
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
