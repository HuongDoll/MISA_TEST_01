using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Core.Entities;
using MISA.Core.Interfaces;
using MISA.Eshop.Parameter;
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
        /// <summary>
        /// Xóa cửa hàng
        /// </summary>
        /// <param name="entityId"> id của cửa hàng cần xóa</param>
        /// <returns>số bản ghi bị ảnh hưởng</returns>
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
        /// <summary>
        /// Thêm mới cửa hàng
        /// </summary>
        /// <param name="store">thông tin cửa hàng</param>
        /// <returns>số bản ghi bị ảnh hường</returns>
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
        /// <summary>
        /// chỉnh sửa thông tin cửa hàng
        /// </summary>
        /// <param name="entityId">id cửa hàng </param>
        /// <param name="store"> thông tin cửa hàng</param>
        /// <returns>số bản ghi bị ảnh hưởng</returns>
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
        /// <summary>
        /// lấy dữ liệu dựa theo vị trí và số bản ghi
        /// </summary>
        /// <param name="position">vị trí</param>
        /// <param name="offset">số bản ghi</param>
        /// <returnsdanh sách bản ghi></returns>
        
        [HttpGet("{position}/{offset}")]
        public IActionResult GetIndexOffset(int position, int offset)
        {
            var res = new ResponeResult();
            // lấy dữ liệu từ database
            var entitie = _storeService.GetIndexOffset(position, offset);
            // Kiểm tra dữ liệu trả về

            res.OnSuccess(res);
            res.DevMsg = "Lấy thông tin thành công!";
            res.UserMsg = "Lấy thông tin cửa hàng thành công!";
            res.Data = entitie;
            return Ok(res);

        }
        // "{storeCode}/{storeName}/{address}/{phoneNumber}/{status}"
        /// <summary>
        /// lọc danh sách khách hàng
        /// </summary>
        /// <param name="parameter">obiject lọc </param>
        /// <returns>danh sách bản ghi thỏa mãn</returns>
        [HttpGet("filter")]
        public IActionResult GetStoreFilter([FromQuery] PagingParameter parameter)
        {
            // string storeCode, string storeName, string address, string phoneNumber, int? status
            var res = new ResponeResult();
            // lấy dữ liệu từ database
            var entitie = _storeService.GetStoreFilter(
                parameter.storeCode, parameter.storeName, parameter.address, parameter.phoneNumber, parameter.status);
            // Kiểm tra dữ liệu trả về

            res.OnSuccess(res);
            res.DevMsg = "Lấy thông tin thành công!";
            res.UserMsg = "Lấy thông tin cửa hàng thành công!";
            res.Data = entitie;
            return Ok(res);

        }
        /// <summary>
        /// lấy số bản ghi
        /// </summary>
        /// <returns>số bản ghi</returns>
        [HttpGet("count")]
        public IActionResult GetCount()
        {
            var res = new ResponeResult();
            // lấy dữ liệu từ database
            var entitie = _storeService.GetCountStore();
            // Kiểm tra dữ liệu trả về

            res.OnSuccess(res);
            res.DevMsg = "Lấy thông tin thành công!";
            res.UserMsg = "Lấy thông tin cửa hàng thành công!";
            res.Data = entitie;
            return Ok(res);
        }
        /// <summary>
        /// lấy cửa hàng dựa theo mã code
        /// </summary>
        /// <param name="storeCode"> mã code</param>
        /// <returns>bản ghi thỏa mãn</returns>
        [HttpGet("byCode/{storeCode}")]
        public IActionResult GetStoreByCode(string storeCode)
        {
            var res = new ResponeResult();
            // lấy dữ liệu từ database
            var entitie = _storeService.GetByStoreCode(storeCode);

            res.OnSuccess(res);
            res.DevMsg = "Lấy thông tin thành công!";
            res.UserMsg = "Lấy thông tin cửa hàng thành công!";
            res.Data = entitie;
            return Ok(res);
        }
    }

    
}
