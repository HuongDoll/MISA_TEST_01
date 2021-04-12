<template>
    <div>
        <div class="confirmDialog" @click="closeDialog"></div>
        <div class="content">
            <div class="title">
                <span>Thêm mới cửa hàng</span>
                <button type="button" @click="closeDialog"></button>
            </div>
            <div class="main-content">
                <div class="groupdb w-full">
                    <span class="lable">Mã cửa hàng <span class="text-red">*</span> </span>
                    <input class="input" type="text" name="" id="">
                </div>
                <div class="groupdb w-full">
                    <span class="lable">Tên cửa hàng <span class="text-red">*</span> </span>
                    <input class="input" type="text" name="" id="">
                </div>
                <div class="groupdb w-full">
                    <span class="lable">Địa chỉ <span class="text-red">*</span> </span>
                    <textarea name="" id="" rows="5"></textarea>
                </div>
                <div class="groupdb w-full">
                    <div class="group-l w-haf">
                        <span class="lable">Số điện thoại</span>
                        <input class="input" type="text" name="" id="">
                    </div>
                    <div class="group-r w-haf">
                        <span class="lable">Mã số thuế</span>
                        <input class="input" type="text" name="" id="">
                    </div>
                </div>
                <div class="groupdb w-full">
                    <div class="group group-l w-haf">
                        <span class="lable">Quốc gia</span>
                        <select name="" id=""></select>
                    </div>
                    
                </div>
                <div class="groupdb w-full">
                    <div class="group-l w-haf">
                        <span class="lable">Tỉnh/Thành phố</span>
                        <select name="" id=""></select>
                    </div>
                    <div class="group-r w-haf">
                        <span class="lable">Quận huyện</span>
                        <select name="" id=""></select>
                    </div>
                </div>
                <div class="groupdb w-full">
                    <div class="group-l w-haf">
                        <span class="lable">Phường/Xã</span>
                        <select name="" id=""></select>
                    </div>
                    <div class="group-r w-haf">
                        <span class="lable">Đường phố</span>
                        <input type="text" name="" id="">
                    </div>
                </div>
            </div>
            <div class="footer">
                <div class="help">
                    <span class="help-icon"><img src="../../assets/icon/icon_help_18.png" ></span>
                    <span >Trợ giúp</span>
                </div>
                <div class="group-button">
                    <button class="button-save">
                        <span class="img"></span>
                        <span class="label">Lưu</span>
                    </button>
                    <button class="button-add">
                        <span class="img"></span>
                        <span class="label">Lưu và thêm mới</span>
                    </button>
                    <button class="button-cancel">
                        <span class="img"></span>
                        <span class="label">Hủy bỏ</span>
                    </button>
                </div>
            </div>
        </div>
    </div>
</template>
<script>

export default {
  name: 'StoreDialog',
  props: {
  },
  data(){
    return{
      
    }
  },
  methods:{
      closeDialog(){
          this.$emit('closeDialog');
      }
  }
}
</script>
<style scoped>
.text-red{
    color: red;
}
.confirmDialog{
    position: absolute;
    top: 0px;
    left: 0px;
    background-color: rgba(0,0,0,.6);
    width: 100%;
    height: 100vh;
}
.content{
    width: 600px;
    height: auto;
    position: absolute;
    top: calc(50vh - 250px);
    left: calc(50% - 300px);
    background-color: #ffffff;
    border-radius: 4px;
    border: 1px solid #d0d0d0;
}
/* css cho title dialog */
.title{
    width: 100%;
    height: 40px;
    background-color: #f0f0f0;
    padding: 10px 16px 0px 16px ;
    box-sizing: border-box;
}
.title span{
    font-size: 16px;
    font-weight: bold;
    vertical-align: middle;
}
.title button{
    vertical-align: middle;
    height: 16px;
    width: 16px;
    background-color: #f0f0f0;
    border: none;
    position: absolute;
    right: 16px;
    background-image: url("../../assets/common-icon.png");
    background-position: -1127px -127px;
    outline: none;
}
/* css for main content */
.main-content{
    width: 100%;
    height: auto;
    box-sizing: border-box;
    padding: 16px 0 8px 0;
    border: 1px solid #d0d0d0;
}
.groupdb{
    display: flex;
    padding: 4px 16px;
}
.group-l {
    display: flex;
    padding-right: 8px;
}
.group-r {
    display: flex;
    padding-left: 8px;
}
.w-full{
    box-sizing: border-box;
    width: 100%;
}
.w-haf{
    width: 50%;
}
input{
    width: calc(100% - 100px);
}
/* .w-haf input{
    width: calc(100% - 100px);
} */
.w-haf select{
    width: calc(100% - 100px);
}
select{
    height: 33px;
    padding: 2px 8px;
    border-radius: 4px;
    border: 1px solid #d0d0d0;
    outline: none;
}
select:focus{
    border: 1px solid #636dde;
}
input{
    height: 33px !important;
    box-sizing: border-box;
    padding: 2px 8px;
}
input{
    border-radius: 4px;
    border: 1px solid #d0d0d0;
    outline: none;
}
textarea{
    box-sizing: border-box;
    resize: none;
    width: calc(100% - 100px);
    border-radius: 4px;
    border: 1px solid #d0d0d0;
    outline: none;
    padding: 4px 8px;
}
textarea:focus{
    border: 1px solid #636dde;
}
input:focus{
    border: 1px solid #636dde;
}
.groupdb .group select{
    width: calc(100% - 108px);
}
.lable{
    width: 100px;
    font-size: 13px;
    color: #212121;
    padding-top: 4px;
}
/* css footer */
.footer{
    width: 100%;
    height: 68px;
    padding: 16px;
    box-sizing: border-box;
    display: flex;
}
.group-button{
    position: absolute;
    right: 16px;
}
.group-button button{
    background-color: none;
    height: 35px;
    padding: 8px;
    margin-left: 8px;
}
.help span{
    color: #2b3173;
    font-size: 13px;
    font-weight: bold;
}
.help{
    padding: 8px 16px 8px 32px;
    cursor: pointer;
    border-radius: 4px;
}
.help:hover{
    background-color: #e5e6eb;
}
.help:active{
    border: 1px solid #2b3173;
}
.help-icon img{
    width: 16px;
    height: 16px;
    position: absolute;
    left: 24px;
    padding-top: 2px;
}
.img{
    height: 16px;
    width: 16px;
    border: none;
    position: absolute;
}
/* button hủy bỏ */
.button-cancel{
    padding-left: 26px !important;
    color: #2b3173;
    font-weight: bold;
    background-color: #ffffff;
    border: none;
    border-radius: 4px;
    border: 1px solid #ffffff;
    outline: none;
}
.button-cancel:hover{
    border: 1px solid #2b3173;
}
.button-cancel .img{
    right: 60px;
    background-image: url("../../assets/common-icon.png");
    background-position: -1100px -128px;
}
/* button lưu và thêm mới */
.button-add{
    padding-left: 26px !important;
    color: #2b3173;
    font-weight: bold;
    background-color: #ffffff;
    border: none;
    border-radius: 4px;
    border: 1px solid #2b3173;
    outline: none;
}
.button-add:hover{
    color: #6b6f9d ;
}
.button-add .img{
    right: 214px;
    background-image: url("../../assets/common-icon.png");
    background-position: -25px -128px;
}
/* button lưu */
.button-save{
    padding-left: 26px !important;
    color: #ffffff;
    font-weight: bold;
    background-color: #2b3173;
    border: none;
    border-radius: 4px;
    border: 1px solid #2b3173;
    outline: none;
}
.button-save:hover{
    background-color: #6b6f9d;
}
.button-save .img{
    right: 282px;
    background-image: url("../../assets/common-icon.png");
    background-position: -326px -127px;
}
</style>