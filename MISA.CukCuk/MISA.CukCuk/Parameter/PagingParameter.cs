using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Eshop.Parameter
{
    public class PagingParameter
    {
        public string storeCode { get; set; }

        public string storeName { get; set; }

        public string address { get; set; }

        public string phoneNumber { get; set; }

        public int? status { get; set; }
    }
}
