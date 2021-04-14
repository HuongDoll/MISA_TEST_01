<template>
    <div class="header">
        <div class="name">Cửa hàng</div>
        <div class="group">
            <select>
                <option value="" selected> D00AVI - 160 Hoàng Hoa Thám</option>
                <option value="" > D00AVI - 138 Tô Hiệu Hà Đông</option>
                <option value="" > D00AVI - 182 Nguyễn Huy Tưởng</option>
            </select>
            <div class="acount" @click="ShowAcount">
                <img src="../../assets/icon/Image.jpg" >
                <span>Hoàng Thị Thu Hương</span>
                <img src="../../assets/icon/chevron-down-solid.svg" class="img-down">
            </div>
            
            <button class="button-new"><img src="../../assets/icon/misasupport_1.png" class="img-new"></button>
            <button class="notify"><img></button>
            <button class="help"><img></button>
        </div>
        <div v-show="isShowAcount" class="setting" @click="ShowAcount" ></div>
        <div v-show="isShowAcount" class="acount-setting">
            <div  @click="ShowAcount">
                <img class="icon" src="../../assets/icon/icon-change-password16.png">
                <span class="label-setting">Thay đổi mật khẩu</span>
            </div>
            <div  @click="ShowAcount">
                <img class="icon" src="../../assets/icon/icon-feedback.png">
                <span class="label-setting">Góp ý với nhà phát triển</span>
            </div>
            <div @click="ShowAcount">
                <img class="icon" src="../../assets/icon/icon-logout16.png">
                <span class="label-setting">Đăng xuất</span>
            </div>
        </div>
    </div>
</template>
<script>
export default {
  name: 'Header',
  props: {
  },
  data(){
    return{
      isShowAcount: false,
    }
  },
  methods:{
      ShowAcount(){
          this.isShowAcount = !this.isShowAcount;
      }
  }
}
</script>
<style scoped>
.header{
    display: flex;
    background-color: #ffffff;
    width: 100%;
    height: 52px;
    align-self: flex-end;
}
.group{
    height: 52px;
    display: flex;
    position: absolute;
    right: 0px;
}
.group select{
    height: 32px;
    margin: 12px;
    font-size: 12px;
    outline: none;
    cursor: pointer;
    border: 1px solid #c3c3c3;
    border-radius: 4px;
}
.group button {
    width: 52px;
    background-color: #ffffff;
    outline: none;
    border: none;
    border-left: 1px solid #c3c3c3;
    padding: 0px;
}

.name{
    padding-left: 20px;
    padding-top: 14px;
    font-size: 18px;
    font-weight: 700;
    color: #212121;
}
.acount{
    font-size: 13px;
    padding: 14px ;
    padding-top: 14px;
    color: #212121;
    font-weight: 700;
    cursor: pointer;
}
.acount img{
    width: 28px;
    height: 28px;
    padding-right: 4px;
    vertical-align: middle;
}
.acount span{
    vertical-align: middle;
}

.acount .img-down{
    width: 10px;
    height: 10px;
    padding-left: 8px;
    vertical-align: middle;
    cursor: pointer;
}
button img{
    width: 20px;
    height: 20px;
    background-color: none;
}
.img-new{
    width: 52px;
    height: 52px;
    padding: 0px;
    background-color: #2b3173 ;
}
.img-new:hover{
    background-color: #2b3173 ;
}
button{
    cursor: pointer;
}
.notify img{
    width: 18px;
    height: 18px;
    content: url("../../assets/icon/notify-18.png");
}
.notify:hover img{
    content: url("../../assets/icon/notify-hover-18.png");
}
.help img{
    width: 18px;
    height: 18px;
    content: url("../../assets/icon/icon_help_18.png");
}
.help:hover img{
    content: url("../../assets/icon/icon-help-18-hover.png");
}
/*css Cài đặt tài khoản */
.acount-setting{
    z-index: 6;
    width: 190px;
    background-color: #ffffff;
    position: absolute;
    top: 50px;
    right: 158px;
    font-size: 13px;
    border: 1px solid #c3c3c3;
    border-radius: 4px;
    box-shadow: 1px 1px 4px #000000;
}
.acount-setting div{
    box-sizing: border-box;
    width: 100%;
    padding: 8px;
    border-bottom: 1px solid #c3c3c3;
}
.acount-setting div:hover{
    color: #636dde;
}
.icon{
    padding-right: 8px;
    vertical-align: middle;
}
.setting{
    z-index: 5;
    position: absolute;
    width: calc(100% - 150px);
    height: 100vh;
}
</style>