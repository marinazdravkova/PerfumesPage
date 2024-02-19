using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RESTfulWebAPI.Filters;

// Second way of handling exceptions is custom exception filter
// This will override handling exceptions in middleware
public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        context.HttpContext.Response.StatusCode = 500;
        context.HttpContext.Response.ContentType = "application/json";
        context.Result = new ObjectResult(new
        {
            Error = context.Exception.Message,
            InnerException = context.Exception.InnerException?.Message
        });
        context.ExceptionHandled = true;
    }
}
