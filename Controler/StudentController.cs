using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controler;
using WebApplication1.Manager.Students;
using WebApplication1.Storege;

namespace WebApplication1.Controler
{
    public class StudentController : Controller
    {
        private readonly IStudentManager _manager;
        public StudentController(IStudentManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public async Task<ViewResult> ShowStudent()
        {
            var entity = await _manager.GetAll();
            return View(entity);
        }
        #region Add

        public ViewResult AddStudent()
        {

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> create(CreateOrUpdateStudent request)
        {
            await _manager.AddStudent(request);
            return RedirectToAction(nameof(ShowStudent));
        }
        #endregion

        [HttpGet]
        public async Task<ViewResult> UpdateStudent(Guid id)
        {
            var entity = await _manager.GetStudentId(id);
            return View(entity);
        }
        [HttpPost]
        public async Task<ActionResult> Update(Guid StudentId, CreateOrUpdateStudent request)
        {
            await _manager.UpdateStudent(StudentId, request);
            return RedirectToAction(nameof(ShowStudent));
        }

        [HttpGet]
        public async Task<ViewResult> DelStudent(Guid id)
        {
            var entity = await _manager.GetStudentId(id);
            return View(entity);
        }
        [HttpPost]
        public async Task<ActionResult> Del(Guid StudentId, CreateOrUpdateStudent request)
        {

            await _manager.DelSudent(StudentId, request);
            return RedirectToAction(nameof(ShowStudent));
        }
        
        [HttpGet]
        public async Task<ViewResult> Find()
        {
            var entity = await _manager.GetAll();
            return View(entity);
        }
        [HttpPost]
        public async Task<ActionResult> Index(CreateOrUpdateStudent request)
        {

            var entity = await _manager.Find(request);
            return RedirectToAction(nameof(Find));
        }



    }
}