<template>
    <div class="menu">
        <div class="logo active">
            <img src="../../assets/Logo_Full_White.png" >
        </div>
        <div class="option">
            <span class="img overview"></span>
            <span class="lable">Tổng quan</span>
        </div>
        <div class="option">
            <span class="img report">
            </span>
            <span class="lable">Báo cáo</span>
        </div>
        <div class="option">
            <span class="order"><img src="../../assets/icon/ic_sogiaohang.png" ></span>
            <span class="lable-order">Đơn hàng</span>
        </div>
        <div class="option">
            <span class="img purchase"></span>
            <span class="lable">Mua hàng</span>
        </div>
        <div class="option">
            <span class="img promotion"></span>
            <span class="lable">Khuyến mại</span>
        </div>
        <div class="option active">
            <span class="img manage"></span>
            <span class="lable">Quản lý cửa hàng</span>
        </div>
        <div class="option">
            <span class="img goods"></span>
            <span class="lable">Hàng hóa</span>
        </div>
    </div>
</template>
<script>
export default {
  name: 'Menu',
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
.menu{
    background-color: #2b3173;
    width: 150px;
    height: 100vh;
}
.logo{
    height: 52px;
    width: 100%;
    padding-left: 0px;
    padding-top: 0px;
    padding-bottom: 0px;
    cursor: pointer;
}
.logo img {
    height: 52px;
    width: auto;
}
.option{
    padding-top: 12px;
    height: 28px;
    font-size: 13px;
    padding-left: 12px;
    color: #aaacc7 ;
    background-color: #2b3173 ;
    border-bottom: 4px solid #2b3173 ;
}
.img {
    background-image: url("../../assets/slibarmenu.png");
    position: fixed;
    width: 100%;
    height: 44px;
    left: 8px;
    width: 22px;
    text-align: center;
    background-repeat: no-repeat;
    background-position: 0 6px;
}
.lable{
    padding-left: 26px;
}
.lable-order{
    padding-left: 8px;
}
.overview{
    background-position: 0 10px;
    top: 52px;
}
.report{
    background-position: 0 -270px;
    top: 96px;
}

.purchase{
    background-position: 0 -32px;
    top: 184px;
}
.promotion{
    background-position: 0 -190px;
    top: 228px;
}
.manage{
    background-position: 0 -228px;
    top: 270px;
}
.goods{
    background-position: 0 -346px;
    top: 314px;
}
.option span{
    vertical-align: middle;
}
.option:hover{
    background-color: #1e235a;
    cursor: pointer;
}
.active{
    background-color: #1e235a;
}
</style>