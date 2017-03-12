using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreWebApi.Response
{
    public interface ISingleResponseModel<TModel>:IResponse
    {
        TModel Model { get; set; }
    }
}
