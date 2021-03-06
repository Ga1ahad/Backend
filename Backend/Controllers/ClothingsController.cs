﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{

    [Route("api/users/{IdUser:int}/[controller]")]
    [ApiController]
    public class ClothingController : Controller
    {
        private readonly s15264Context _context;

        public ClothingController(s15264Context context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetClothings(int IdUser)
        {

         
            var clothings = from Clothing in _context.Clothing
                                 where IdUser.Equals(Clothing.IdUser)
                                 select Clothing;   

            return Ok(clothings);
        }

        [HttpGet("{IdClothing:int}")]   
        public IActionResult GetClothings(int IdUser, int id)
        {

            var cloth = _context.Clothing.FirstOrDefault(c => c.IdClothing == id);
            if (cloth == null)
            {
                return NotFound();
            }
            return Ok(cloth);
        }

        [HttpPost]
        public IActionResult CreateClothings(Clothing clothing)
        {
            _context.Clothing.Add(clothing);
            _context.SaveChanges();
            return StatusCode(201, clothing);
        }

        [HttpPut("{IdClothing:int}")]
        public IActionResult Update(int IdClothing, Clothing updatedClothing)
        {

            if (_context.Clothing.Count(c => c.IdClothing == IdClothing) == 0)
            {
                return NotFound();
            }
            _context.Clothing.Attach(updatedClothing);
            _context.Entry(updatedClothing).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(updatedClothing);
        }



        [HttpDelete("{IdClothing:int}")]
        public IActionResult Delete(int id)
        {
            var cloth = _context.Clothing.FirstOrDefault(c => c.IdClothing == id);
            if (cloth == null)
            {
                return NotFound();
            }
            _context.Clothing.Remove(cloth);
            _context.SaveChanges();

            return Ok(cloth);
        }
    }
}