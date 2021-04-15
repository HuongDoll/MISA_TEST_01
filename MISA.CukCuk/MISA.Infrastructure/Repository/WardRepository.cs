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
    public class WardRepository : BaseRepository<Ward>, IWardRepository
    {
        public IEnumerable<Ward> GetWardWithDistrict(Guid entityId)
        {
            string storeName = "Proc_GetWardWithDistrict";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("DistrictId", entityId);
            var entity = _dbConnection.Query<Ward>(storeName, param: dynamicParameters, commandType: CommandType.StoredProcedure);
            return entity;
        }
    }
}
