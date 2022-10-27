//Jovann Contreras
//Date 10/25/2022
//Peer reviewed by: Griffin Parker - The code looks and runs great!! I'm not sure what models are, but they are obviously working in the program
//Now I have something to look in to when I'm at home today. Great job!!

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GreatLess.Model;

namespace ContrerasJGreaterThanLessThanAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreaterThanLessThanController : ControllerBase
    {
        [HttpGet]
        [Route("GreatorLess")]

        public string GreaterThanLessThanChallenge(GreatLessModel item)
        {
            
            string Answer = "";
            if (item.num1 > item.num2)
            {
                Answer = $"{item.num1} is greater than {item.num2}";
            }
            else if (item.num1 < item.num2)
            {
                Answer = $"{item.num1} is less than {item.num2}";
            }
            else
            {
                Answer = $"{item.num1} is equal to {item.num2}";
            }

            return Answer;
        }
    }
}