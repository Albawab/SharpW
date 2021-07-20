using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exception.Error.Api
{
    public class HttpResponseExceptionFilter : IActionFilter, IOrderedFilter
    {
        public int Order { get; } = int.MaxValue - 10;

        public void OnActionExecuting(ActionExecutingContext context) { }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception is HttpResponseException httpResponseException)
            {
                context.Result = new ObjectResult(httpResponseException.Value)
                {
                    StatusCode = httpResponseException.Status,
                };
                context.ExceptionHandled = true;
            }
            else if (context.Exception is System.Exception exception)
            {
                context.Result = new ObjectResult(exception.Message)
                {
                    StatusCode = 500,
                };
                context.ExceptionHandled = true;
            }
            else if (context.Exception is DbUpdateConcurrencyException dbUpdateConcurrencyException)
            {
                context.Result = new ObjectResult(dbUpdateConcurrencyException.Message)
                {
                    StatusCode = 500,
                };
                context.ExceptionHandled = true;
            }
            else
            {
                var objectResult = context.Result as ObjectResult;

                context.Result = new ObjectResult(context.Result)
                {
                    StatusCode = (int)objectResult.StatusCode,
                    Value = objectResult.Value,
                };
            }
        }
    }
}
