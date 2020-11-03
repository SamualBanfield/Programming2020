using Microsoft.AspNetCore.Mvc;
using MaskAPI.models;
using System.Collections.Generic;

namespace MaskAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class OrderController : ControllerBase
  {
    public static List<Mask> MasksInStock = new List<Mask>();
    public static List<Order> Orders = new List<Order>();

    public OrderController()
    {
      MasksInStock.Add(new Mask("m-9999", 1, "White", true, false, "Flowers", 10.00));
      MasksInStock.Add(new Mask("m-8888", 3, "brown", true, false, "dogs", 8.00));
      MasksInStock.Add(new Mask("m-7777", 5, "oprange", true, false, "cats", 5.00));

      Orders.Add(new Order(new Mask("m-7777", 5, "oprange", true, false, "cats", 5.00), 20));
      Orders.Add(new Order(new Mask("m-8888", 3, "brown", true, false, "dogs", 8.00), 5));
      Orders.Add(new Order(new Mask("m-9999", 1, "White", true, false, "Flowers", 10.00), 3));
    }

    [HttpGet("GetAll")]
    public List<Order> GetAll()
    {
      return Orders;
    }

    [HttpGet("{orderNo}")]
    public Order GetOrder(int orderNo)
    {
      Order found = null;
      foreach (Order order in Orders)
      {
        if (orderNo == order.orderNo)
        {
          found = order;
          break;
        }
      }
      return found;
    }

    [HttpPost]
    public Order MakeOrder(OrderRequest request)
    {
      Mask found = MasksInStock.Find(m => m.maskId == request.maskId);
      if (found == null)
      {
        return null;
      }
      Order newOrder = new Order(found, request.qty);
      Orders.Add(newOrder);
      return newOrder;
    }
  }
}