using System;
using EventManagerWebApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace EventManagerWebApi.Controllers;

[ApiController]
public class EventController : ControllerBase
{
    [HttpGet("api/events")]
    public IActionResult GetEvents()
    {
        EventRepository repo = new EventRepository();

        var result = repo.GetAll();

        return Ok(result);
    }
}