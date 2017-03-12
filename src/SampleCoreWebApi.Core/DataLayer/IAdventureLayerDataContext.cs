using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreWebApi.Core.DataLayer
{
   public  interface IAdventureLayerDataContext
    {
         string ConnectionString { get; }
         IEntityMapper EntityMapper { get; }
    }
}
