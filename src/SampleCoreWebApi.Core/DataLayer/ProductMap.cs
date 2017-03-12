using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleCoreWebApi.Core.EntityLayer;

namespace SampleCoreWebApi.Core.DataLayer
{
    public class ProductMap : IEntityMap
    {
        public void Map(ModelBuilder modelBulder)
        {
            var entity = modelBulder.Entity<Product>();
            entity.ToTable("Product", "Production");
            entity.HasKey(p => new { p.ProductID});
            entity.Property(p => p.ProductID).UseSqlServerIdentityColumn();

        }
    }
}
