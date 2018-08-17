using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using R2hReportCardService.Models;
using R2hReportCardService.Services;
using Microsoft.Extensions.Configuration;

namespace R2hReportCardService.Controllers
{
    [Route("api/[controller]")]
    public class R2hReportCardController : Controller
    {
        private readonly R2hReportCardContext _context;
        private readonly IConfiguration _config;
        // constructor 
        public R2hReportCardController(R2hReportCardContext c, IConfiguration f)
        {
            _context = c;
            _config = f;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [Route("/MentorReportCard")]
        public bool CreateMentorReportCard([FromBody] MentorReportCard reportCardBody)
        {
            
            MentorReportCard requestBody = reportCardBody;
            string dbConnString = _config["R2HGB_DB_CONN"];
            ReportCardService service = new ReportCardService();
            try
            {
                Console.WriteLine("Callling Service");
                service.createMentorReportCard(requestBody, dbConnString);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to save to db: {e}");
            }

            return true;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
