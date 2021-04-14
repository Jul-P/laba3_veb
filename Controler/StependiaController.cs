using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controler;
using WebApplication1.Manager.Stependias;
using WebApplication1.Storege;

namespace WebApplication1.Controler
{
    public class StependiaController : Controller
    {
        private readonly IStependiaManager _manager;
        public StependiaController(IStependiaManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public async Task<ViewResult> ShowStependia()
        {
            var entity = await _manager.GetAll();
            return View(entity);
        }
        

        public ViewResult AddStependia()
        {

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> create(CreateStependia request)
        {
            await _manager.AddStependia(request);
            return RedirectToAction(nameof(ShowStependia));
        }
        

        [HttpGet]
        public async Task<ViewResult> UpdateStependia(Guid id)
        {
            var entity = await _manager.GetStependiaId(id);
            return View(entity);
        }
        [HttpPost]
        public async Task<ActionResult> Update(Guid StudentId, CreateStependia request)
        {
            await _manager.UpdateStependia(StudentId, request);
            return RedirectToAction(nameof(ShowStependia));
        }

        [HttpGet]
        public async Task<ViewResult> DelStependia(Guid id)
        {
            var entity = await _manager.GetStependiaId(id);
            return View(entity);
        }
        [HttpPost]
        public async Task<ActionResult> Del(Guid StudentId, CreateStependia request)
        {

            await _manager.DelStependia(StudentId, request);
            return RedirectToAction(nameof(ShowStependia));
        }
    }
}