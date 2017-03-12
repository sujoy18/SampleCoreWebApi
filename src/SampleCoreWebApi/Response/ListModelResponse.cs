using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreWebApi.Response
{
    public class ListModelResponse<TModel> : IListModelResponse<TModel>
    {
        public bool DidError
        {
            get;

            set;
            
        }

        public string ErrorMessage
        {
            get;

            set;
        }

        public string Message
        {
            get;

            set;
        }

        public IEnumerable<TModel> Model
        {
            get;

            set;
        }

        public int PageNumber
        {
            get;

            set;
        }

        public int PageSite
        {
            get;

            set;
        }
    }
}
