<template>
    <div class="main">
      <TableAction @openDialog="openDialog"/>
      <TableContent />
      <StoreDialog v-show="isShowDialog" @closeDialog="closeDialog" />
    </div>
</template>
<script>
import TableAction from '../base/TableAction'
import TableContent from '../base/TableContent'
import StoreDialog from '../page/StoreDialog'

export default {
  name: 'Content',
  components: {
    TableContent,
    TableAction,
    StoreDialog
  },
  props: {
  },
  data(){
    return{
      isShowDialog : false,
    }
  },
  methods:{
    closeDialog(){
      this.isShowDialog = false;
    },
    openDialog(){
      this.isShowDialog = true;
    },
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