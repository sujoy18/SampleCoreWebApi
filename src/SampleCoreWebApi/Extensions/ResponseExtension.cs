using Microsoft.AspNetCore.Mvc;
using SampleCoreWebApi.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SampleCoreWebApi.Extensions
{
    public static class ResponseExtension
    {
        public static IActionResult ToHttpResponse<TModel>(this IListModelResponse<TModel> response)
        {
            
            var status = HttpStatusCode.OK;
            if (response.DidError)
                status = HttpStatusCode.InternalServerError;
            else if (response.Model==null)
            {
                status = HttpStatusCode.NoContent;
            }
            return new ObjectResult(response) { StatusCode = (Int32)status };
        }
        public static IActionResult ToHttpResponse<TModel>(this ISingleResponseModel<TModel> response)
        {
            var status = HttpStatusCode.OK;
            if (response.DidError)
                status = HttpStatusCode.InternalServerError;
            else if (response.Model == null)
            {
                status = HttpStatusCode.NoContent;
            }
            return new ObjectResult(response) { StatusCode = (Int32)status };
        }
    }
}
