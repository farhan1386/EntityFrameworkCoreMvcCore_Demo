using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCoreMvcCore_Demo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter first name")]
        [Display(Name ="First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter postion")]
        [StringLength(50)]
        public string Position { get; set; }

        [Required(ErrorMessage = "Please enter office")]
        [StringLength(50)]
        public string Office { get; set; }

        [Required(ErrorMessage = "Please enter salary")]
        public int Salary { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
