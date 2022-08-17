using DAL.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Helpers
{
    public static class ResponseCreator
    {
        public static Responce CreateUnsuccessifullResponse(List<string> errorMessages, int statusCode)
        {
            var response = new Responce();
            response.StatusCode = statusCode;
            response.Success = false;
            response.ErrorMessages.AddRange(errorMessages);
            return response;
        }

        public static ResponceWithData<T> CreateUnsuccessifullResponseWithData<T>(List<string> errorMessages, int statusCode)
        {
            var response = new ResponceWithData<T>();
            response.StatusCode = statusCode;
            response.Success = false;
            response.ErrorMessages.AddRange(errorMessages);
            return response;
        }

        public static Responce CreateSuccessifullResponse()
        {
            return new Responce();
        }

        public static ResponceWithData<T> CreateSuccessifullResponseWithData<T>()
        {
            return new ResponceWithData<T>();
        }

    }
}
