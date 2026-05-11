using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int InstructorID { get; set; }

        [Display(Name = "Расположение офиса")]
        [StringLength(50)]
        public string Location { get; set; }

        //Navigation properties
        public Instructor Instructor { get; set; }
    }
}
