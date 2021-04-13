using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MISA.Core.Entities;
using MISA.Core.Interfaces;

namespace MISA.Eshop.Controllers
{
    public class CountryController : BaseEntityController<Country>
    {
        ICountryService _countryService;
        public CountryController(ICountryService countryService) : base(countryService)
        {
            _countryService = countryService;

        }
    }
}
