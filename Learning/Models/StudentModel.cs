using System.ComponentModel.DataAnnotations;

namespace Learning.Models
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Standard { get; set; }
        public int RollNo { get; set; }
        public string Subject { get; set; }
     }
}
