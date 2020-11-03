using Microsoft.AspNetCore.Mvc;
using MaskAPI.models;
using System.Collections.Generic;

namespace MaskAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class MaskController : ControllerBase
  {
    public static List<Mask> MasksInStock = new List<Mask>();
    public MaskController()
    {
      MasksInStock.Add(new Mask("m-9999", 1, "White", true, false, "Flowers", 10.00));
      MasksInStock.Add(new Mask("m-8888", 3, "brown", true, false, "dogs", 8.00));
      MasksInStock.Add(new Mask("m-7777", 5, "oprange", true, false, "cats", 5.00));
    }

    [HttpGet("GetAll")]
    public List<Mask> GetAll()
    {
      return MasksInStock;
    }

    [HttpGet("{maskId}")]
    public Mask Get(string maskId)
    {
      Mask found = null;
      foreach (Mask mask in MasksInStock)
      {
        if (maskId == mask.maskId)
        {
          found = mask;
          break;
        }
      }
      return found;
    }
  }
}