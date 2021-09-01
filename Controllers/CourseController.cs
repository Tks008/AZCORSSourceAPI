using AZCORSSourceAPI.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZCORSSourceAPI.Controllers
{
    [ApiController]
    [Route("api/course")]
    public class CourseController : ControllerBase
    {
        private CourseService _courseService;
        public CourseController(CourseService cservice)
        {
            _courseService = cservice;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_courseService.GetCourses());
        }
    }
}
