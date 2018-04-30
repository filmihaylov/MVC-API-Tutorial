using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtosInterveuTask.Models
{
    [Table("tblUser")]
    public class User
        {

        public int ID { get; set; }

        public string Name { get; set; }
        }

}
