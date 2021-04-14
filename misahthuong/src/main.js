import Vue from 'vue'
import App from './App.vue'
import axios from 'axios'
import VueAxios from 'vue-axios'
import VueRouter from 'vue-router'
import store from './store/index'
Vue.config.productionTip = false
Vue.use(VueRouter)
Vue.use(VueAxios, axios)

new Vue({
    render: h => h(App),
    store: store,
}).$mount('#app')