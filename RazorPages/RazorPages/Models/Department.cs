using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPages.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        [Display(Name = "Кафедра")]
        [Required, StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Budget { get; set; }

        [Display(Name = "Дата начала")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        public int? InstructorID { get; set; }

        //Navigation properties
        public Instructor Administrator { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
