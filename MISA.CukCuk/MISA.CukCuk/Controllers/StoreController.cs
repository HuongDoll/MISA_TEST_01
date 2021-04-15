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
    public class StoreController : BaseEntityController<Store>
    {
        IStoreService _storeService;
        public StoreController(IStoreService storeService) : base(storeService)
        {
            _storeService = storeService;

        }

        [HttpDelete("{entityId}")]
        public IActionResult Delete(Guid entityId)
        {
            var res = new ResponeResult();
            // lấy dữ liệu từ database
            var entitie = _storeService.Delete(entityId);
            // Kiểm tra dữ liệu trả về
            if (entitie == 0)
            {
                res.OnBadRequest(res);
                res.DevMsg = "Có lỗi xảy ra !";
                res.UserMsg = "Có lỗi xảy ra !";
                res.Data = entitie;
                return BadRequest(res);
            }
            else
            {
                res.OnSuccess(res);
                res.DevMsg = "Xóa cửa hàng thành công!";
                res.UserMsg = "Xóa cửa hàng thành công!";
                res.Data = entitie;
                return Ok(res);
            }
        }

        [HttpPost]
        public IActionResult Post(Store store)
        {
            var res = new ResponeResult();
            // lấy dữ liệu từ database
            store.StoreId = new Guid();
            var entitie = _storeService.Insert(store);
            // Kiểm tra dữ liệu trả về
            if (entitie == 0)
            {
                res.OnBadRequest(res);
                res.DevMsg = "Có lỗi xảy ra !";
                res.UserMsg = "Thêm mới cửa hàng thất bại!";
                res.Data = entitie;
                return BadRequest(res);
            }
            else
            {
                res.OnSuccess(res);
                res.DevMsg = "Thêm cửa hàng thành công!";
                res.UserMsg = "Thêm mới cửa hàng thành công!";
                res.Data = entitie;
                return Ok(res);
            }
        }
        [HttpPut("{entityId}")]
        public IActionResult Put(Guid entityId, Store store)
        {
            var res = new ResponeResult();
            // lấy dữ liệu từ database
            var entitie = _storeService.Update(store, entityId);
            // Kiểm tra dữ liệu trả về
            if (entitie == 0)
            {
                res.OnBadRequest(res);
                res.DevMsg = "Có lỗi xảy ra !";
                res.UserMsg = "Thay đổi thông tin cửa hàng thất bại!";
                res.Data = entitie;
                return BadRequest(res);
            }
            else
            {
                res.OnSuccess(res);
                res.DevMsg = "Thay đổi thông tin thành công!";
                res.UserMsg = "Thay đổi thông tin cửa hàng thành công!";
                res.Data = entitie;
                return Ok(res);
            }
        }
    }
}
