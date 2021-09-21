using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        private string GetDefaultMessageForStatusCode(object statusCode)
        {
            return StatusCode switch
            {
                400 => "A bad request, you have made",
                401 => "Autorized, you are not",
                404 => "Resourse found, it was not",
                500 => "Errors are the path to dark side.",
                _ => null
            };
        }

        public int StatusCode { get; set; }

        public string Message { get; set; }
    }
}