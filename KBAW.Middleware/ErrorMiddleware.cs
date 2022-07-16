using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace KBAW.ErrorHandler;

public class ErrorMiddleware
{
    private readonly RequestDelegate _nextMiddleware;

    public ErrorMiddleware(RequestDelegate nextMiddleware)
    {
        _nextMiddleware = nextMiddleware;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _nextMiddleware(context);
        }
        catch (Exception error)
        {
            HttpResponse response = context.Response;
            response.ContentType = "application/json";

            response.StatusCode = error switch
            {
                CustomApplicationException => (int)HttpStatusCode.BadRequest,
                KeyNotFoundException => (int)HttpStatusCode.NotFound,
                _ => (int)HttpStatusCode.InternalServerError
            };

            string result;

            if (error is CustomApplicationException applicationException)
            {
                CustomApplicationException exception = applicationException ?? throw new InvalidOperationException();

                result = JsonSerializer.Serialize(new
                {
                    exception.Message,
                    exception.InnerException,
                    exception.Data,
                    exception.Detail,
                    response.StatusCode
                });
            }
            else
            {
                result = JsonSerializer.Serialize(new
                {
                    error.Message,
                    error.InnerException,
                    error.Data,
                    response.StatusCode
                });
            }

            await response.WriteAsync(result);
        }
    }
}