using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string Company { get; set; }

        public virtual int EmployeeId { get; set; }


    }
}