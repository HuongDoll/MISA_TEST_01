<template>
    <div class="main">
      <TableAction @openDialog="openDialog" @openConfirmDialog="openConfirmDialog"  :isChoosed="isChoosed"/>
      <TableContent @openStoreDialog="openDialog" @click="clickStore"/>
      <StoreDialog v-show="isShowDialog" @notify="showNotify" :isShowDialog="isShowDialog" :msg="msg" @closeDialog="closeDialog" />
      <ConfirmDialog v-show="isShowConfirmDialog" @notify="showNotify"  @closeDialog="closeConfirmDialog" />
      <Notify v-show="isShowNotify" />
    </div>
</template>
<script>
import TableAction from '../base/TableAction'
import TableContent from '../base/TableContent'
import StoreDialog from '../page/StoreDialog'
import ConfirmDialog from '../page/ConfirmDialog'
import Notify from '../page/Notify'

export default {
  name: 'MainContent',
  components: {
    TableContent,
    TableAction,
    StoreDialog,
    ConfirmDialog,
    Notify,

  },
  props: {
  },
  data(){
    return{
      isShowDialog : false,
      isShowConfirmDialog : false,
      msg : "put",
      isChoosed : false,
      isShowNotify : false
    }
  },
  methods:{
    closeDialog(){
      this.isShowDialog = false;
    },
    openDialog(text){
      this.isShowDialog = true;
      this.msg = text;
      console.log(text);
    },
    closeConfirmDialog(){
      this.isShowConfirmDialog = false;
    },
    openConfirmDialog(){
      console.log("openConfirmDialog");
      this.isShowConfirmDialog = true;
    },
    clickStore(isclick){
      this.isChoosed = isclick;
    },
    showNotify(){
      this.isShowNotify = true;
      setTimeout(() => {
        this.isShowNotify = false;
      }, 3000);
    }
  }
}
</script>
<style scoped>
.main{
    width: 100%;
    height: calc(100vh - 60px);
    padding-top: 8px;
}
</style>