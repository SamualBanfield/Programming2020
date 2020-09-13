using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace C_.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ProductController : ControllerBase
  {
    [HttpGet("{num1}/{num2}")]
    public string Get(int num1, int num2)
    {
      return Convert.ToString(num1 * num2);
    }
  }
}
