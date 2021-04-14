<template>
    <div class="main">
      <TableAction @openDialog="openDialog" @openConfirmDialog="openConfirmDialog"/>
      <TableContent @openStoreDialog="openDialog" />
      <StoreDialog v-show="isShowDialog" :isShowDialog="isShowDialog" :msg="msg" @closeDialog="closeDialog" />
      <ConfirmDialog v-show="isShowConfirmDialog" @closeDialog="closeConfirmDialog" />
    </div>
</template>
<script>
import TableAction from '../base/TableAction'
import TableContent from '../base/TableContent'
import StoreDialog from '../page/StoreDialog'
import ConfirmDialog from '../page/ConfirmDialog'

export default {
  name: 'Content',
  components: {
    TableContent,
    TableAction,
    StoreDialog,
    ConfirmDialog
  },
  props: {
  },
  data(){
    return{
      isShowDialog : false,
      isShowConfirmDialog : false,
      msg : "put"
    }
  },
  methods:{
    closeDialog(){
      this.isShowDialog = false;
    },
    openDialog(text){
      this.isShowDialog = true;
      this.msg = text;
      console.log(text)
    },
    closeConfirmDialog(){
      this.isShowConfirmDialog = false;
    },
    openConfirmDialog(){
      this.isShowConfirmDialog = true;
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