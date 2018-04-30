using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AtosInterveuTask.Models;

[Table("tblOrderElemts")]
public class OrderElement
{

    public int ID { get; set; }

    public string ElementName { get; set; }

    public int Quantity { get; set; }

    public virtual Order Order { get; set; }
}