<template>
  <div class="app">
    <Menu></Menu>
    <Content />
  </div>
</template>

<script>
import Menu from './components/layout/Menu';
import Content from './components/layout/Content';

export default {
  name: 'App',

  components: {
    Menu,
    Content,
  },
};
</script>
<style>
@import './css/font.css';
body{
  margin: 0px;
  padding: 0px;
}
.app{
  width: 100%;
  height: 100vh;
  min-width: 750px;
  min-height: 360px;
  display: flex;
  font-family: 'GoogleSans-Regular';
}
</style>