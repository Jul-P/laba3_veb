using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controler;
using WebApplication1.Manager.Hobbys;
using WebApplication1.Storege;

namespace WebApplication1.Controler
{
    public class HobbyController : Controller
    {
        private readonly IHobbyManager _manager;
        public HobbyController(IHobbyManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public async Task<ViewResult> ShowHobby()
        {
            var entity = await _manager.GetAll();
            return View(entity);
        }
        public ViewResult AddHobby()
        {

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> create(CreateHobby request)
        {
            await _manager.AddHobby(request);
            return RedirectToAction(nameof(ShowHobby));
        }
        public async Task<ViewResult> UpdateHobby(Guid id)
        {
            var entity = await _manager.GetHobbyId(id);
            return View(entity);
        }
        [HttpPost]
        public async Task<ActionResult> Update(Guid StudentId, CreateHobby request)
        {
            await _manager.UpdateHobby(StudentId, request);
            return RedirectToAction(nameof(ShowHobby));
        }

        [HttpGet]
        public async Task<ViewResult> DelHobby(Guid id)
        {
            var entity = await _manager.GetHobbyId(id);
            return View(entity);
        }
        [HttpPost]
        public async Task<ActionResult> Del(Guid StudentId, CreateHobby request)
        {

            await _manager.DelHobby(StudentId, request);
            return RedirectToAction(nameof(ShowHobby));
        }
    }
}