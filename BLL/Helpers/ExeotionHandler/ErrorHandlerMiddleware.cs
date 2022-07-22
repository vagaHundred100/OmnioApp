using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Helpers.ExeotionHandler
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        ILogger<ErrorHandlerMiddleware> _logger;

        public ErrorHandlerMiddleware(RequestDelegate next, ILogger<ErrorHandlerMiddleware>logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch(Exception error)
            {
                var response = context.Response;
                response.StatusCode = (int)HttpStatusCode.InternalServerError;
                response.ContentType = "application/json";
                _logger.LogError(error, error.Message);
            }
        }
    }
}
