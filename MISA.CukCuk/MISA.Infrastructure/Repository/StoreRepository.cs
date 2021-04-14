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
    public class StoreRepository : BaseRepository<Store>, IStoreRepository
    {
        public int Delete(Guid storeId)
        {
            string storeName = $"Proc_Delete{_tableName}";
            DynamicParameters dynamicParameters = new DynamicParameters();
            string paramName = $"@{_tableName}Id";
            dynamicParameters.Add(paramName, storeId);
            var entity = _dbConnection.Execute(storeName, param: dynamicParameters, commandType: CommandType.StoredProcedure);
            if (entity != null) return 1;
            else return 0;
        }

        public Store GetByStoreCode(string storeCode)
        {
            string storeName = $"Proc_Get{_tableName}ByStoreCode";
            DynamicParameters dynamicParameters = new DynamicParameters();
            string paramName = $"@{_tableName}Code";
            dynamicParameters.Add(paramName, storeCode);
            var entity = _dbConnection.Query<Store>(storeName, param: dynamicParameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            if (entity != null) return entity;
            else return null;
        }

        public int GetCountStore()
        {
            string storeName = $"Proc_GetCount{_tableName}s";
            var entity = _dbConnection.Execute(storeName, commandType: CommandType.StoredProcedure);
            return entity;
        }

        public IEnumerable<Store> GetIndexOffset(int position, int offset)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Store> GetStoreFitter(string storeCode, string storeName, string address, string phoneNumber, int status)
        {
            throw new NotImplementedException();
        }

        public int Insert(Store entity)
        {
            var storeName = $"Proc_Insert{_tableName}";
            var storeParam = entity;
            var rowAffects = _dbConnection.Execute(storeName, param: storeParam, commandType: CommandType.StoredProcedure);
            return rowAffects;
        }

        public int Update(Store entity, Guid storeId)
        {
            entity.StoreId = storeId;
            var storeName = $"Proc_Update{_tableName}";
            var rowAffects = _dbConnection.Execute(storeName, param: entity, commandType: CommandType.StoredProcedure);
            return rowAffects;
        }
    }
}
