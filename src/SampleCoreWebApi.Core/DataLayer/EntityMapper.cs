using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SampleCoreWebApi.Core.DataLayer
{
    public class EntityMapper : IEntityMapper
    {
        public IEnumerable<IEntityMap> Mappings { get;  set; }

        public void MapEntities(ModelBuilder modelBuilder)
        {
            foreach (var item in Mappings)
            {
                item.Map(modelBuilder);
            }
        }
    }
}
