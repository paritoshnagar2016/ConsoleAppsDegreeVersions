using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessRepository
{
    [Table("Employee_tbl", Schema = "dbo")]
    public class EmployeeModel
    {
        [Key]
        [Column(name: "EmpId_i")]
        public int EmpId { get; set; }

        [Column(name: "EmpName_vc")]
        [Required(AllowEmptyStrings = true)]
        public string EmpName { get; set; }
    }
}
