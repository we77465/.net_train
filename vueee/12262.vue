<template>
    <div id="app">
      <input type="text" v-on:keyup.enter="submit" placeholder="Type something and press Enter">
      <p>Last submitted: {{ lastSubmitted }}</p>
    </div>
  </template>
  
  <script>
  export default {
    data() {
      return {
        lastSubmitted: ''
      };
    },
    methods: {
      submit(event) {
        // 将输入框的值设置为 lastSubmitted
        this.lastSubmitted = event.target.value;
  
        // 清空输入框
        event.target.value = '';
      }
    }
  };
  </script>
  