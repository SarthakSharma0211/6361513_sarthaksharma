using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeeApi.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var logMessage = $"[{DateTime.Now}] Exception: {context.Exception.Message}\n";
            File.AppendAllText("error_log.txt", logMessage);

            context.Result = new ObjectResult("Internal server error occurred.")
            {
                StatusCode = 500
            };
        }
    }
}
