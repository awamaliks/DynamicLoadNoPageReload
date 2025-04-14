using Microsoft.AspNetCore.Mvc;

namespace DynamicLoadNoPageReload.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewController : ControllerBase
    {
        [HttpGet("view1")]
        public IActionResult GetView1Data()
        {
            var data = new List<object>
            {
                new { Name = "John", Age = 28, City = "New York" },
                new { Name = "Jane", Age = 32, City = "London" }
            };
            return Ok(data);
        }

        [HttpGet("view2")]
        public IActionResult GetView2Data()
        {
            var data = new List<object>
            {
                new { Product = "Laptop", Price = 1200, Stock = 30 },
                new { Product = "Phone", Price = 800, Stock = 50 }
            };
            return Ok(data);
        }

        [HttpGet("view3")]
        public IActionResult GetView3Data()
        {
            var data = new List<object>
            {
                new { Department = "HR", Employees = 5 },
                new { Department = "Engineering", Employees = 20 }
            };
            return Ok(data);
        }
    }
}
