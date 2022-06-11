using Student_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Model.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        static List<Student> students = new List<Student>()
       {
           new Student{Id="18-38504-2", Name="Firoz", DoB="1996-12-25",Password="12345678",Email="Firoz@gmail.com"},
                     new Student{Id="18-38505-2", Name="Ahmed", DoB="1996-12-26",Password="123456789",Email="Ahmed@gmail.com"},

       };
        
        [HttpGet]
        public ActionResult Index()
        {
            return View(students);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            
            if (ModelState.IsValid)
            {
                students.Add(s);
                return RedirectToAction("Index");
            }
            else
            {
                return View(s);
            }    
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            Student s = students.Where(x => x.Id == id).First();
            return View(s);
        }

        [HttpPost]
        public ActionResult Edit(string id, Student s)
        {
            Student studentToUpdate = students.Where(x => x.Id == id).First();
            studentToUpdate.Id = id;
            studentToUpdate.Name = s.Name;
            studentToUpdate.DoB = s.DoB;
            studentToUpdate.Password = s.Password;
            studentToUpdate.ConfirmPassword = s.ConfirmPassword;
            studentToUpdate.Email = s.Email;
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Delete(string id)
        {
            Student s = students.Where(x => x.Id == id).First();
            return View(s);
        }

        [HttpPost]
        public ActionResult Delete(string id, string deletePerson)
        {
            Student studentToDelete = students.Where(x => x.Id == id).First();
            if (studentToDelete != null)
                students.Remove(studentToDelete);
            return RedirectToAction("Index");

        }

    }
}