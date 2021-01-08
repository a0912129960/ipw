using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class T_IPATTRIBController : ControllerBase
    {
        private readonly IpwContext _context;

        public T_IPATTRIBController(IpwContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Get(string CASE_NO)
        {
            return new JsonResult(_context.T_IPATTRIB.SingleOrDefault(p => p.CASE_NO == CASE_NO));
        }

        [HttpPost] 
        public IActionResult Post([FromBody] T_IPATTRIB entity)
        {
            _context.T_IPATTRIB.Add(entity);
            _context.SaveChanges();
            return Get(entity.CASE_NO);
        }
    }

}
