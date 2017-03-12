using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleCoreWebApi.Core.EntityLayer;

namespace SampleCoreWebApi.Core.DataLayer
{
    public class AdventureWorksRepository : IAdventureWorksRepository
    {
        AdventureLayerDataContext DbContext;
        public AdventureWorksRepository(AdventureLayerDataContext dbContext)
        {
            DbContext = dbContext;
        }
        public Task<Product> AddProductAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<Product> DeleteProductAsync(Product changes)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetProducts(int pageSize, int pageNumber, string name)
        {
            var query = DbContext.Set<Product>().Skip((pageNumber - 1) * pageSize).Take(pageSize);
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(item => item.Name.ToLower().Contains(name.ToLower()));
            }
            return query;
        }

        public Task<Product> UpdateProductAsync(Product changes)
        {
            throw new NotImplementedException();
        }
    }
}
