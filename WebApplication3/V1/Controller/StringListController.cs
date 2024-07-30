using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
namespace WebApplication3.V1.Controller;



[ApiController]
[Route("api/[controller]")]
[ApiVersion("1.0")]
public class StringListController: ControllerBase
{
    [HttpGet()]
    public IEnumerable<string> Get()
    {
        return new[] { "1.0" };
    }
}