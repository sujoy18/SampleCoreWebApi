using Microsoft.AspNetCore.Mvc.ModelBinding;
using SampleCoreWebApi.AdventureModelBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreWebApi.AdventureModelBInderProvider
{
    public class AdventureModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            var modelBinder = Activator.CreateInstance(context.BindingInfo.BinderType) as IModelBinder;
            return modelBinder;
        }
    }
}
