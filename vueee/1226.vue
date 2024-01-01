<template>
    <div id="app">
      <h1>{{ message }}</h1>
      <button v-on:click="greet">Click Me</button>
    </div>
  </template>
  
  <script>
  export default {
    data() {
      return {
        message: 'Welcome to Vue!'
      };
    },
    methods: {
      greet() {
        alert("Hi");
      }
    }
  };
  </script>
  