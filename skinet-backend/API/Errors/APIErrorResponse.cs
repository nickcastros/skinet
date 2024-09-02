using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace skinet.API.Errors;

public class APIErrorResponse(int statusCode, string message, string? details = null)
{
    public int StatusCode { get; set; } = statusCode;
    public string Message { get; set; } = message;
    public string? Details { get; set; } = details;
}
