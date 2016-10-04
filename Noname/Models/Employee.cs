using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Noname.Models
{
    [Table("EMPLOYEE_MST")]
    public class Employee
    {
        [Column("EMP_CODE")]
        [Required]
        [StringLength(4, MinimumLength = 1)]
        [Display(Name = "Last Name")]
        public string EmployeeCode;
    }
}