using Microsoft.AspNetCore.Mvc;
using SampleCoreWebApi.AdventureModelBinder;
using SampleCoreWebApi.Core.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreWebApi.ViewModels
{
    [ModelBinder(BinderType = typeof(ProductModelBinder))]
    public class ProductViewModel
    {
       
        public Int32? ProductID { get; set; }

        public String ProductName { get; set; }

        public String ProductNumber { get; set; }

        
    }
}
