<template>
  <div class="container-fluid" id="container-wrapper">
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
      <h1 class="h3 mb-0 text-gray-800">DataTables</h1>
      <ol class="breadcrumb">
        <li class="breadcrumb-item"><a href="./">Home</a></li>
        <li class="breadcrumb-item">Tables</li>
        <li class="breadcrumb-item active" aria-current="page">DataTables</li>
      </ol>
    </div>

    <!-- Row -->
    <div class="row">
      <!-- Datatables -->
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
                <th>OwnerId</th>
                <th>Department ID</th>
                <th>Title</th>
                <th>Description</th>
                <th>NumberOfJod</th>
                <th>Action</th>
              </tr>
              </thead>
              <tfoot>
              <tr>
                <th>OwnerId</th>
                <th>Department ID</th>
                <th>Title</th>
                <th>Description</th>
                <th>NumberOfJod</th>
                <th>Action</th>
              </tr>
              </tfoot>
              <tbody>
              <tr v-for="(job,index) in ListJobs" :key="index">
                <td><a href="">{{ job.departmentId }}</a></td>
                <td>{{ job.ownedID }}</td>
                <td>{{ job.title }}</td>
                <td>{{ job.description }}</td>
                <td>{{ job.numberOfJobs }}</td>
                <td>{{ job.title }}</td>
                <td>{{ job.title }}</td>
                <td><span class="badge badge-success">{{ job.title }}</span></td>
                <td><a href="/Admin/Vancancy/detail.html" class="btn btn-sm btn-primary">{{ job.id}}</a></td>
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
  async asyncData({app}) {
    const ListJobs = await app.$axios.$get('Vacancies')
    return {ListJobs}
  },
  data: () => ({
    ListJobs: null
  }),
  methods: {
    async fetchSomething() {
      this.ListJobs = await this.$axios.$get('Vacancies')
      console.log(this.ListJobs)
    },
  }
}
</script>

<style scoped>

</style>
