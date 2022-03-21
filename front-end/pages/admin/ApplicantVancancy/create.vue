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
              <p>VacancyId</p>
                    <select class="form-control form-control-lg  mb-3">
                      <option>Large select</option>
                      <option>Large select</option>
                      <option>Large select</option>
                 </select>
                 <p>ApplicantId</p>
                    <select class="form-control form-control-lg  mb-3">
                      <option>Large select</option>
                      <option>Large select</option>
                      <option>Large select</option>
                 </select>
                 <p>InterviewerId</p>
                    <select class="form-control form-control-lg  mb-3">
                      <option>Large select</option>
                      <option>Large select</option>
                      <option>Large select</option>
                 </select>
                    <div class="form-group">
                      <div class="custom-control custom-checkbox">
                        <input type="checkbox" class="custom-control-input" id="customControlAutosizing">
                        <label class="custom-control-label" for="customControlAutosizing">Remember me</label>
                      </div>
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
}
</script>
<style scoped>

</style>
