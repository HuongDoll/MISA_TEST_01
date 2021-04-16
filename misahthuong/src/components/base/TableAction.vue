<template>
    <div class="table-action">
        <button class="group group-add" @click="openDialog('put')" title="Thêm cửa hàng mới">
          <span class="img add"></span>
          <span class="lable">Thêm mới</span>
        </button>
        <button  class="group" @click="openDialog('copy')" v-bind:class="{ notouch: !isChoosed }" :title="titleButtonCopy">
          <span class="img double"></span>
          <span class="lable">Nhân bản</span>
        </button>
        <button class="group"  @click="openDialog('post')" v-bind:class="{ notouch: !isChoosed }" :title="titleButtonEdit">
          <span class="img edit"></span>
          <span class="lable">Sửa</span>
        </button>
        <button class="group" @click="openConfirmDialog()" v-bind:class="{ notouch: !isChoosed }" :title="titleButtonDelete">
          <span class="img delete"></span>
          <span class="lable">Xóa</span>
        </button>
        <button class="group" title="Nạp lại dữ liệu" @click="reload">
          <span class="img reload"></span>
          <span class="lable">Nạp</span>
        </button>
    </div>
</template>
<script>
export default {
  name: 'TableAcion',
  props: {
      isChoosed : Boolean,
  },
  
  computed:{
    isChoose(){
      var storeChoose = this.$store.getters.getStoreById.length;
      if(storeChoose == 0) return false;
      else return true;
    },
  },
  watch:{
    isChoosed(){
      if(!this.isChoosed) {
        this.titleButtonEdit = "Chọn một cửa hàng để chỉnh sửa";
        this.titleButtonDelete = "Chọn một cửa hàng để xóa";
        this.titleButtonCopy = "Chọn một cửa hàng để nhân bản";
        }
      else {
        this.titleButtonEdit = "Chỉnh sửa";
        this.titleButtonDelete = "Xóa";
        this.titleButtonCopy = "Nhân bản";
        }
    }
  },
  data(){
    return{
      titleButtonEdit : "Chọn một cửa hàng để chỉnh sửa",
      titleButtonDelete : "Chọn một cửa hàng để xóa",
      titleButtonCopy : "Chọn một cửa hàng để nhân bản"
    }
  },
  methods:{
    openDialog(text){
      if(text == "put" || this.isChoosed){
        this.$emit("openDialog", text);
      }
      
    },
    openConfirmDialog(){
      if(this.isChoosed) this.$emit("openConfirmDialog");
      console.log("openConfirmDialog")
    },
    reload(){
      this.$store.dispatch('getStores');
    }
  }
}
</script>
<style scoped>
.notouch{
  cursor: not-allowed;
}
.table-action{
    width: calc(100% - 16px);
    height: 36px;
    background-color: #2b3173 ;
    margin-left: 8px;
    display: flex;
}
.group{
  background-color: #2b3173 ;
  padding: none;
  border: none;
  border-left: 1px solid #190472 ;
  outline: none;
}
.group-add{
  border-left: none ;
}
.group:hover{
  background-color: #6b6f9d;
}
.lable{
  color: #ffffff;
  width: 100%;
  font-size: 12px;
  padding-left: 24px;
  padding-right: 8px;
  vertical-align: middle;
}
.img{
  position: fixed;
  width: 20px;
  height: 20px;
  top: 68px;
  text-align: center;
  background-repeat: no-repeat;
}
.add{
  background-image: url("../../assets/common-icon.png");
  left: 166px;
  background-position: 0px -124px;
}
.double{
  background-image: url("../../assets/common-icon.png");
  left: 262px;
  background-position: -975px -125px;
}
.edit{
  background-image: url("../../assets/common-icon.png");
  left: 358px;
  background-position: -1450px -124px;
}
.delete{
  background-image: url("../../assets/common-icon.png");
  left: 430px;
  background-position: -1075px -125px;
}
.reload{
  background-image: url("../../assets/common-icon.png");
  left: 496px;
  background-position: -875px -124px;
}
</style>