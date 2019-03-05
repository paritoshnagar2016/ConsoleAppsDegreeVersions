using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessRepository
{
    [Table("Employee_tbl")]
    public class EmployeeModel
    {
        [Key]
        [Column(name:"EmpId_i")]
        public int EmpId { get; set; }

        [Column(name: "EmpName_vc")]
        public string EmpName { get; set; }
    }
}
