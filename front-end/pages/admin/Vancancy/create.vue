<template>

  <div class="container-fluid" id="container-wrapper">
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
      <h1 class="h3 mb-0 text-gray-800">Vacancies Form</h1>
      <ol class="breadcrumb">
        <li class="breadcrumb-item"><a href="./">Admin</a></li>
        <li class="breadcrumb-item active" aria-current="page">Vacancies/Create</li>
      </ol>
    </div>
    <div class="row">
      <div class="col-lg-2">
        <div class="card mb-2"></div>
      </div>
      <div class="col-lg-8">
        <!-- Form Basic -->
        <div class="card mb-4">
          <div class="card-header py-3 d-flex flex-row align-items-center justify-content-between">
            <h6 class="m-0 font-weight-bold text-primary">Form Basic</h6>
          </div>
          <div class="card-body">
            <form @submit.prevent='onSave()'>
              <div class="form-group">
                <label for="ownedID">Owned ID</label>
                <input type="text" class="form-control" id="ownedID" aria-describedby="NameHelp"
                       placeholder="" v-model="vancancy.ownedID">
              </div>
              <div class="form-group">
                <label for="title">Title</label>
                <input type="text" class="form-control" id="title"  placeholder="Name of job" v-model="vancancy.title">
              </div>
              <div class="form-group">
                <label for="description">Description</label>
                <input type="text" class="form-control" id="description"  placeholder="Description" v-model="vancancy.description">
              </div>
              <p>Status</p>
              <input type="radio" id="stt0" v-model="vancancy.status" name="fav_language" value=0>
              <label for="stt0">Start</label><br>
              <input type="radio" id="stt1" v-model="vancancy.status" name="fav_language" value=1>
              <label for="stt1">End</label><br>
              <input type="radio" id="stt2" v-model="vancancy.status" name="fav_language" value=2>
              <label for="stt2">End</label>
              <p>DepartmentId</p>
              <select class="form-control form-control-lg  mb-3" @change='selectOption($event)' v-model="vancancy.departmentId">
                <option value= "Dev" selected>Dev</option>
                <option value= "Hr">Hr</option>
                <option value= "ABC member">Blabla . . .</option>
              </select>
              <div class="form-group">
                <label for="thumbnail">Thumbnail</label>
                <input type="text" class="form-control" id="thumbnail"  placeholder="URL" v-model="vancancy.thumbnail">
              </div>
              <div class="form-group">
                <label for="salary">Salary</label>
                <input type="number" class="form-control" id="salary"  placeholder="($)" v-model="vancancy.salary">
              </div>
              <div class="form-group">
                <label for="numberOfJobs">Number Of Jobs</label>
                <input type="number" class="form-control" id="numberOfJobs"  placeholder="0" v-model="vancancy.numberOfJobs">
              </div>
              <div class="form-group">
                <label for="address">Address</label>
                <input type="text" class="form-control" id="address"  placeholder="Address" v-model="vancancy.address">
              </div>
              <div class="form-group">
                <label for="experience">Experience</label>
                <input type="number" class="form-control" id="experience"  placeholder="(year)" v-model="vancancy.experience">
              </div>
              <div class="form-group">
                <label for="careerLevel">CareerLevel</label>
                <input type="text" class="form-control" id="careerLevel"  placeholder="CareerLevel" v-model="vancancy.careerLevel">
              </div>
              <div class="form-group">
                <label for="qualification">Qualification</label>
                <input type="text" class="form-control" id="qualification"  placeholder="Qualification" v-model="vancancy.qualification">
              </div>
              <button type="submit" class="btn btn-primary">Submit</button>
            </form>
          </div>
        </div>
      </div>
    </div>
  </div>

</template>

<script>

export default {
  name: "create",
  layout: 'admin',
  data() {
    return {
      vancancy: {
        ownedID: '',
        title: '',
        description: '',
        numberOfJobs: 0,
        status: 0,
        departmentId: '',
        applicantId: '',
        thumbnail: '',
        salary: 0,
        address: '',
        views: 0,
        experience: 0,
        careerLevel: '',
        qualification: '',
        dateOfExpiration: '',
        dateOfCreation: '',
        dateOfUpdate: '',
      }
    }
  },
  methods: {
    myDateFormat(d){
      return d.getFullYear() + "-" + ("0" + d.getDate()).slice(-2) + "-" + ("0"+(d.getMonth()+1)).slice(-2);
    },
    async fetchSomething() {
      const data = await this.$axios.$get('Vacancies')
      console.log(data)
    },
    async onSave() {
      const uri = 'Vacancies';
      this.vancancy.dateOfExpiration= new Date().toISOString();
      this.vancancy.dateOfCreation= new Date().toISOString();
      this.vancancy.dateOfUpdate= new Date().toISOString();
      await this.$axios.$post(uri, this.vancancy).then((response) => {
          this.$router.push('/admin/Vancancy')
      })
    },
    selectOption(event) {
      this.vancancy.category = event.target.value
    }
  }
}
</script>

<style scoped>

</style>
