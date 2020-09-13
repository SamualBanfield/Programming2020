using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BirthdayLib;

namespace API.Controllers
{
  [ApiController]
  [Route("[controller]")]

  public static List<Birthdays> birthdays = new List<Birthdays>();
  public class ExampleController : ControllerBase
  {
    [HttpGet("GetBirthdays")]
    public
  }
}
