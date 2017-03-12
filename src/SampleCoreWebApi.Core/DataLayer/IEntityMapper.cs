using Microsoft.EntityFrameworkCore;

namespace SampleCoreWebApi.Core.DataLayer
{
    public interface IEntityMapper 
    {
        void MapEntities(ModelBuilder modelBuilder);
    }
}