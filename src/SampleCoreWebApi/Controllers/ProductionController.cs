using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleCoreWebApi.Core.DataLayer;
using SampleCoreWebApi.Response;
using SampleCoreWebApi.ViewModels;
using SampleCoreWebApi.Extensions;
using Microsoft.EntityFrameworkCore;
using SampleCoreWebApi.AdventureModelBinder;

namespace SampleCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    public class ProductionController:Controller
    {
        IAdventureWorksRepository _Repository;
        public ProductionController(IAdventureWorksRepository repository)
        {
            _Repository = repository;
        }
       [HttpGet]
       [Route("products/PageSize/{pageSize}/PageNumber/{pageNumber}/Name/{name}")]
       public async Task<IActionResult> GetAllProducts(Int32 pageSize = 10, Int32 pageNumber = 1, String name = null)
        {
             var response = new ListModelResponse<ProductViewModel>() as IListModelResponse<ProductViewModel>;

            try
            {
                response.PageNumber = pageNumber;
                response.PageSite = pageSize;
                response.Model =await _Repository.GetProducts(pageSize, pageNumber, name)
                                  .Select(item => item.ToViewModel())
                                  .ToListAsync();
            }
            catch (Exception e)
            {
                response.DidError = true;
                response.Message = e.Message;
            }
            
            return response.ToHttpResponse();
        }

        [HttpPost]
        [Route("products")]
        public async Task CreateProduct([FromBody]ProductViewModel productViewModel)
        {
            var response = new SingleModelResponse<ProductViewModel>() as ISingleResponseModel<ProductViewModel>;
            try
            {
                var entity = await _Repository.AddProductAsync(productViewModel.ToEntity());
                response.Model = entity.ToViewModel();
            }
            catch (Exception ex)
            {

                response.DidError = true;
                response.ErrorMessage = ex.Message;
            }
        }       
    }
}
