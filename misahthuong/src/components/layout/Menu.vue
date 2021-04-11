<template>
    <div class="menu">
        <div class="logo active">
            <img src="../../assets/Logo_Full_White.png" >
        </div>
        <div class="option">
            <span><img src="../../assets/icon/dashboard.png" alt=""></span>
            <span>Tổng quan</span>
        </div>
        <div class="option">
            <span><img src="../../assets/icon/dashboard.png" alt=""></span>
            <span>Báo cáo</span>
        </div>
        <div class="option">
            <span><img src="../../assets/icon/dashboard.png" alt=""></span>
            <span>Đơn hàng</span>
        </div>
        <div class="option">
            <span><img src="../../assets/icon/dashboard.png" alt=""></span>
            <span>Mua hàng</span>
        </div>
        <div class="option">
            <span><img src="../../assets/icon/dashboard.png" alt=""></span>
            <span>Khuyến mại</span>
        </div>
        <div class="option active">
            <span><img src="../../assets/icon/dashboard.png" alt=""></span>
            <span>Quản lý cửa hàng</span>
        </div>
        <div class="option">
            <span><img src="../../assets/icon/dashboard.png" alt=""></span>
            <span>Hàng hóa</span>
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
    background-color: #026b97;
    width: 150px;
    height: 100vh;
}
.logo{
    height: 48px;
    width: 100%;
    padding-left: 0px;
    padding-top: 0px;
    padding-bottom: 0px;
    cursor: pointer;
}
.logo img {
    height: 48px;
    width: auto;
}
.option{
    padding-top: 12px;
    height: 32px;
    font-size: 13px;
    padding-left: 12px;
    color: #ffffff;
    background-color: #026b97
}
.option img {
    width: 20px;
    height: 20px;
    align-items: center;
    vertical-align: middle;
    margin-right: 8px;
}
.option span{
    vertical-align: middle;
}
.option:hover{
    background-color: #0088c1;
    cursor: pointer;
}
.active{
    background-color: #00577b;
}
</style>