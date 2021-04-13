using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interfaces
{
    public interface IUnitOfWork
    {
        public ICountryRepository CountryRepository { get; }
        public IDistrictRepository DistrictRepository { get; }
        public IProvinceRepository ProvinceRepository { get; }
        public IStoreRepository StoreRepository { get; }
        public IWardRepository WardRepository { get; }
    }
}
