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
                <img src="../../assets/icon/user-circle-solid.svg" >
                <span>qtht misa</span>
                <img src="../../assets/icon/chevron-down-solid.svg" class="img-down">
            </div>
            <button><img src="../../assets/icon/phone-square-alt-solid.svg" ></button>
            <button><img src="../../assets/icon/bell-solid.svg" ></button>
            <button><img src="../../assets/icon/question-solid.svg" ></button>
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
    height: 48px;
    align-self: flex-end;
}
.group{
    height: 48px;
    display: flex;
    position: absolute;
    right: 0px;
}
.group select{
    margin: 12px;
    font-size: 12px;
    outline: none;
    cursor: pointer;
}
.group button {
    width: 48px;
    background-color: #ffffff;
    outline: none;
    border: none;
    border-left: 1px solid #c3ecff;
}
.group button:hover{
    background-color: #d1f1ff ;
}
.name{
    padding-left: 20px;
    padding-top: 12px;
    font-size: 16px;
    font-weight: bold;
}
.acount{
    font-size: 12px;
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
}
button{
    cursor: pointer;
}
</style>