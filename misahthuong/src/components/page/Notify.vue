<template>
    <div class="notify">
        {{msg}}
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
    padding: 16px;
    color: #ffffff;
    background-color: #434774;
    opacity: 0.8;
    position: absolute;
    top: 100px;
    right: 24px;
    font-size: 13px;
    border-radius: 5px;
}
</style>