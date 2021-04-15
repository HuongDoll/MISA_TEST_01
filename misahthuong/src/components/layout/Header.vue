<template>
  <div class="header">
    <div class="name">Cửa hàng</div>
    <div class="group">
      <div class="aselect">
        <div class="selector select-1">
          <div class="label">
            <span>{{ valueSelect }}</span>
          </div>
          <div class="arrow"></div>
          <div class="visible">
            <ul>
              <li
                :class="{ current: item === valueSelect }"
                v-for="item in listSelect"
                @click="clickSelect(item)"
                :key="item"
              >
                {{ item }}
              </li>
            </ul>
          </div>
        </div>
      </div>

      <div class="acount" @click="ShowAcount">
        <img src="../../assets/icon/Image.jpg" />
        <span>Hoàng Thị Thu Hương</span>
        <img src="../../assets/icon/chevron-down-solid.svg" class="img-down" />
      </div>

      <button class="button-new">
        <img src="../../assets/icon/misasupport_1.png" class="img-new" />
      </button>
      <button class="notify"><img /></button>
      <button class="help"><img /></button>
    </div>
    <div v-show="isShowAcount" class="setting" @click="ShowAcount"></div>
    <div v-show="isShowAcount" class="acount-setting">
      <div @click="ShowAcount">
        <img class="icon" src="../../assets/icon/icon-change-password16.png" />
        <span class="label-setting">Thay đổi mật khẩu</span>
      </div>
      <div @click="ShowAcount">
        <img class="icon" src="../../assets/icon/icon-feedback.png" />
        <span class="label-setting">Góp ý với nhà phát triển</span>
      </div>
      <div @click="ShowAcount">
        <img class="icon" src="../../assets/icon/icon-logout16.png" />
        <span class="label-setting">Đăng xuất</span>
      </div>
    </div>
  </div>
</template>
<script>
export default {
  name: "Header",
  props: {},
  data() {
    return {
      isShowAcount: false,
      listSelect: {
        value1: "Chuỗi cửa hàng",
        value2: "Kho tổng",
        value3: "K2",
        value4: "misard",
        value5: "Cinrale",
        value6: "Circle K",
      },
      valueSelect: "Chuỗi cửa hàng",
    };
  },
  methods: {
    ShowAcount() {
      this.isShowAcount = !this.isShowAcount;
    },
    clickSelect(item) {
      this.valueSelect = item;
    },
  },
};
</script>
<style scoped>
.aselect {
  border-radius: 4px;
  padding-top: 12px;
  font-size: 13px;
}

.selector {
  border: 1px solid gainsboro;
  border-radius: 4px;
  width: 130px;
  background: #ffffff;
  position: relative;
  height: 30px;
}

.selector1 {
  height: 20px;
  width: 100%;
  height: 100%;
  border: none;
}

.selector .arrow {
  position: absolute;
  right: 7px;
  top: 35%;
  width: 10px;
  height: 10px;
  background-size: contain;
  background-repeat: no-repeat;
  background-image: url("../../assets/icon/arrow-down-line.png");
}

/* .selector:active .arrow {
  transform: rotateZ(180deg) translateY(2px);
} */

.label {
  display: block;
  padding: 6px 8px;
  text-align: left;
  font-weight: normal;
  height: 100%;
}

.label1 {
  display: block;
  margin: 0 0 15px 0;
  text-align: left;
}

.selector ul {
  width: 100%;
  list-style-type: none;
  padding: 0;
  margin: 0;
  border: 1px solid gainsboro;
  border-radius: 4px;
  position: absolute;
  z-index: 4;
  background: #fff;
}

.selector .ul1 {
  width: 107%;
  margin-left: -13px;
}
.selector li {
  padding: 6px;
  text-align: left;
  margin: 6px;
  font-weight: normal;
  border-radius: 4px;
}

.selector li:hover {
  background: #cce8ff;
}

.selector .visible {
  visibility: hidden;
}
.selector:hover .visible {
  visibility: visible;
}
.header {
  display: flex;
  background-color: #ffffff;
  width: 100%;
  height: 52px;
  align-self: flex-end;
}
.group {
  height: 52px;
  display: flex;
  position: absolute;
  right: 0px;
}
.group select {
  height: 32px;
  margin: 12px;
  font-size: 12px;
  outline: none;
  cursor: pointer;
  border: 1px solid #c3c3c3;
  border-radius: 4px;
}
.group button {
  width: 52px;
  background-color: #ffffff;
  outline: none;
  border: none;
  border-left: 1px solid #c3c3c3;
  padding: 0px;
}

.name {
  padding-left: 20px;
  padding-top: 14px;
  font-size: 18px;
  font-weight: 700;
  color: #212121;
}
.acount {
  font-size: 13px;
  padding: 14px;
  padding-top: 14px;
  color: #212121;
  font-weight: 700;
  cursor: pointer;
}
.acount img {
  width: 28px;
  height: 28px;
  padding-right: 4px;
  vertical-align: middle;
}
.acount span {
  vertical-align: middle;
}

.acount .img-down {
  width: 10px;
  height: 10px;
  padding-left: 8px;
  vertical-align: middle;
  cursor: pointer;
}
button img {
  width: 20px;
  height: 20px;
  background-color: none;
}
.img-new {
  width: 52px;
  height: 52px;
  padding: 0px;
  background-color: #2b3173;
}
.img-new:hover {
  background-color: #2b3173;
}
button {
  cursor: pointer;
}
.notify img {
  width: 18px;
  height: 18px;
  content: url("../../assets/icon/notify-18.png");
}
.notify:hover img {
  content: url("../../assets/icon/notify-hover-18.png");
}
.help img {
  width: 18px;
  height: 18px;
  content: url("../../assets/icon/icon_help_18.png");
}
.help:hover img {
  content: url("../../assets/icon/icon-help-18-hover.png");
}
/*css Cài đặt tài khoản */
.acount-setting {
  z-index: 6;
  width: 190px;
  background-color: #ffffff;
  position: absolute;
  top: 50px;
  right: 158px;
  font-size: 13px;
  border: 1px solid #c3c3c3;
  border-radius: 4px;
  box-shadow: 1px 1px 4px #000000;
}
.acount-setting div {
  box-sizing: border-box;
  width: 100%;
  padding: 8px;
  border-bottom: 1px solid #c3c3c3;
}
.acount-setting div:hover {
  color: #636dde;
}
.icon {
  padding-right: 8px;
  vertical-align: middle;
}
.setting {
  z-index: 5;
  position: absolute;
  width: calc(100% - 150px);
  height: 100vh;
}
</style>