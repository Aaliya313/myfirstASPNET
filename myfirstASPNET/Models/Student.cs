using System.ComponentModel.DataAnnotations;

namespace myfirstASPNET.Models
{
    public class Student
    {
        //guid is a datatype for ID, builds more of a robust system
        public Guid Id { get; set; } //must have an Id, must have a 'primary key' like in SQL
        [Required] //ensures it gets filled out
        [Display(Name = "First Name")] //label to assign to details of these
        //Loads of other [] rules you can use - explore them
        public string FirstName { get;set; }
        [Required] //square brackets to what's the next line under it
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Student Email")]
        [DataType(DataType.EmailAddress)] //ensures email address is correct
        public string email { get; set; }
        public int CourseID { get; set; }
        
    }
}
