<template>
    <div class="header">
        <div class="name">Cửa hàng</div>
        <div class="group">
            <select>
                <option value="" selected> D00AVI - 160 Hoàng Hoa Thám</option>
                <option value="" > D00AVI - 138 Tô Hiệu Hà Đông</option>
                <option value="" > D00AVI - 182 Nguyễn Huy Tưởng</option>
            </select>
            <div class="acount">
                <img src="../../assets/icon/Image.jpg" >
                <span>qtht misa</span>
                <img src="../../assets/icon/chevron-down-solid.svg" class="img-down">
            </div>
            <button class="button-new"><img src="../../assets/icon/misasupport_1.png" class="img-new"></button>
            <button><img src="../../assets/icon/bell.png" ></button>
            <button><img src="../../assets/icon/question.png" ></button>
        </div>
    </div>
</template>
<script>
export default {
  name: 'Header',
  props: {
  },
  data(){
    return{
      items: ['Foo', 'Bar', 'Fizz', 'Buzz'],
    }
  },
  methods:{
  }
}
</script>
<style scoped>
.header{
    display: flex;
    background-color: #ffffff;
    width: 100%;
    height: 52px;
    align-self: flex-end;
}
.group{
    height: 52px;
    display: flex;
    position: absolute;
    right: 0px;
}
.group select{
    margin: 12px;
    font-size: 12px;
    outline: none;
    cursor: pointer;
    border: 1px solid #0088c1;
    border-radius: 4px;
}
.group button {
    width: 52px;
    background-color: #ffffff;
    outline: none;
    border: none;
    border-left: 1px solid #c3ecff;
    padding: 0px;
}
.group button:hover{
    background-color: #d1f1ff ;
}
.name{
    padding-left: 20px;
    padding-top: 14px;
    font-size: 16px;
    font-weight: bold;
    color: #212121;
}
.acount{
    font-size: 12px;
    padding: 12px ;
    padding-top: 14px;
}
.acount img{
    width: 20px;
    height: 20px;
    padding-right: 4px;
    vertical-align: middle;
}
.acount span{
    vertical-align: middle;
}

.acount .img-down{
    width: 10px;
    height: 10px;
    padding-left: 4px;
    vertical-align: middle;
    cursor: pointer;
}
button img{
    width: 20px;
    height: 20px;
    background-color: none;
}
.img-new{
    width: 52px;
    height: 52px;
    padding: 0px;
    background-color: #026b97;
}
button{
    cursor: pointer;
}
</style>