using Microsoft.AspNetCore.Http;
using Movies.Core.Exceptions;
using Movies.Core.Http.Responses;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Movies.Core.Middlewares;

public class ErrorHandlerMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception exception)
        {
            var response = context.Response;
            ErrorResponse errorResponse;

            response.StatusCode = StatusCodes.Status400BadRequest;
            response.ContentType = "application/json";

            switch (exception)
            {
                case BusinessException appEx:
                    errorResponse = new ErrorResponse(appEx.Message);
                    break;
                case NotFoundException notFoundEx:
                    errorResponse = new ErrorResponse(notFoundEx.Message);
                    break;
                default:
                    errorResponse = new ErrorResponse(exception.Message);
                    break;
            }

            await response.WriteAsync(JsonConvert.SerializeObject(errorResponse, new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            }));
        }
    }
}