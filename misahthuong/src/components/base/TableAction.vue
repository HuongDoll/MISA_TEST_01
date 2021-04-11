<template>
    <div class="table-action">
        <button class="group">
          <span class="img add"></span>
          <span class="lable">Thêm mới</span>
        </button>
        <button  class="group">
          <span class="img double"></span>
          <span class="lable">Nhân bản</span>
        </button>
        <button class="group">
          <span class="img edit"></span>
          <span class="lable">Sửa</span>
        </button>
        <button class="group">
          <span class="img delete"></span>
          <span class="lable">Xóa</span>
        </button>
        <button class="group">
          <span class="img reload"></span>
          <span class="lable">Nạp</span>
        </button>
    </div>
</template>
<script>
export default {
  name: 'TableAcion',
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
.table-action{
    width: calc(100% - 16px);
    height: 36px;
    background-color: #026b97;
    margin-left: 8px;
    display: flex;
}
.group{
  background-color: #026b97;
  padding: none;
  border: none;
  border-left: 1px solid #00577b;
  outline: none;
}
.group:hover{
  background-color: #0088c1;
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