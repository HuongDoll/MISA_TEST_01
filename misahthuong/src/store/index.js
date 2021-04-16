import Vuex from 'vuex'
import Vue from 'vue'
import axios from 'axios'
Vue.use(Vuex)

const store = new Vuex.Store({
    state: {
        // store
        stores: [],
        storeById: [],
        action: 0,
        msg: "Thành công!",
        loadData: false,
        dataCheckCodeStore : null, // trả về store bị trùng code
        // address
        countries: [],
        districts: [],
        provinces: [],
        wards: [],
    },
    getters: {
        getDataCheckCodeStore(state) {
            return state.dataCheckCodeStore;
        },
        getStores(state) {
            return state.stores;
        },
        getCountries(state) {
            return state.countries;
        },
        getDistricts(state) {
            return state.districts;
        },
        getProvinces(state) {
            return state.provinces;
        },
        getWards(state) {
            return state.wards;
        },
        getStoreById(state) {
            console.log("getter storeId")
            return state.storeById;
        },
        getAction(state) {
            console.log("getter storeId")
            return state.action;
        },
        getMsg(state) {
            console.log("getter storeId")
            return state.msg;
        },
        getLoadData(state) {
            console.log("getter storeId")
            return state.loadData;
        },
    },
    mutations: {
        setDataCheckCodeStore(state, payload) {
            state.dataCheckCodeStore = payload
        },
        setCountries(state, payload) {
            state.countries = payload
        },
        setDistricts(state, payload) {
            state.districts = payload
        },
        setProvinces(state, payload) {
            state.provinces = payload
        },
        setWards(state, payload) {
            state.wards = payload
        },
        setStores(state, payload) {
            state.stores = payload
        },
        removeStore(state, storeId) {
            state.stores = state.stores.filter(p => p.storeId != storeId);
            console.log(state.stores)
        },
        addStore(state, store) {
            state.stores.unshift(store);
            console.log(state.stores);
        },
        getStoreById(state, storeId) {
            state.storeById = state.stores.filter(p => p.storeId == storeId);
        },
        addAction(state) {
            state.action++;
        },
        success(state) {
            state.msg = "Thành công!";
        },
        error(state) {
            state.msg = "Có lỗi xảy ra!";
        },
        loading(state) {
            state.loadData = false;
        },
        loaded(state) {
            state.loadData = true;
        }
    },
    actions: {
        getStoreByCode(context, storeCode) {
            console.log("get data by storecode")
            axios.get('https://localhost:44379/api/Store/byCode/' + storeCode)
                .then(response => {
                    console.log(response.data.data)
                    context.commit("setDataCheckCodeStore", response.data.data)
                })
        },
        getStoreById(context, storeId) {
            context.commit("getStoreById", storeId)
        },
        getCountries(context) {
            console.log("getdata")
            axios.get('https://localhost:44379/api/Country')
                .then(response => {
                    console.log(response)
                    context.commit("setCountries", response.data.data)
                })

        },
        getDistricts(context, entityId) {
            console.log(entityId, context)
            axios.get('https://localhost:44379/api/District/WithParent/' + entityId)
                .then(response => {
                    console.log(response)
                    context.commit("setDistricts", response.data.data)
                })

        },
        getProvinces(context, entityId) {
            console.log("getdata")
            axios.get('https://localhost:44379/api/Province/WithParent/' + entityId)
                .then(response => {
                    console.log(response)
                    context.commit("setProvinces", response.data.data)
                })

        },
        getWards(context, entityId) {
            console.log("getdata")
            axios.get('https://localhost:44379/api/Ward/WithParent/' + entityId)
                .then(response => {
                    console.log(response)
                    context.commit("setWards", response.data.data)
                })

        },

        getStores(context) {
            context.commit("loading");
            console.log("getdata")
            axios.get('https://localhost:44379/api/Store')
                .then(response => {
                    console.log(response)
                    context.commit("loaded");
                    context.commit("setStores", response.data.data)
                })

        },
        getStoreByFilter(context, filter) {
            context.commit("loading");
            var url = `https://localhost:44379/api/Store/filter?storeCode=${filter.storeCode}&storeName=${filter.storeName}&address=${filter.address}&phoneNumber=${filter.phoneNumber}&status=${filter.status}`;
            console.log(url)
            axios.get(url)
                .then(response => {
                    console.log(response)
                    context.commit("loaded");
                    context.commit("setStores", response.data.data)
                })

        },
        deleteStore(context, storeId) {

            axios.delete('https://localhost:44379/api/Store/' + storeId)
                .then(response => {
                    console.log(response)
                    context.commit("addAction");
                    context.commit("success");
                })
                .catch(error => {
                    console.log(error);
                    context.commit("error");
                })
        },
        insertStore(context, store) {
            console.log("insertStore");
            console.log(store);
            axios({
                    method: "post",
                    url: "https://localhost:44379/api/Store",
                    data: store,
                }).then(response => {
                    console.log(JSON.parse(response.config.data));
                    context.commit("addAction");
                    context.commit("success");
                })
                .catch(error => {
                    console.log(error);
                    context.commit("error");
                });
        },
        updateStore(context, store) {
            console.log("store");
            console.log(store);
            axios({
                    method: "put",
                    url: 'https://localhost:44379/api/Store/' + store.storeId,
                    data: store,
                }).then(response => {
                    console.log("response.data");
                    console.log(JSON.parse(response.config.data));
                    context.commit("addAction");
                    context.commit("success");
                })
                .catch(error => {
                    console.log(error);
                    context.commit("error");
                    console.log(store);
                });
        },
    }
})

export default store