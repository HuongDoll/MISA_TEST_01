using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MISA.Core.Entities;
using MISA.Core.Interfaces;

namespace MISA.Infrastructure.Repository
{
    public class ProvinceRepository : BaseRepository<Province>, IProvinceRepository
    {
        public IEnumerable<Province> GetProvinceWithCountry(Guid entityId)
        {
            string storeName = "Proc_GetProvinceWithCountry";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("CountryId", entityId);
            var entity = _dbConnection.Query<Province>(storeName, param: dynamicParameters, commandType: CommandType.StoredProcedure);
            return entity;
        }
    }
}
