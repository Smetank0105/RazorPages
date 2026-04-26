using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Models
{
    public class Teacher
    {
        [Key, Column(TypeName = "smallint")]
        public int teacher_id { get; set; }
        [Required]
        public string last_name { get; set; }
        [Required]
        public string first_name { get; set; }
        public string? middle_name { get; set; }
        [Required, DataType(DataType.Date)]
        public DateOnly birth_date { get; set; }
        public string? email { get; set; }
        public string? phone { get; set; }
        public byte[]? photo { get; set; }
        [DataType(DataType.Date)]
        public DateOnly work_since { get; set; } = default!;
        public decimal rate { get; set; }

        //Navigation properties:
        public ICollection<TeacherDisciplineRelation>? DisciplinesRelations { get; set; } = default!;
    }
}
