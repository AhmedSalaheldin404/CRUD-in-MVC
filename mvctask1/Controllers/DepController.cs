using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using mvctask1.Data;
using mvctask1.Models;

namespace mvctask1.Controllers
{
    public class DepController : Controller
    {

        ITIdata db = new ITIdata();
        public string Create(int depid, string depnam)
        {
            Department depa = new Department() { Department_Id = depid, department_name = depnam };
            db.Add(depa);
            db.SaveChanges();
            return "Added";
        }
       
        public string Edit(int depid, string depnam) { 
            var depa=db.Departments.SingleOrDefault(a=>a.Department_Id == depid);
            if (depa != null) {
                depa.Department_Id=depid;
                depa.department_name = depnam;
                db.SaveChanges();
                return "done updated!";
            }
            return "update error";
        }

        public string Display(int depid)
        {

            Department depa = db.Departments.SingleOrDefault(a => a.Department_Id == depid);
            string value = $"department name:{depa.department_name}and department id{depa.Department_Id}";
            return value;
        }

        public JsonResult index() // بيرجع كل الداتا 
        {
            var result =db.Departments.ToList();
            return Json(result);
        }
        public string Delete(int depid)
        {
            var depa= db.Departments.SingleOrDefault(a=> a.Department_Id == depid);
            db.Departments.Remove(depa);
            db.SaveChanges();
            return "row deleted!";
        }
        public ViewResult show()
        {
            return View();
        }
    }
}
