using Microsoft.AspNetCore.Mvc;
using mvctask1.Data;
using mvctask1.Models;

namespace mvctask1.Controllers
{
    public class StudentController : Controller
    {
      ITIdata db = new ITIdata();
      public string Create(int studentid, string studentnam, int studentage)
       {
          Student stu = new Student() { Student_id = studentid, student_name = studentnam, student_age = studentage};
           db.Add(stu);
            db.SaveChanges();
           return "Added";
       }
        public string Edit(int studentid, string studentnam, int studentage)
        {
            var stud = db.Students.SingleOrDefault(a => a.Student_id == studentid);
            if (stud != null)
            {
                stud.Student_id= studentid;
                stud.student_name = studentnam;
                stud.student_age = studentage;
                db.SaveChanges();
                return "done updated!";
            }
            return "update error";
        }

        public string Display(int studentid)
        {

            Student stu = db.Students.SingleOrDefault(a => a.Student_id == studentid);
            string value = $"student's name {stu.student_name} and student's id:{stu.Student_id},and his age :{stu.student_age}";
            return value;
        }

        public JsonResult index() // بيرجع كل الداتا 
        {
            var result = db.Students.ToList();
            return Json(result);
        }
        public string Delete(int studentid)
        {
            var stu = db.Students.SingleOrDefault(a => a.Student_id == studentid);
            db.Students.Remove(stu);
            db.SaveChanges();
            return "row deleted!";
        }
    }
}
