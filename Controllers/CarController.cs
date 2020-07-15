using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DZ_CAR.Models;
using DZ_CAR.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DZ_CAR.Controllers
{
    public class CarController : Controller
    {
        private readonly IRepository _repository;
        private readonly ILogger<CarController> _logger;

        public CarController(IRepository repository, ILogger<CarController> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        // GET: Car
        public ActionResult Index()
        {
            return View(_repository.GetAll());
        }

        // GET: Car/Details/5
        public ActionResult Details(int id)
        {
            return View(_repository.Get(id));
        }

        // GET: Car/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Car/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Car car)
        {
            try
            {
                _repository.Create(car);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return View();
            }
        }

        // GET: Car/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_repository.Get(id));
        }

        // POST: Car/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Car car)
        {
            try
            {
                _repository.Edit(car);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return View();
            }
        }

        // GET: Car/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_repository.Get(id));
        }

        // POST: Car/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Car car)
        {
            try
            {
                _repository.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return View();
            }
        }

    }
}