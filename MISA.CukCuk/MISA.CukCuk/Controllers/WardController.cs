using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Core.Entities;
using MISA.Core.Interfaces;
using MISA.Eshop.Result;

namespace MISA.Eshop.Controllers
{
    public class WardController : BaseEntityController<Ward>
    {
        IWardService _wardService;
        public WardController(IWardService wardService) : base(wardService)
        {
            _wardService = wardService;

        }

        [HttpGet("WithParent/{entityId}")]
        public IActionResult GetWithParent(Guid entityId)
        {
            var res = new ResponeResult();
            // lấy dữ liệu từ database
            var entitie = _wardService.GetWardWithDistrict(entityId);
            // Kiểm tra dữ liệu trả về
            if (entitie == null)
            {
                res.OnBadRequest(res);
                res.DevMsg = "Không có data !";
                res.UserMsg = "Không tìm thấy tỉnh !";
                res.Data = entitie;
                return Ok(res);
            }
            else
            {
                res.OnSuccess(res);
                res.DevMsg = "Lấy dữ liệu thành công!";
                res.UserMsg = "Lấy dữ liệu thành công!";
                res.Data = entitie;
                return Ok(res);
            }
        }
    }
}
