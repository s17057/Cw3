using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cw3.Models;
using Cw3.DAL;

namespace Cw3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {

        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        public string GetStudent()
        {
            return "Kowalski, Malewski, Andrzejewski";
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            }
            else if (id == 2)
            {
                return Ok("Malewski");
            }
            else
            {
                return NotFound("Nie znaleziono studenta");
            }
        }
        [HttpGet]
        public IActionResult GetStudents(string orderBy)
        {
            return Ok(_dbService.GetStudents());
        }
        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student student)
        {
            return Ok($"Aktualizacja dokończona");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            return Ok($"Usuwanie ukończone");
        }

    }
}