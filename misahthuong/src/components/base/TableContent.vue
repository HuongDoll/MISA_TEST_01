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
              <input type="text" name="" id="" v-model="filter.storeCode">
            </div>
            <div class="wi-2 group-input">
              <select class="select">
                <option value="">* : Chứa</option>
                <option value="">= : Bằng</option>
                <option value="">+ : Bắt đầu bằng</option>
                <option value="">- : Kết thức bằng</option>
                <option value="">! : Không chứa</option>
              </select>
              <input type="text" name="" id="" v-model="filter.storeName">
            </div>
            <div class="wi-3 group-input">
              <select class="select">
                <option value="">* : Chứa</option>
                <option value="">= : Bằng</option>
                <option value="">+ : Bắt đầu bằng</option>
                <option value="">- : Kết thức bằng</option>
                <option value="">! : Không chứa</option>
              </select>
              <input type="text" name="" id="" v-model="filter.address">
            </div>
            <div class="wi-1 group-input">
              <select class="select">
                <option value="">* : Chứa</option>
                <option value="">= : Bằng</option>
                <option value="">+ : Bắt đầu bằng</option>
                <option value="">- : Kết thức bằng</option>
                <option value="">! : Không chứa</option>
              </select>
              <input type="text" name="" id="" v-model="filter.phoneNumber">
            </div>
            <div class="wi-1 group-input">
              <select class="status" v-model="filter.status">
                <option value="">Tất cả</option>
                <option :value=1 selected>Đang hoạt động</option>
                <option :value=0>Ngưng hoạt động</option>
              </select>
              
            </div>
          </div>
          <div v-show="!isLoaded" class="loading">
            <div class="loader"></div>
            <div class="text">Đang nạp dữ liệu</div>
          </div>
          <table  class="tableStore">
            <tr v-for="(store, index) in dataList" :key="index" 
            class="row" :ref="index" 
            @click="choose(index, store.storeId)" 
            @dblclick="updateStore()"
            v-bind:class="{ rowChoose: (rowChoose == index) }">
              <td class="w-1">{{store.storeCode}}</td>
              <td class="w-2">{{store.storeName}}</td>
              <td class="w-3">{{store.address}}</td>
              <td class="w-1">{{store.phoneNumber}}</td>
              <td class="w-1">{{fomatStatusStore(store.status)}}</td>
            </tr>
            
          </table>
          
        </div>
        <div class="page-bar">
          <button class="pre-pre" @click="page.pageNumber -=2"></button>
          <button class="pre" @click="page.pageNumber --"></button>
          <span>Trang</span>
          <input type="number" v-model="page.pageNumber">
          <span>trên {{numberPage}}</span>
          <button class="ne" @click="page.pageNumber ++"></button>
          <button class="ne-ne" @click="page.pageNumber +=2"></button>
          <button class="reload"></button>
          <select name="" id="" v-model="page.numberStoreSelect">
            <option v-for="(number, index) in selectNumberStore" :key="index" :value=number >{{number}}</option>
            
          </select>
          <span class="text-right">Hiển thị {{indexStart}}-{{indexEnd}} trên {{countStore}} kết quả</span>
        </div>
    </div>
</template>
<script>
export default {
  name: 'TableContent',
  props: {

  },
  created(){
    this.$store.dispatch('getStores');
  },
  watch:{
    action(){
      // Lỗi nếu xóa lỗi
      console.log(this.$store.getters.getMsg);
      this.rowChoose = null;
      this.$emit("click", false);
      this.$store.dispatch('getStoreByFilter', this.filter);
    },
    'filter.storeCode'() {
      this.$store.dispatch('getStoreByFilter', this.filter);
    },
    'filter.address'() {
      this.$store.dispatch('getStoreByFilter', this.filter);
    },
    'filter.storeName'() {
      this.$store.dispatch('getStoreByFilter', this.filter);
    },
    'filter.phoneNumber'() {
      this.$store.dispatch('getStoreByFilter', this.filter);
    },
    'filter.status'() {
      this.$store.dispatch('getStoreByFilter', this.filter);
    },
    'page.pageNumber'(){
      if(this.page.pageNumber < 1) this.page.pageNumber = 1;
      if(this.page.pageNumber > this.numberPage) this.page.pageNumber = this.numberPage;
    }
  },
  computed:{
    dataList(){
        return this.$store.getters.getStores.slice(this.indexStart - 1, this.indexEnd);
    },
    action(){
      return this.$store.getters.getAction;
    },
    isLoaded(){
      return this.$store.getters.getLoadData;
    },
    countStore(){
      return this.$store.getters.getStores.length;
    },
    numberPage(){
      var number = (this.countStore - this.countStore%this.page.numberStoreSelect)/this.page.numberStoreSelect;
      if(this.countStore%this.page.numberStoreSelect >0) number ++;
      return number;
    },
    indexStart(){
      if(this.countStore == 0) return 0;
      var number = (this.page.pageNumber - 1) * this.page.numberStoreSelect + 1;
      return number;
    },
    indexEnd(){
      var number = this.page.pageNumber * this.page.numberStoreSelect;
      if(number > this.countStore) number = this.countStore;
      return number;
    }
  },
  data(){
    return{
      rowChoose : null,
      filter: {
        storeCode : "",
        storeName : "", 
        address : "", 
        phoneNumber : "", 
        status : ""
      },
      page: {
        pageNumber : 1,
        numberStoreSelect : 50,
      },
      selectNumberStore : [15, 25, 50, 100]
    }
  },
  methods:{
    fomatStatusStore(code){
      if(code == 0) return "Ngưng hoạt động";
      else return "Đang hoạt động"
    },
    choose(index, storeId){
      console.log("storeId");
      this.rowChoose = index;
      this.$store.dispatch('getStoreById', storeId);
      console.log(this.$store.getters.getStoreById);
      this.$emit("click", true)
    },
    updateStore(){
      this.$emit("openStoreDialog", "post");
    }
  }
}
</script>
<style scoped>
@import '../../css/animationLoader.css';
/* bỏ mũi tên trong input type=number */
input[type=number]::-webkit-inner-spin-button, 
input[type=number]::-webkit-outer-spin-button { 
    -webkit-appearance: none;
    -moz-appearance: none;
    appearance: none;
    margin: 0; 
}
/* css cho animation loading */
.loading{
  width: calc(100% - 182px);
  height: calc(100vh - 218px);
  position: fixed;
  top: 160px;
  background-color: rgba(0, 0, 0, 0.3);
  color: #ffffff;
  text-align: center;
}
.loading .text{
  position: fixed;
  left: calc(50% + 20px);
  top: calc(50% + 90px);
}
/* css cho hàng được chọn */
.rowChoose{
  background-color: #e2e4f1 !important;
}
/* css cho trang */
.table-content{
    width: calc(100% - 16px);
    height: calc(100vh - 104px);
    margin-left: 8px;
    background-color: #ffffff;
}
.table{
  width: 100%;
  height: calc(100vh - 156px);
  border-bottom: 4px solid #d0d0d0 ;
  font-size: 13px;
  overflow-x: scroll;
  overflow-y: visible;
  
}
.heading{
  height: 32px;
  display: flex;
  color: #212121;
  background-color: #f0f0f0;
  position: sticky;
  top: 0px;
}
.heading span{
  text-align: center;
  font-weight: 700;
  border-right: 1px solid #d0d0d0 ;
  border-bottom: 1px solid #d0d0d0 ;
  background-color: #f0f0f0;
  padding: 8px;
}
.tableStore{
  border-spacing: 0px;
  width: 100%;
  height: calc(100vh - 356px);
  max-height: 200px;
  overflow-y: scroll;
}

/* css cho table */
tr:nth-child(even){background-color: #f6f6f6;}

tr:hover {background-color: #eaeff4;}

tr::before {background-color: #e2e4f1;}

.row{
  height: 32px;
  width: 100%;
  display: flex;
}
.row td{
  color: #404040;
  border-right: 1px solid #d0d0d0 ;
  border-bottom: 1px solid #d0d0d0 ;
  padding: 8px;
  font-size: 12px;
}
.group{
  height: 33px;
  display: flex;
  position: sticky;
  top: 32px;
  background-color: #f0f0f0;
}
.group .group-input{
  border-right: 1px solid #d0d0d0 ;
  border-bottom: 1px solid #d0d0d0 ;
  display: flex;
  padding: 0px 1px;
}
.group-input input{
  width: 100%;
  border: 1px solid #d0d0d0 ;
  outline: none;
  padding: 0 8px;
}
.group-input input:focus{
  border: 1px solid #636dde;
}

.group .select{
  width: 32px;
  -webkit-appearance: none;
  -moz-appearance: none;
  text-indent: 1px;
  text-overflow: '';
  outline: none;
  border: 1px solid #d0d0d0 ;
  padding-left: 10px;
  padding-right: 11px;
  padding-top: 4px;
}
.status{
  font-size: 12px;
  width: 100% ;
  outline: none;
  border: 1px solid #d0d0d0 ;
  padding: 4px  ;
}
.page-bar{
  width: calc(100% - 16px);
  height: 36px;
  font-size: 13px;
  color: #4b4c4c;
  padding: 8px;
}
.page-bar button{
  width: 26px;
  height: 26px;
  background-color: #ffffff;
  outline: none;
  border: 1px solid #d0d0d0;
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
  border: 1px solid #d0d0d0;
  border-radius: 4px;
  vertical-align: middle;
  margin-right: 4px;
  text-align: center;
}
.page-bar select{
  height: 26px;
  width: auto;
  background-color: #ffffff;
  outline: none;
  border: 1px solid #d0d0d0;
  border-radius: 4px;
  vertical-align: middle;
  margin-right: 4px;
}
.page-bar .text-right{
  position: absolute;
  right: 24px;
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
  width: 164px;
}
.wi-2{
  min-width: 264px;
  width: 264px;
}
.wi-3{
  width: 60%;
  min-width: 314px;
}

</style>