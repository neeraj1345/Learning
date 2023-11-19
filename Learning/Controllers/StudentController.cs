using Learning.Models;
using Microsoft.AspNetCore.Mvc;

namespace Learning.Controllers
{
    public class StudentController : Controller 

    {
        private readonly LearningContext db;
        public StudentController(LearningContext _db)
        {
            this.db = _db;
        }

        public IActionResult Index()
        {
            var list = db.Tb_StudentDetail.ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentModel std)
        {
            if (std != null) 
            {
                if(std.Id == 0)
                {
                    db.Tb_StudentDetail.Add(std);
                }
                else
                {
                    db.Entry(std).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                }
                db.SaveChanges();
              
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var obj = db.Tb_StudentDetail.Find(id);
            return View(obj);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var obj = db.Tb_StudentDetail.Find(id);
            db.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
