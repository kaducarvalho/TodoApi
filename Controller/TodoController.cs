using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello DevOps";
    }
}