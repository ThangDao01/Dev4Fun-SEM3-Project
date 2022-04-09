<template>
  <div class="container-fluid" id="container-wrapper">
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
      <h1 class="h3 mb-0 text-gray-800">Vacancies Tables</h1>
      <ol class="breadcrumb">
        <li class="breadcrumb-item"><NuxtLink to="/admin">Admin</NuxtLink></li>
        <li class="breadcrumb-item active" aria-current="page">Vacancies</li>
      </ol>
    </div>
    <!-- Row -->
    <div class="row">
      <!-- Vacancies Tables -->
      <div class="col-lg-12">
        <div class="card mb-4">
          <div class="card-header py-3 d-flex flex-row align-items-center justify-content-between">
            <NuxtLink to="/admin/Vancancy/create">
              <button class="btn btn-primary"> Create</button>
            </NuxtLink>
          </div>
          <div class="table-responsive p-3">
            <table class="table align-items-center table-flush" id="dataTable">
              <thead class="thead-light">
              <tr>
                <th>Id</th>
                <th>Avatar</th>
                <th>Name</th>
                <th>Department</th>
                <th>Phone</th>
                <th>Role</th>
              </tr>
              </thead>
              <tfoot>
              <tr>
                <th>Id</th>
                <th>Avatar</th>
                <th>Name</th>
                <th>Department</th>
                <th>Phone</th>
                <th>Role</th>
              </tr>
              </tfoot>
              <tbody>
              <tr v-for="(acc,index) in ListAccount" :key="index">
                <td>{{ acc.id }}</td>
                <td><img :src="acc.thumbnail" style="width: 100px;" alt=""></td>
                <td>{{ acc.name }}</td>
                <td>{{ acc.departmentId }}</td>
                <td>{{ acc.phoneNumber }}</td>
                <td>
                  <span v-if="acc.role==0" style="color: red">Admin</span>
                  <span v-if="acc.role==1" style="color: orange">Manager</span>
                  <span v-if="acc.role==2" style="color: blue">Mentor</span>
                  <span v-if="acc.role==3" style="color: violet;">Hr</span>
                  <span v-if="acc.role==4" style="color: yellow;">Applicants</span></td>
              </tr>
              </tbody>
            </table>
          </div>
        </div>
      </div>

      <!-- Modal Logout -->
      <div class="modal fade" id="logoutModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabelLogout"
           aria-hidden="true">
        <div class="modal-dialog" role="document">
          <div class="modal-content">
            <div class="modal-header">
              <h5 class="modal-title" id="exampleModalLabelLogout">Ohh No!</h5>
              <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                <span aria-hidden="true">&times;</span>
              </button>
            </div>
            <div class="modal-body">
              <p>Are you sure you want to logout?</p>
            </div>
            <div class="modal-footer">
              <button type="button" class="btn btn-outline-primary" data-dismiss="modal">Cancel</button>
              <a href="login.html" class="btn btn-primary">Logout</a>
            </div>
          </div>
        </div>
      </div>

    </div>
    <!---Container Fluid-->
  </div>
</template>

<script>

// export default function ({ $axios }) {
//   $axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
// }
import axios from "axios";

export default {
  name: "index",
  layout: 'admin',
  data: () => ({
    ListAccount: null
  }),
  mounted() {
    this.fetchSomething()
  },
  methods: {
    async fetchSomething() {
      this.ListAccount = await this.$axios.$get('Accounts')
    },
  }
}
</script>

<style scoped>

</style>
