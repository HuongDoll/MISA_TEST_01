using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MISA.Core.Interfaces;

namespace MISA.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ICountryRepository countryRepository, IDistrictRepository districtRepository, IProvinceRepository provinceRepository, IStoreRepository storeRepository, IWardRepository wardRepository)
        {
            CountryRepository = countryRepository;
            DistrictRepository = districtRepository;
            ProvinceRepository = provinceRepository;
            StoreRepository = storeRepository;
            WardRepository = wardRepository;
        }

        public ICountryRepository CountryRepository { get; }

        public IDistrictRepository DistrictRepository { get; }

        public IProvinceRepository ProvinceRepository { get; }

        public IStoreRepository StoreRepository { get; }

        public IWardRepository WardRepository { get; }
    }
}
