<template>
  <div  class="notify">
    <div class="notify-ct">
        {{msg}}
    </div>
  </div>
    
</template>
<script>

export default {
  name: 'Notify',
  props: {
  },
  data(){
    return{
        
    }
  },
  computed:{
    msg(){
        return this.$store.getters.getMsg;
    }
  },
  methods:{
      
  }
}
</script>
<style scoped>
.notify{
    min-width: 100px;
    padding: 0 0 0 16px;
    background-color: #434774;
    position: absolute;
    bottom: 80px;
    right: 28px;
    border-radius: 5px;
    box-shadow: 1px 1px 4px #000000;
}
.notify-ct{
    width: calc(100% - 80px);
    padding: 28px 40px;
    color: #434774;
    font-weight: bold;
    border-top-right-radius: 5px;
    background-color: #ffffff;
    font-size: 16px;
}
</style>