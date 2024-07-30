using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.V1.Controller;
[ApiController]
[Route("api/StringList")]
[ApiVersion("2.0")]
public class StringListV2Controller: ControllerBase
{
    [HttpGet()]
    public IEnumerable<string> Get()
    {
        return new[] { "2.0" };
    }
}