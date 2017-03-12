using SampleCoreWebApi.Core.EntityLayer;
using SampleCoreWebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreWebApi.Extensions
{
    public static class ViewModelEntityMapper
    {
        public static ProductViewModel ToViewModel(this Product entity)
        {
            return entity == null ? null : new ProductViewModel
            {
                ProductID = entity.ProductID,
                ProductName=entity.Name,
                ProductNumber=entity.ProductNumber
            };
        }


        public static Product ToEntity(this ProductViewModel viewModel)
        {
            var product = new Product();
            product.Name = viewModel.ProductNumber;
            product.ProductNumber = viewModel.ProductNumber;
            return product;
        }
    }
}
