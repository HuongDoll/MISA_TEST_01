<template>
    <div>
        <div class="confirmDialog" @click="closeDialog"></div>
        <div class="content">
            <div class="title">
                <span>Xóa dữ liệu</span>
                <button type="button" @click="closeDialog"></button>
            </div>
            <div class="main-content">
              <span class="icon-question"></span>
              <div>Bạn có chắc chắn muốn xóa {{storeName}} khỏi danh sách cửa hàng?</div>
            </div>
            <div class="footer">
                
                <div class="group-button">
                    <button class="button-delete" >
                        <img src="../../assets/icon/delete-white.png">
                        <span class="label">Xóa</span>
                    </button>
                    
                    <button class="button-cancel"  @click="closeDialog">
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
  name: 'ConfirmDialog',
  props: {
  },
  data(){
    return{
        
    }
  },
  computed:{
    storeName(){
      console.log(this.$store.getters.getStoreById)
        return this.$store.getters.getStoreById[0].storeName;
    }
  },
  methods:{
      closeDialog(){
          this.$emit('closeDialog');
      },
      
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
    width: 400px;
    height: auto;
    position: absolute;
    top: calc(50vh - 250px);
    left: calc(50% - 200px);
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
  min-height: 64px;
  height: auto;
  box-sizing: border-box;
  padding: 8px 0 8px 0;
  border: 1px solid #d0d0d0;
  box-sizing: border-box;
  vertical-align: middle;
}
.main-content div{
 padding: 8px 16px 8px 60px;
 font-size: 13px;
 vertical-align: middle;
}
.icon-question{
  height: 44px;
  width: 44px;
  position: absolute;
  right: 350px;
  top: 50px;
  background-image: url("../../assets/icon/icon-popup.png");
  background-position: -164px 0px;
}
/* css footer */
.footer{
    width: 100%;
    height: 50px;
    padding: 8px 16px;
    box-sizing: border-box;
    display: flex;
    font-size: 12px;
}
.group-button{
    position: absolute;
    right: 16px;
}
.group-button button{
    background-color: none;
    height: 32px;
    padding: 8px;
    margin-left: 8px;
}
.img{
    height: 16px;
    width: 16px;
    border: none;
    position: absolute;
}
/* button hủy bỏ */
.button-cancel{
  font-size: 12px;
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
.button-cancel:focus{
    border: 1px solid #2b3173;
}
.button-cancel .img{
    right: 58px;
    background-image: url("../../assets/common-icon.png");
    background-position: -1100px -129px;
}
/* button lưu và thêm mới */
.button-delete{
  font-size: 12px;
  padding-left: 24px !important;
  padding-right: 16px !important;
  color: #ffffff;
  font-weight: 700;
  background-color: #Df4646;
  border: none;
  border-radius: 4px;
  border: none;
  outline: none;
}
.button-delete img{
  padding-right: 8px;
  position: absolute;
  right: 122px;
}
.button-delete span{
  vertical-align: middle;
}

</style>