using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCapp.Models
{
    [Table("tbl_Employee")]
    public class Employee
    {
        
        public int EmployeeId { get; set; }
        public String Name { get; set; }
        public String Gender { get; set; }
        public String City { get; set; }
        public int DepartmentId { get; set; }

    }
}