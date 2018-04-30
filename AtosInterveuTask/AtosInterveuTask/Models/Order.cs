using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AtosInterveuTask.Models
{
    [Table("tblOrder")]
    public class Order
    {

        public int ID { get; set; }
      
        public string OrderName { get; set; }

        public int User_ID { get; set; }

        public virtual User User { get; set; }
    }

}