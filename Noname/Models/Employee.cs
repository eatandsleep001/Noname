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
        [Required]
        [Key]
        [Column("EMP_CODE", TypeName = "CHAR"), Display(Name = "EmployeeCode")]
        [StringLength(4, MinimumLength = 1)]
        public string EmployeeCode { get; set; }

        [Required]
        [Column("EMP_PASSWORD", TypeName = "VARCHAR"), Display(Name = "Password"), DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 4)]
        public string EmployeePassword { get; set; }
    }
}