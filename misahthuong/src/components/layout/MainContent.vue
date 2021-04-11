<template>
    <div class="main">
      <TableAction />
      <TableContent />
    </div>
</template>
<script>
import TableAction from '../base/TableAction'
import TableContent from '../base/TableContent'

export default {
  name: 'Content',
  components: {
    TableContent,
    TableAction
  },
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
.main{
    width: 100%;
    height: calc(100vh - 56px);
    padding-top: 8px;
}
</style>