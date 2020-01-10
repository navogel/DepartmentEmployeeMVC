using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentEmployees2.Models
{
    public class Employee
    {
        
       
        public int Id { get; set; }
        [Required(ErrorMessage = "Department Name is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "More than 10 no bueno, but more than 2 yo")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }


    }

}
