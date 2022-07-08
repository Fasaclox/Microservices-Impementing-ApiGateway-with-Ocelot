using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdmission.Context;
using StudentAdmission.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentAdmission.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionDetailController : ControllerBase
    {
        // GET: Controller
        private StudentAdmissionDetailContext _studentAdmissionDetailContext;

        public StudentAdmissionDetailController(StudentAdmissionDetailContext studentAdmissionDetailContext)
        {
            _studentAdmissionDetailContext = studentAdmissionDetailContext;
        }

        // GET: api/<Controller>
        [HttpGet]
        public IEnumerable<StudentAdmissionDetail> Get()
        {
            return _studentAdmissionDetailContext.StudentAdmissionDetails;
        }

        // GET api/<Controller>/5
        [HttpGet("{id}")]
        public StudentAdmissionDetail Get(int id)
        {
            return _studentAdmissionDetailContext.StudentAdmissionDetails.FirstOrDefault(s => s.StudentID == id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] StudentAdmissionDetail value)
        {
            _studentAdmissionDetailContext.StudentAdmissionDetails.Add(value);
            _studentAdmissionDetailContext.SaveChanges();
        }

    }
}
