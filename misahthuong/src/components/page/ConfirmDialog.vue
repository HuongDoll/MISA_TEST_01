<template>
    <div class="confirmDialog">
        <div class="content">

        </div>
    </div>
</template>
<script>

export default {
  name: 'Content',
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
.confirmDialog{
    background-color: rgba(0,0,0,.6);
    width: 100%;
    height: 100vh;
}
.content{
    width: 600px;
    height: 500px;
    position: absolute;
    top: calc(50vh - 250px);
    left: calc(50% - 300px);
    background-color: #ffffff;
}
</style>