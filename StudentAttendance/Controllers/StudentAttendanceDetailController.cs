using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAttendance.Context;
using StudentAttendance.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentAttendance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceDetailController : ControllerBase
    {
        // GET: Controller
        private StudentAttendanceDetailContext _studentAttendanceDetailContext;

        public StudentAttendanceDetailController(StudentAttendanceDetailContext studentAttendanceDetailContext)
        {
            _studentAttendanceDetailContext = studentAttendanceDetailContext;
        }

        // GET: api/<Controller>
        [HttpGet]
        public IEnumerable<StudentAttendanceDetail> Get()
        {
            return _studentAttendanceDetailContext.StudentAttendanceDetails;
        }

        // GET api/<Controller>/5
        [HttpGet("{id}")]
        public StudentAttendanceDetail Get(int id)
        {
            return _studentAttendanceDetailContext.StudentAttendanceDetails.FirstOrDefault(s => s.StudentID == id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] StudentAttendanceDetail value)
        {
            _studentAttendanceDetailContext.StudentAttendanceDetails.Add(value);
            _studentAttendanceDetailContext.SaveChanges();
        }
    }
}
