using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace mvctask1.Models
{
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Department_Id { get; set; }
        [StringLength(20)]
        public string department_name { get; set; }
        public virtual List<Student> Students { get; set; }
        public override string ToString()
        {
            return $"{department_name},{Department_Id}";
        }
    }
}
