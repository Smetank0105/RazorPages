using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class Instructor
    {
        public int ID { get; set; }

        [Display(Name = "Фамилия")]
        [Required, StringLength(50), RegularExpression(@"^[A-ZА-Я]+[a-zа-я]*$", ErrorMessage = "Строка содержит недопустимые символы")]
        public string LastName { get; set; }

        [Display(Name = "Имя")]
        [Required, StringLength(50), RegularExpression(@"^[A-ZА-Я]+[a-zа-я]*$", ErrorMessage = "Строка содержит недопустимые символы")]
        public string FirstName { get; set; }

        [Display(Name = "Дата трудоустройства")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [Display(Name = "Инструктор")]
        public string FullName
        {
            get => $"{LastName} {FirstName}";
        }

        //Navigation properties
        public ICollection<Course> Courses { get; set; }
        public OfficeAssignment OfficeAssignment { get; set; }
    }
}
