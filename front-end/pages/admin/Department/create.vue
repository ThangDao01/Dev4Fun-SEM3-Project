<template>
  <div class="container-fluid" id="container-wrapper">
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
      <h1 class="h3 mb-0 text-gray-800">Form Basics</h1>
      <ol class="breadcrumb">
        <li class="breadcrumb-item"><a href="./">Home</a></li>
        <li class="breadcrumb-item">Forms</li>
        <li class="breadcrumb-item active" aria-current="page">Form Basics</li>
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
                      <label for="exampleInputName">Name</label>
                      <input type="Name" class="form-control" id="exampleInputName" name="Name" aria-describedby="NameHelp"
                        placeholder="Enter Name">
                    </div>
                        <div class="form-group">
                          <label for="exampleFormControlTextarea1">Description</label>
                          <textarea class="form-control" name="Description" id="exampleFormControlTextarea1" rows="3"></textarea>
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
        numberOfJobs: '',
        status: '',
        departmentId: '',
        thumbnail: '',
        salary: '',
        address: '',
        views: 0,
        experience: '',
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
    onSave() {
      const uri = '/Vacancies';
      this.vancancy.dateOfExpiration= this.myDateFormat(new Date());
      this.vancancy.dateOfCreation= this.myDateFormat(new Date());
      this.vancancy.dateOfUpdate= this.myDateFormat(new Date());
      this.$axios.$post(uri, this.vancancy).then((response) => {
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
