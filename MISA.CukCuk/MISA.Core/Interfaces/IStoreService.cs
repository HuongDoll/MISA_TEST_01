﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MISA.Core.Entities;

namespace MISA.Core.Interfaces
{
    public interface IStoreService : IBaseService<Store>
    {
        int Delete(Guid storeId);
        int GetCountStore();
        IEnumerable<Store> GetIndexOffset(int position, int offset);
        Store GetByStoreCode(string storeCode);
        IEnumerable<Store> GetStoreFitter(string storeCode, string storeName, string address, string phoneNumber, int status);
        int Insert(Store entity);
        int Update(Store entity, Guid storeId);
        bool ValidateStore(Store store);
    }
}
