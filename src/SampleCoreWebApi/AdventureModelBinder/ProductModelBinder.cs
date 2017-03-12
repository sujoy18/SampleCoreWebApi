using Microsoft.AspNetCore.Mvc.ModelBinding;
using SampleCoreWebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreWebApi.AdventureModelBinder
{
    public class ProductModelBinder :IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            ProductViewModel productViewModel = new ProductViewModel();
            var jsonData = new StreamReader(bindingContext.HttpContext.Request.Body).ReadToEnd();
           
            return Task.CompletedTask;
        }
    }
}
