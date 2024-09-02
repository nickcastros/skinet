using System;
using Microsoft.AspNetCore.Mvc;
using skinet.API.DTOs;
using skinet.Core.Entities;

namespace skinet.API.Controllers;

public class BuggyController : BaseAPIController
{

    [HttpGet("unauthorized")]
    public ActionResult GetUnauthorized()
    {
        return Unauthorized();
    }

    [HttpGet("badrequest")]
    public ActionResult GetBadRequest()
    {
        return BadRequest("This was not a good request");
    }
    [HttpGet("notfound")]
    public ActionResult GetNotFoundRequest()
    {
        return NotFound();
    }
    [HttpGet("internalerror")]
    public ActionResult GetInternalError()
    {
        throw new Exception("This is an exception");
    }

    [HttpPost("validationerror")]
    public ActionResult GetValidationError(CreateProductDto product)
    {
        return Ok();
    }

}
