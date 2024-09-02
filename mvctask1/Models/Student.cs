using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace mvctask1.Models
{
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Student_id { get; set; }
        [StringLength(15)]
        public string student_name { get; set; }
        public int student_age { get; set; }
    }
}
