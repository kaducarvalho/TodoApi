using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "Learn .NET", "Build CI/CD teste push2" };
    }
}