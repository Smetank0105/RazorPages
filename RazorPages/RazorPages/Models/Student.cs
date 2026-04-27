using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Студент без фамилии - не студент"), StringLength(50), Display(Name = "Фамилия")]
        [RegularExpression(@"^[A-Z]+[a-z]*$", ErrorMessage = "Строка содержит недопустимые символы")]
        public string LastName { get; set; }

        [Required, StringLength(50), Display(Name = "Имя")]
        [RegularExpression(@"^[A-Z]+[a-z]*$", ErrorMessage = "Строка содержит недопустимые символы")]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата зачисления")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Студент")]
        public string FullName
        {
            get => $"{LastName} {FirstName}";
        }

        //Navigation properties
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
