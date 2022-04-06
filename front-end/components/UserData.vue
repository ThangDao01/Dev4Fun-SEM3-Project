<template>
  <aside class="col-md-4">
    <div class="careerfy-right">
      <ul class="careerfy-user-section">
        <li><a class="careerfy-color careerfy-open-signin-tab" href="#">Register</a></li>
        <li><a class="careerfy-color careerfy-open-signup-tab" href="#">Sign in</a></li>
        <li><img src="https://res.cloudinary.com/thangdao04/image/upload/v1648307730/avatar_auto_x2_hbajbf.jpg" style="width: 50px;border-radius: 50px" alt="">&nbsp;&nbsp;{{name}}</li>
      </ul>
    </div>
  </aside>
</template>

<script>
export default {
  name: "UserData",
  data() {
    return {
      name: 'vainoi',
    }
  },
  async asyncData({ app }) {
    console.log("17236781238912983612983612983698126")
    app.name = 'vcl'
    console.log("checkinfashcjkasbcjbajcbjasbcjasbcvaschjva")
  },

}
</script>

<style scoped>

</style>
