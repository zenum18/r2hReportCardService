using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using R2hReportCardService.Models;

namespace R2hReportCardService.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
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
        public IEnumerable<string> CreateMentorReportCard([FromBody] MentorReportCard reportCardBody)
        {
            MentorReportCard requestBody = reportCardBody;

            return new string[] {
                requestBody.mentorReportCardId.ToString(),
                requestBody.studentId.ToString(),
                requestBody.mentorId.ToString(),
                requestBody.mentorType.ToString(),
                requestBody.submittedAt.ToString(),
                requestBody.mentorType.ToString()
            };
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
