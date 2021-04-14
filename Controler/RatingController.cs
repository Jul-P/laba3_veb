using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controler;
using WebApplication1.Manager.Ratings;
using WebApplication1.Storege;
namespace WebApplication1.Controler
{
    public class RatingController : Controller
    {
        private readonly IRatingManager _manager;
        public RatingController(IRatingManager manager)
        {
            _manager = manager;
        }
        [HttpGet]
        public async Task<ViewResult> ShowRating()
        {
            var entity = await _manager.GetAll();
            return View(entity);
        }
        #region Add

        public ViewResult AddRating()
        {

            return View();
        }
        [HttpPost]
        public async Task<ActionResult> create(CreateRating request)
        {
            await _manager.AddRating(request);
            return RedirectToAction(nameof(ShowRating));
        }
        #endregion

        [HttpGet]
        public async Task<ViewResult> UpdateRating(Guid id)
        {
            var entity = await _manager.GetRatingId(id);
            return View(entity);
        }
        [HttpPost]
        public async Task<ActionResult> Update(Guid StudentId, CreateRating request)
        {
            await _manager.UpdateRating(StudentId, request);
            return RedirectToAction(nameof(ShowRating));
        }

        [HttpGet]
        public async Task<ViewResult> DelRating(Guid id)
        {
            var entity = await _manager.GetRatingId(id);
            return View(entity);
        }
        [HttpPost]
        public async Task<ActionResult> Del(Guid StudentId, CreateRating request)
        {

            await _manager.DelRating(StudentId, request);
            return RedirectToAction(nameof(ShowRating));
        }
    }
}
