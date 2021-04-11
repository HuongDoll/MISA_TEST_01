<template>
    <div class="table-content">
        <div class="table">
          <div class="heading">
            <span class="w-1">Mã cửa hàng</span>
            <span class="w-2">Tên cửa hàng</span>
            <span class="w-3">Địa chỉ</span>
            <span class="w-1">Số điện thoại</span>
            <span class="w-1">Trạng thái</span>
          </div>
          <div class="group">
            <div class="wi-1 group-input">
              <select class="select">
                <option value="">* : Chứa</option>
                <option value="">= : Bằng</option>
                <option value="">+ : Bắt đầu bằng</option>
                <option value="">- : Kết thức bằng</option>
                <option value="">! : Không chứa</option>
              </select>
              <input type="text" name="" id="">
            </div>
            <div class="wi-2 group-input">
              <select class="select">
                <option value="">* : Chứa</option>
                <option value="">= : Bằng</option>
                <option value="">+ : Bắt đầu bằng</option>
                <option value="">- : Kết thức bằng</option>
                <option value="">! : Không chứa</option>
              </select>
              <input type="text" name="" id="">
            </div>
            <div class="wi-3 group-input">
              <select class="select">
                <option value="">* : Chứa</option>
                <option value="">= : Bằng</option>
                <option value="">+ : Bắt đầu bằng</option>
                <option value="">- : Kết thức bằng</option>
                <option value="">! : Không chứa</option>
              </select>
              <input type="text" name="" id="">
            </div>
            <div class="wi-1 group-input">
              <select class="select">
                <option value="">* : Chứa</option>
                <option value="">= : Bằng</option>
                <option value="">+ : Bắt đầu bằng</option>
                <option value="">- : Kết thức bằng</option>
                <option value="">! : Không chứa</option>
              </select>
              <input type="text" name="" id="">
            </div>
            <div class="wi-1 group-input">
              <select class="status">
                <option value="">Tất cả</option>
                <option value="" selected>Đang hoạt động</option>
                <option value="">Ngưng hoạt động</option>
              </select>
              
            </div>
          </div>
          <table>
            <tr class="row">
              <td class="w-1">138TH</td>
              <td class="w-2">DODAVI - 318 TÔ HIỆU, HÀ ĐÔNG</td>
              <td class="w-3">318 TÔ HIỆU, HÀ ĐÔNG</td>
              <td class="w-1">024 36622666</td>
              <td class="w-1">Đang hoạt động</td>
            </tr>
          </table>
          
        </div>
        <div class="page-bar">
          <button class="pre-pre"></button>
          <button class="pre"></button>
          <span>Trang</span>
          <input type="text" :v-model="1">
          <span>trên 1</span>
          <button class="ne"></button>
          <button class="ne-ne"></button>
          <button class="reload"></button>
          <select name="" id="">
            <option value="15">15</option>
            <option value="25">25</option>
            <option value="50" selected>50</option>
            <option value="100">100</option>
          </select>
          <span class="text-right">Hiển thị 1-6 trên 6 kết quả</span>
        </div>
    </div>
</template>
<script>
export default {
  name: 'TableContent',
  props: {
  },
  data(){
    return{
      
    }
  },
  methods:{
  }
}
</script>
<style scoped>
.table-content{
    width: calc(100% - 16px);
    height: calc(100vh - 104px);
    margin-left: 8px;
    background-color: #ffffff;
}
.table{
  width: 100%;
  height: calc(100vh - 156px);
  border-bottom: 4px solid #d1f1ff;
  font-size: 12px;
  overflow-x: scroll;
}
.heading{
  height: 32px;
  display: flex;
  color: #212121;
}
.heading span{
  font-weight: bold;
  border-right: 1px solid #d1f1ff;
  border-bottom: 1px solid #d1f1ff;
  padding: 8px;
}
table{
  border-spacing: 0px;
  width: 100%;
}
.row{
  height: 32px;
  width: 100%;
  display: flex;
}
.row td{
  color: #757575;
  border-right: 1px solid #d1f1ff;
  border-bottom: 1px solid #d1f1ff;
  padding: 8px;
  font-size: 12px;
}
.group{
  height: 32px;
  display: flex;
}
.group .group-input{
  border-right: 1px solid #d1f1ff;
  border-bottom: 1px solid #d1f1ff;
  display: flex;
  padding: 1px;
}
.group-input input{
  width: 100%;
  border: 1px solid #d1f1ff;
  outline: none;
}
.group-input input:focus{
  border: 1px solid #0088c1;
}

.group .select{
  width: 32px;
  -webkit-appearance: none;
  -moz-appearance: none;
  text-indent: 1px;
  text-overflow: '';
  outline: none;
  border: 1px solid #d1f1ff;
  padding-left: 10px;
  padding-right: 10px;
  padding-top: 4px;
}
.status{
  font-size: 12px;
  width: 100% ;
  outline: none;
  border: 1px solid #d1f1ff;
  padding: 4px  ;
}
.page-bar{
  width: calc(100% - 16px);
  height: 36px;
  font-size: 12px;
  color: #757575;
  padding: 8px;
}
.page-bar button{
  width: 26px;
  height: 26px;
  background-color: #ffffff;
  outline: none;
  border: 1px solid #c3ecff;
  border-radius: 4px;
  vertical-align: middle;
  margin-right: 4px;
  cursor: pointer;
}
.page-bar input{
  height: 24px;
  width: 48px;
  background-color: #ffffff;
  outline: none;
  border: 1px solid #c3ecff;
  border-radius: 4px;
  vertical-align: middle;
  margin-right: 4px;
}
.page-bar select{
  height: 26px;
  width: auto;
  background-color: #ffffff;
  outline: none;
  border: 1px solid #c3ecff;
  border-radius: 4px;
  vertical-align: middle;
  margin-right: 4px;
}
.page-bar .text-right{
  position: absolute;
  right: 8px;
  bottom: 28px;
}
.page-bar span{
  padding-right: 4px;
}
.pre-pre{
  text-align: center;
  background-repeat: no-repeat;
  background-image: url("../../assets/common-icon.png");
  background-position: -648px -123px;
}
.pre{
  text-align: center;
  background-repeat: no-repeat;
  background-image: url("../../assets/common-icon.png");
  background-position: -699px -123px;
}
.ne-ne{
  background-color: #212121;
  text-align: center;
  background-repeat: no-repeat;
  background-image: url("../../assets/common-icon.png");
  background-position: -798px -123px;
}
.ne{
  background-color: #212121;
  text-align: center;
  background-repeat: no-repeat;
  background-image: url("../../assets/common-icon.png");
  background-position: -748px -123px;
}
.reload{
  background-color: #212121;
  text-align: center;
  background-repeat: no-repeat;
  background-image: url("../../assets/common-icon.png");
  background-position: -849px -124px;
}
.w-1{
  min-width: 150px;
}
.w-2{
  min-width: 250px;
}
.w-3{
  width: 60%;
  min-width: 300px;
}
.wi-1{
  min-width: 164px;
}
.wi-2{
  min-width: 264px;
}
.wi-3{
  width: 60%;
  min-width: 314px;
}

</style>