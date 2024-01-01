<template>
  <div id="app">
  
    <label for="name">輸入你想輸入的</label>
    <input type="text" v-model="message" name = "msg">
    <h1 v-if="iswelcome"> {{ message }}</h1>
    <img src="" alt="">
  </div>
</template>

<script>
export default {
  data() {
    return {
      message: 'Welcome to Vue!',
      iswelcome : true,
      imgsrc:'https://upload.cc/i1/2020/08/23/rGPIy0.jpg'
    };
  },
  methods: {
    greet() {
      alert("Hi");
    }
  }
};
</script>
