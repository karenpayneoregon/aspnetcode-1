using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCoreMVCCRUD.Models
{
    public class Employee
    {
        /// <summary>
        /// Special note on Required attribute, it's common to use
        ///
        /// "this field is required."
        ///
        /// Rather than how I used {0} which is replaced with the property name BUT that can be improved too,
        /// see <see cref="Classes.RequiredAttribute"/> which overrides FormatErrorMessage which uses <see cref="Classes.StringHelpers.SplitCamelCase"/>
        /// to split the property name on upper cased characters so in this case FullName becomes Full Name field is required
        /// </summary>
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage ="{0} field is required.")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(10)")]
        [DisplayName("Code")]
        public string EmpCode { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Position { get; set; }
        [Column(TypeName = "varchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }
    }
}
