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
    public class DistrictRepository : BaseRepository<District>, IDistrictRepository
    {
        public IEnumerable<District> GetDistrictWithProvince(Guid entityId)
        {
            string storeName = "Proc_GetDistrictWithProvince";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("ProvinceId", entityId);
            var entity = _dbConnection.Query<District>(storeName, param: dynamicParameters, commandType: CommandType.StoredProcedure);
            return entity;
        }
        
    }
}
