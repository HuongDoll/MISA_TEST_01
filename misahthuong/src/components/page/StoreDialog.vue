<template>
  <div>
    <div class="confirmDialog" @click="closeDialog"></div>
    <div class="content">
      <div class="title">
        <span>{{ titleName }}</span>
        <button type="button" @click="closeDialog"></button>
      </div>
      <div class="main-content">
        <span tabindex="1" @focus="tabIndexLast()"></span>
        <div class="groupdb w-full">
          <span class="lable"
            >Mã cửa hàng <span class="text-red">*</span>
          </span>
          <input
            v-model="store.storeCode"
            class="input"
            type="text"
            name=""
            id=""
            tabindex="2"
            ref="storeCode"
            @blur="tab('storeCode')"
            @input="tab('storeCode')"
            v-bind:class="{ borderRed: !validates.storeCode }"
          />
          <div v-show="!validates.storeCode" class="div_error">
            <img src="../../assets/icon/exclamation.png" />
            <span class="title_error">Trường này không được để trống</span>
          </div>
        </div>
        <div class="groupdb w-full">
          <span class="lable"
            >Tên cửa hàng <span class="text-red">*</span>
          </span>
          <input
            v-model="store.storeName"
            class="input"
            type="text"
            name=""
            id=""
            tabindex="3"
            v-bind:class="{ borderRed: !validates.storeName }"
            @blur="tab('storeName')"
            @input="tab('storeName')"
          />
          <div v-show="!validates.storeName" class="div_error">
            <img src="../../assets/icon/exclamation.png" />
            <span class="title_error">Trường này không được để trống</span>
          </div>
        </div>
        <div class="groupdb w-full">
          <span class="lable">Địa chỉ <span class="text-red">*</span> </span>
          <textarea
            v-model="store.address"
            name=""
            id=""
            rows="5"
            tabindex="4"
            v-bind:class="{ borderRed: !validates.address }"
            @blur="tab('address')"
            @input="tab('address')"
          ></textarea>
          <div v-show="!validates.address" class="div_error">
            <img src="../../assets/icon/exclamation.png" />
            <span class="title_error">Trường này không được để trống</span>
          </div>
        </div>
        <div class="groupdb w-full">
          <div class="group-l w-haf">
            <span class="lable">Số điện thoại</span>
            <input
              v-model="store.phoneNumber"
              class="input"
              type="text"
              name=""
              id=""
              tabindex="5"
              @blur="tab('phoneNumber')"
              @input="tab('phoneNumber')"
              v-bind:class="{ borderRed: !validates.phoneNumber }"
            />
            <div v-show="!validates.phoneNumber" class="div_error">
              <img src="../../assets/icon/exclamation.png" />
              <span class="title_error title_error_phoneNumber"
                >Giá trị của ô này không hợp lệ</span
              >
            </div>
          </div>
          <div class="group-r w-haf">
            <span class="lable">Mã số thuế</span>
            <input
              v-model="store.storeTaxCode"
              class="input"
              type="text"
              name=""
              id=""
              tabindex="6"
            />
          </div>
        </div>
        <div class="groupdb w-full">
          <div class="group group-l w-haf">
            <span class="lable">Quốc gia</span>
            <select v-model="store.countryId" name="" id="" tabindex="7" @click="selectCountry">
              <option value="null" selected disabled>Chọn quốc gia</option>
              <option
                v-for="(country, index) in countries"
                :key="index"
                :value="country.countryId"
              >
                {{ country.countryName }}
              </option>
            </select>
          </div>
        </div>
        <div class="groupdb w-full">
          <div class="group-l w-haf">
            <span class="lable">Tỉnh/Thành phố</span>
            <select v-model="store.provinceId" name="" id="" tabindex="8">
              <option value="null" selected disabled>Chọn tỉnh</option>
              <option
                v-for="(province, index) in provinces"
                :key="index"
                :value="country.countryId"
              >
                {{ country.countryName }}
              </option>
            </select>
          </div>
          <div class="group-r w-haf">
            <span class="lable">Quận huyện</span>
            <select v-model="store.districtId" name="" id="" tabindex="9">
              <option value="null" selected disabled>Chọn quận huyện</option>
              <option
                v-for="(district, index) in districts"
                :key="index"
                :value="country.countryId"
              >
                {{ country.countryName }}
              </option>
            </select>
          </div>
        </div>
        <div class="groupdb w-full">
          <div class="group-l w-haf">
            <span class="lable">Phường/Xã</span>
            <select v-model="store.wardId" name="" id="" tabindex="10">
              <option value="null" selected disabled>Chọn phường xã</option>
              <option
                v-for="(ward, index) in wards"
                :key="index"
                :value="country.countryId"
              >
                {{ country.countryName }}
              </option>
            </select>
          </div>
          <div class="group-r w-haf">
            <span class="lable">Đường phố</span>
            <input
              v-model="store.street"
              type="text"
              name=""
              id=""
              tabindex="11"
              ref="storeAddress"
            />
          </div>
        </div>
      </div>
      <div class="footer">
        <div class="help" tabindex="12">
          <span class="help-icon"
            ><img src="../../assets/icon/icon_help_18.png"
          /></span>
          <span>Trợ giúp</span>
        </div>
        <div class="group-button">
          <button class="button-save" tabindex="13" @click="save('save')">
            <span class="img"></span>
            <span class="label">Lưu</span>
          </button>
          <button class="button-add" tabindex="14" @click="save('new')">
            <span class="img"></span>
            <span class="label">Lưu và thêm mới</span>
          </button>
          <button class="button-cancel" tabindex="15" @click="closeDialog">
            <span class="img"></span>
            <span class="label">Hủy bỏ</span>
          </button>
        </div>
      </div>
      <span tabindex="16" @focus="tabIndexFirst()"></span>
    </div>
  </div>
</template>
<script>
export default {
  name: "StoreDialog",
  props: {
    msg: String,
    isShowDialog: Boolean,
  },
  created() {
    this.$store.dispatch("getCountries");
    this.$store.dispatch('getProvinces', "469b3ece-744a-45d5-957d-e8c757976496");
  },
  computed: {
    countries() {
      console.log(this.$store.getters.getCountries);
      return this.$store.getters.getCountries;
    },
    districts() {
      console.log(this.$store.getters.getDistricts);
      return this.$store.getters.getDistricts;
    },
    provinces() {
      console.log(this.$store.getters.getProvinces);
      return this.$store.getters.getProvinces;
    },
    wards() {
      console.log(this.$store.getters.getWards);
      return this.$store.getters.getWards;
    },
  },
  data() {
    return {
      store: {
        storeId: null,
        storeCode: null,
        storeName: null,
        address: null,
        phoneNumber: null,
        storeTaxCode: null,
        countryId: null,
        provinceId: null,
        districtId: null,
        wardId: null,
        street: null,
        status: 1,
        createdDate: null,
        createdBy: null,
        modifiedDate: null,
        modifiedBy: null,
      },
      titleName: "",
      validates: {
        storeCode: true,
        storeName: true,
        address: true,
        phoneNumber: true,
      },
    };
  },
  watch: {
    isShowDialog() {
      console.log(this.$store.getters.getStoreById.length);
      if (this.isShowDialog == true) {
        if (this.msg == "post") {
          this.titleName = "Sửa cửa hàng";
          var StoreById = this.$store.getters.getStoreById[0];
          this.store.storeId = StoreById.storeId;
          this.store.storeCode = StoreById.storeCode;
          this.store.storeName = StoreById.storeName;
          this.store.address = StoreById.address;
          this.store.phoneNumber = StoreById.phoneNumber;
          this.store.storeTaxCode = StoreById.storeTaxCode;
          this.store.countryId = StoreById.countryId;
          this.store.provinceId = StoreById.provinceId;
          this.store.districtId = StoreById.districtId;
          this.store.wardId = StoreById.wardId;
          this.store.street = StoreById.street;
          this.store.createdDate = StoreById.createdDate;
          this.store.createdBy = StoreById.createdBy;
          this.store.modifiedDate = StoreById.modifiedDate;
          this.store.modifiedBy = StoreById.modifiedBy;
          this.$refs.storeCode.focus();
          this.validates.storeCode = true;
          this.validates.storeName = true;
          this.validates.address = true;
          this.validates.phoneNumber = true;
        } else {
          this.titleName = "Thêm mới cửa hàng";
          this.store.storeId = "00000000-0000-0000-0000-000000000000";
          this.store.storeCode = "";
          this.store.storeName = "";
          this.store.address = "";
          this.store.phoneNumber = "";
          this.store.storeTaxCode = "";
          this.store.countryId = null;
          this.store.provinceId = null;
          this.store.districtId = null;
          this.store.wardId = null;
          this.store.street = "";
          this.store.createdDate = null;
          this.store.createdBy = "";
          this.store.modifiedDate = null;
          this.store.modifiedBy = "";
          this.$refs.storeCode.focus();
          this.validates.storeCode = true;
          this.validates.storeName = true;
          this.validates.address = true;
          this.validates.phoneNumber = true;
        }
      }
    },
    // 'store.countryId'(){
    //     console.log(this.store.countryId)
    //     this.$store.dispatch("getProvinces", this.store.countryId);
    // },
//     'store.provinceId'(){
//         this.$store.dispatch("getDistricts", this.store.provinceId);
//     },
//     'store.districtId'(){
//         this.$store.dispatch("getWards", this.store.districtId);
//     }
  },
  methods: {
    selectCountry(){
        console.log(this.store.countryId);
        // this.$store.dispatch("getProvinces", this.store.countryId);
    },
    closeDialog() {
      this.$emit("closeDialog");
    },
    tabIndexFirst() {
      this.$refs.storeCode.focus();
    },
    tabIndexLast() {
      this.$refs.storeAddress.focus();
    },
    tab(value) {
      var phonenumber = /^\d{10}$/;
      if (value == "storeCode") {
        if (this.store.storeCode == "") this.validates.storeCode = false;
        else this.validates.storeCode = true;
      }
      if (value == "storeName") {
        if (this.store.storeName == "") this.validates.storeName = false;
        else this.validates.storeName = true;
      }
      if (value == "address") {
        if (this.store.address == "") this.validates.address = false;
        else this.validates.address = true;
      }
      if (value == "phoneNumber") {
        if (
          !this.store.phoneNumber.match(phonenumber) &&
          this.store.phoneNumber != ""
        )
          this.validates.phoneNumber = false;
        else this.validates.phoneNumber = true;
      }
    },
    save(text) {
      console.log(text);
      if (this.msg == "post") {
        if (this.validate()) {
          console.log(this.msg);
          this.$store.dispatch("updateStore", this.store);
          if (text == "save") this.closeDialog();
          this.$emit("notify");
        }
      } else {
        console.log(this.msg);
        if (this.validate()) {
          console.log(this.msg);
          this.$store.dispatch("insertStore", this.store);
          if (text == "save") this.closeDialog();
          this.$emit("notify");
        }
      }
    },
    validate() {
      var phonenumber = /^\d{10}$/;
      var res = true;
      if (this.store.storeCode == "") {
        this.validates.storeCode = false;
        res = false;
      } else this.validates.storeCode = true;

      if (this.store.storeName == "") {
        this.validates.storeName = false;
        res = false;
      } else this.validates.storeName = true;

      if (this.store.address == "") {
        this.validates.address = false;
        res = false;
      } else this.validates.address = true;

      if (
        this.store.phoneNumber != null &&
        !this.store.phoneNumber.match(phonenumber) &&
        this.store.phoneNumber != ""
      ) {
        this.validates.phoneNumber = false;
        res = false;
      } else this.validates.phoneNumber = true;
      return res;
    },
  },
};
</script>
<style scoped>
.title_error {
  font-size: 13px;
  position: fixed;
  left: calc(50% + 285px);
  color: #ffffff;
  background-color: rgb(233, 61, 61);
  padding: 8px;
  border-radius: 2px;
  display: none;
}
.title_error_phoneNumber {
  left: calc(50% + 5px);
}
.div_error {
  width: 16px;
  height: 16px;
  padding: 4px;
}
.div_error:hover .title_error {
  display: block;
}
.borderRed {
  border: 1px solid #cf4c35;
}
.text-red {
  color: red;
}
.confirmDialog {
  position: absolute;
  top: 0px;
  left: 0px;
  background-color: rgba(0, 0, 0, 0.6);
  width: 100%;
  height: 100vh;
}
.content {
  width: 600px;
  height: auto;
  position: absolute;
  top: calc(50vh - 250px);
  left: calc(50% - 300px);
  background-color: #ffffff;
  border-radius: 4px;
  border: 1px solid #d0d0d0;
}
/* css cho title dialog */
.title {
  width: 100%;
  height: 40px;
  background-color: #f0f0f0;
  padding: 10px 16px 0px 16px;
  box-sizing: border-box;
}
.title span {
  font-size: 16px;
  font-weight: bold;
  vertical-align: middle;
}
.title button {
  vertical-align: middle;
  height: 16px;
  width: 16px;
  background-color: #f0f0f0;
  border: none;
  position: absolute;
  right: 16px;
  background-image: url("../../assets/common-icon.png");
  background-position: -1127px -127px;
  outline: none;
}
/* css for main content */
.main-content {
  width: 100%;
  height: auto;
  box-sizing: border-box;
  padding: 16px 0 8px 0;
  border: 1px solid #d0d0d0;
}
.groupdb {
  display: flex;
  padding: 4px 16px;
}
.groupdb img {
  width: 16px;
  height: 16px;
  margin: 0 4px;
  text-align: center;
}
.group-l {
  display: flex;
  padding-right: 8px;
}
.group-r {
  display: flex;
  padding-left: 8px;
}
.w-full {
  box-sizing: border-box;
  width: 100%;
}
.w-haf {
  width: 50%;
}
input {
  width: calc(100% - 100px);
}
/* .w-haf input{
    width: calc(100% - 100px);
} */
.w-haf select {
  width: calc(100% - 100px);
}
select {
  height: 33px;
  padding: 2px 8px;
  border-radius: 4px;
  border: 1px solid #d0d0d0;
  outline: none;
}
select:focus {
  border: 1px solid #636dde;
}
input {
  height: 33px !important;
  box-sizing: border-box;
  padding: 2px 8px;
}
input {
  border-radius: 4px;
  border: 1px solid #d0d0d0;
  outline: none;
}
textarea {
  box-sizing: border-box;
  resize: none;
  width: calc(100% - 100px);
  border-radius: 4px;
  border: 1px solid #d0d0d0;
  outline: none;
  padding: 4px 8px;
}
textarea:focus {
  border: 1px solid #636dde;
}
input:focus {
  border: 1px solid #636dde;
}
.groupdb .group select {
  width: calc(100% - 108px);
}
.lable {
  width: 100px;
  min-width: 100px;
  font-size: 13px;
  color: #212121;
  padding-top: 4px;
}
/* css footer */
.footer {
  width: 100%;
  height: 68px;
  padding: 16px;
  box-sizing: border-box;
  display: flex;
}
.group-button {
  position: absolute;
  right: 16px;
}
.group-button button {
  background-color: none;
  height: 35px;
  padding: 8px;
  margin-left: 8px;
}
.help span {
  color: #2b3173;
  font-size: 13px;
  font-weight: bold;
}
.help {
  padding: 8px 16px 8px 32px;
  cursor: pointer;
  border-radius: 4px;
  outline: none;
}
.help:hover {
  background-color: #e5e6eb;
}
.help:focus {
  border: 1px solid #2b3173;
}
.help-icon img {
  width: 16px;
  height: 16px;
  position: absolute;
  left: 24px;
  padding-top: 2px;
}
.img {
  height: 16px;
  width: 16px;
  border: none;
  position: absolute;
}
/* button hủy bỏ */
.button-cancel {
  padding-left: 26px !important;
  color: #2b3173;
  font-weight: bold;
  background-color: #ffffff;
  border: none;
  border-radius: 4px;
  border: 1px solid #ffffff;
  outline: none;
}
.button-cancel:hover {
  border: 1px solid #2b3173;
}
.button-cancel:focus {
  border: 1px solid #2b3173;
}
.button-cancel .img {
  right: 60px;
  background-image: url("../../assets/common-icon.png");
  background-position: -1100px -128px;
}
/* button lưu và thêm mới */
.button-add {
  padding-left: 26px !important;
  color: #2b3173;
  font-weight: bold;
  background-color: #ffffff;
  border: none;
  border-radius: 4px;
  border: 1px solid #2b3173;
  outline: none;
}
.button-add:hover {
  color: #6b6f9d;
}
.button-add:focus {
  color: #6b6f9d;
}
.button-add .img {
  right: 214px;
  background-image: url("../../assets/common-icon.png");
  background-position: -25px -128px;
}
/* button lưu */
.button-save {
  padding-left: 26px !important;
  color: #ffffff;
  font-weight: bold;
  background-color: #2b3173;
  border: none;
  border-radius: 4px;
  border: 1px solid #2b3173;
  outline: none;
}
.button-save:hover {
  background-color: #6b6f9d;
}
.button-save:focus {
  background-color: #6b6f9d;
}
.button-save .img {
  right: 282px;
  background-image: url("../../assets/common-icon.png");
  background-position: -326px -127px;
}
</style>