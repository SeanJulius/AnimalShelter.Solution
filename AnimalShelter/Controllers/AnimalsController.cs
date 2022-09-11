using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  public class AnimalsController : ControllerBase
  {
    public IActionResult Index()
    {
      var allAnimals = Animal.GetAnimals();
      return View(allAnimals);
    }

    [HttpPost]
    public IActionResult Index(Animal animal)
    {
      Animal.Post(animal);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var animal = Animal.GetDetails(id);
      return View(animal);
    }

    public IActionResult Edit(int id)
    {
      var animal = Animal.GetDetails(id);
      return View(animal);
    }

    [HttpPost]
    public IActionResult Details(int id, Animal animal)
    {
      animal.AnimalId = id;
      Animal.Put(animal);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Animal.Delete(id);
      return RedirectToAction("Index");
    }
  }
}