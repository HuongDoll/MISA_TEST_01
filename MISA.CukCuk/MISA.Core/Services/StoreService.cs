using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MISA.Core.Entities;
using MISA.Core.Interfaces;

namespace MISA.Core.Services
{
    public class StoreService : BaseService<Store>, IStoreService
    {
        IStoreRepository _storeRepository;
        public StoreService(IStoreRepository storeRepository) : base(storeRepository) {
            _storeRepository = storeRepository;
        }

        public int Delete(Guid storeId)
        {
            var res = _storeRepository.Delete(storeId);
            return res;
        }

        public Store GetByStoreCode(string storeCode)
        {
            throw new NotImplementedException();
        }

        public int GetCountStore()
        {
            throw new NotImplementedException();
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
            var res = _storeRepository.Insert(entity);
            return res;
        }

        public int Update(Store entity, Guid storeId)
        {
            var res = _storeRepository.Update(entity, storeId);
            return res;
        }
    }
}
