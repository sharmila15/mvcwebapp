using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCapp.Models
{
    [Table("tbl_Department")]
    public class Department
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}