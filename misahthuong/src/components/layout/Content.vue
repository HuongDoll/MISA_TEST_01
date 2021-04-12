<template>
    <div class="content">
        <Header />
        <MainContent />
    </div>
</template>
<script>
import Header from './Header.vue'
import MainContent from './MainContent'

export default {
  name: 'Content',
  components: {
    Header,
    MainContent
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
.content{
    background-color: #e5e6eb ;
    width: calc(100% - 150px);
    height: 100vh;
}
</style>