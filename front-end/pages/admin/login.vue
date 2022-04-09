<template>
  <div class="bg-gradient-login"
       style="height: 100%; background-image: url('https://blog.depositphotos.com/wp-content/uploads/2017/07/Soothing-nature-backgrounds-2.jpg');
              background-size: cover;
              background-position:100%">
    <!-- Login Content -->
    <div class="container-login">
      <div class="row justify-content-center">
        <div class="col-xl-6 col-lg-12 col-md-9">
          <div class="card shadow-sm my-5">
            <div class="card-body p-0">
              <div class="row">
                <div class="col-lg-9" style="margin: auto">
                  <div class="login-form">
                    <div class="text-center">
                      <img src="/images/logo.png" style="width: 250px" alt="">
                      <h1 class="h4 text-gray-900 mb-4">Login</h1>
                    </div>
                    <form class="user" @submit.prevent="login()">
                      <div class="form-group">
                        <input type="email" class="form-control" id="exampleInputEmail" aria-describedby="emailHelp"
                               placeholder="Enter Email Address" v-model="currentAccount.email">
                      </div>
                      <div class="form-group">
                        <input type="password" class="form-control" id="exampleInputPassword" placeholder="Password" v-model="currentAccount.password">
                      </div>
                      <div class="form-group">
                        <div class="custom-control custom-checkbox small" style="line-height: 1.5rem;">
                          <input type="checkbox" class="custom-control-input" id="customCheck">
                          <label class="custom-control-label" for="customCheck">Remember
                            Me</label>
                        </div>
                      </div>
                      <div class="form-group">
                        <button class="btn btn-primary btn-block">Login</button>
                      </div>
                      <hr>
                      <a href="index.html" class="btn btn-google btn-block">
                        <i class="fab fa-google fa-fw"></i> Login with Google
                      </a>
                      <a href="index.html" class="btn btn-facebook btn-block">
                        <i class="fab fa-facebook-f fa-fw"></i> Login with Facebook
                      </a>
                    </form>
                    <hr>
                    <div class="text-center">
                      <a class="font-weight-bold small" href="register.html">Create an Account!</a>
                    </div>
                    <div class="text-center">
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- Login Content -->
  </div>
</template>

<script>
export default {
  name: "login",
  layout: null,
  data() {
    return {
      currentAccount: {
        name: 'string',
        email: '',
        phoneNumber: 'string',
        password: '',
        thumbnail: 'string',
        role: 5,
        description: 'string',
        departmentId: 'string',
        dateOfCreation: 'string',
        dateOfUpdate: 'string',
      },
    }
  },
  head() {
    return {
      title:'Auth Login',
      link: [
        {rel: 'stylesheet', href: '/vendor/fontawesome-free/css/all.min.css'},
        {rel: 'stylesheet', href: '/vendor/bootstrap/css/bootstrap.min.css'},
      ],
      script: [
        {hid: 'stripe', src: '/vendor/jquery/jquery.min.js', defer: true},
        {hid: 'stripe', src: '/vendor/bootstrap/js/bootstrap.bundle.min.js', defer: true},
        {hid: 'stripe', src: '/vendor/jquery-easing/jquery.easing.min.js', defer: true},
        {hid: 'stripe', src: '/js/ruang-admin.min.js', defer: true},
      ]
    }
  },
  methods: {
    async login() {
      const uri = 'CurrentAccounts';
      this.currentAccount.dateOfUpdate= new Date().toISOString();
      this.currentAccount.dateOfCreation= new Date().toISOString();
      await this.$axios.$post(uri, this.currentAccount).then((response) => {
        this.$router.push('/admin')
      })
    },
  }
}
</script>

<style scoped>

</style>
