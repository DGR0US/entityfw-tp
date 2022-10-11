using System.ComponentModel.DataAnnotations;

namespace MudBldsds.Model
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public int GradeID { get; set; }

        public Grade Grade { get; set; }
    }
}
