using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotation
{
    public class Employee
    {
        ///<summary>
        ///Gets or Sets the name
        ///</summary>
        ///<value>
        ///the Name
        ///</value>
        [Required(ErrorMessage = "Employee {0} is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "name should be minimum 3 character")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        ///<summary>
        ///Gets or Sets the name
        ///</summary>
        ///<value>
        ///The Age
        /// ///</value>
        [Range(18, 99, ErrorMessage = "Age should be above 18")]
        public int Age { get; set; }

        ///<summary>
        ///Gets or Sets the name
        ///</summary>
        ///<value>
        ///The Phone number
        ///</value>
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }

        ///<summary>
        ///Gets or Sets the name
        ///</summary>
        ///<value>
        ///The email
        ///</value>
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}

