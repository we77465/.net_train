<template>
    <div id="app">
      <img v-bind:src="imgSrc">
    </div>
  </template>
  
  <script>
  export default {
    data() {
      return {
        imgSrc: 'https://upload.cc/i1/2020/08/23/rGPIy0.jpg'
      };
    }
  };
  </script>