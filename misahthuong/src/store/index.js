import Vuex from 'vuex'
import Vue from 'vue'
import axios from 'axios'
Vue.use(Vuex)

const store = new Vuex.Store({
    state: {
        stores: [],
        storeById: [],
    },
    getters: {
        getStores(state) {
            return state.stores
        },
        getStoreById(state){
            console.log("getter storeId")
            return state.storeById;
        }

    },
    mutations: {
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
        getStoreById(state, storeId){
            state.storeById = state.stores.filter(p => p.storeId == storeId);
        }
    },
    actions: {
        getStoreById(context, storeId){
            context.commit("getStoreById", storeId)
        },
        getStores(context) {
            console.log("actions")
            axios.get('https://localhost:44379/api/Store')
                .then(response => {
                    console.log(response)
                    context.commit("setStores", response.data.data)
                })

        },
        deleteStore(context, storeId) {

            axios.delete('https://localhost:44379/api/store/' + storeId)
                .then(response => {
                    console.log(response)
                    alert("delete success!")
                    context.commit("removeStore", storeId)
                })
                .catch(error => {
                    console.log(error);
                    alert("delete error!")
                })
        },
        insertStore(context, store){
            axios({
                method: "post",
                url: "https://localhost:44379/api/store",
                data: store,
            }).then(response => {
                alert(" success!")
                console.log(JSON.parse(response.config.data));
                context.commit("addStore", JSON.parse(response.config.data))
            })
            .catch(error => {
                console.log(error);
                alert(" errrrrrrrrrr!")
            });
        },
        updateStore(context, store){
            console.log("store");
            console.log(store);
            axios({
                method: "put",
                url: 'https://localhost:44379/api/store/' + store.storeId,
                data: store,
            }).then(response => {
                alert(" success!")
                console.log("response.data");
                console.log(JSON.parse(response.config.data));
                context.commit("removeStore", store.storeId);
                context.commit("addStore", JSON.parse(response.config.data));
            })
            .catch(error => {
                console.log(error);
                alert(" errrrrrrrrrr!");
                console.log(store);
            });
        },
    }
})

export default store