<template>
    <div id="app">
      <p v-if="isLogin">我有登入!</p>
      <p v-else>我沒登入</p>
      <p v-show="isAdmin">我是管理員</p>
      
      <button @click="isAdmin = !isAdmin">點我切換管理員身分</button>
    </div>
  </template>
  
  <script>
  export default {
    data() {
      return {
        isAdmin: false,
        isLogin: true
      };
     }
   }
  </script>