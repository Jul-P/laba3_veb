using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controler;
using WebApplication1.Manager.Groups;
using WebApplication1.Storege;

namespace WebApplication1.Controler
{
    public class GroupController : Controller
    {
        private readonly IGroupManager _manager;
        public GroupController (IGroupManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public async Task<ViewResult> ShowGroup()
        {
            var entity = await _manager.GetAll();
            return View(entity);
        }
        public ViewResult AddGroup()
        {

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> create(CreateGroup request)
        {
            await _manager.AddGroup(request);
            return RedirectToAction(nameof(ShowGroup));
        }
        [HttpGet]
        public async Task<ViewResult> UpdateGroup(Guid id)
        {
            var entity = await _manager.GetGroupId(id);
            return View(entity);
        }
        [HttpPost]
        public async Task<ActionResult> Update(Guid StudentId, CreateGroup request)
        {
            await _manager.UpdateGroup(StudentId, request);
            return RedirectToAction(nameof(ShowGroup));
        }

        [HttpGet]
        public async Task<ViewResult> DelGroup(Guid id)
        {
            var entity = await _manager.GetGroupId(id);
            return View(entity);
        }
        [HttpPost]
        public async Task<ActionResult> Del(Guid StudentId, CreateGroup request)
        {

            await _manager.DelGroup(StudentId, request);
            return RedirectToAction(nameof(ShowGroup));
        }
    }
}