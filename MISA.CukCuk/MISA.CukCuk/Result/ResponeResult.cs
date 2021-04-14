using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Eshop.Result
{
    public class ResponeResult
    {
        public bool IsSuccess { get; set; }

        public string DevMsg { get; set; }

        public string UserMsg { get; set; }

        public int ErrorCode { get; set; } 

        /// <summary>
        /// Thêm thông tin tìm hiểu cho dev
        /// </summary>
        public string MoreInfo { get; set; }

        /// <summary>
        /// Mã lỗi trên tìm kiếm trên trang  nào đó
        /// </summary>
        public string TraceId { get; set; }

        public object Data { get; set; }

        public void OnSuccess(ResponeResult result)
        {
            result.IsSuccess = true;
        }

        public void OnBadRequest(ResponeResult result)
        {
            result.IsSuccess = false;
        }
    }
}
