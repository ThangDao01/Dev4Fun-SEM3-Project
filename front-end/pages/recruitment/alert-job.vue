<template>
  <div>
    <!-- Banner -->
    <div class="careerfy-subheader careerfy-subheader-without-bg">
      <div class="container">
        <div class="row">
          <div class="col-md-12">
            <div class="careerfy-page-title">
              <h1>Companies</h1>
              <p>Thousands of prestigious employers for you, search for a recruiter right now.</p>
            </div>
          </div>
        </div>
      </div>
      <div class="clearfix"></div>
      <div class="careerfy-breadcrumb">
        <ul>
          <li><a href="#">Home</a></li>
          <li><a href="#">Pages</a></li>
          <li>Candidates</li>
        </ul>
      </div>
    </div>
    <!-- Banner -->
    <div class="modal-content" style="z-index: 99;position: fixed;;width: 70%;top: 15%; left: 20%;"
         :style="'display:'+view_model.status">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" @click="viewModelEx()">&times;</button>
        <h4 class="modal-title">{{ view_model.title }}</h4>
      </div>
      <div class="modal-body">
        <img :src="view_model.user_thumbnail" width="100px" alt="">
        <ul>
          <li><i class="fa fa-map-marker"></i> Name : {{ view_model.user_name }}</li>
          <li><i class="careerfy-icon careerfy-calendar"></i> Địa chỉ: {{ view_model.user_location }}</li>
          <li><i class="fa fa-phone"></i> SĐT: {{ view_model.user_phone }}</li>
          <li><i class="fa fa-envelope-o"></i> Email: {{ view_model.user_email }}</li>
          <li>  <i class="fa fa-file-pdf-o" aria-hidden="true"></i><a :href="view_model.cvPath" download class="btn btn-sm btn-sub-color">
            <button> Download Cv</button>
          </a></li>
        </ul>

        <p>{{ view_model.detail }}</p>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal" @click="viewModelEx()">Close</button>
      </div>
    </div>
    <!-- Main Content -->
    <div class="careerfy-main-content">
      <!-- Main Section -->
      <div class="careerfy-main-section careerfy-dashboard-full">
        <div class="container">
          <div class="row">
            <recruitment-navitive/>
            <div class="careerfy-column-9">
              <div class="careerfy-typo-wrap">
                <div class="careerfy-employer-box-section">
                  <div class="careerfy-profile-title">
                    <h2>Applied Jobs</h2>
                    <form class="careerfy-employer-search">
                      <input value="Search orders" onblur="if(this.value == '') { this.value ='Search orders'; }"
                             onfocus="if(this.value =='Search orders') { this.value = ''; }" type="text">
                      <input value="" type="submit">
                      <i class="careerfy-icon careerfy-search"></i>
                    </form>
                  </div>

                  <div class="careerfy-applied-jobs">
                    <ul class="careerfy-row">
                      <li class="careerfy-column-12" v-for="(apply,index) in applied_job" :key="index">
                        <div class="careerfy-applied-jobs-wrap" style="position: relative" v-if="apply.status==1">
                          <a href="#" class="careerfy-applied-jobs-thumb"><img :src="apply.candidateThumbnail"
                                                                               alt=""></a>
                          <div class="careerfy-applied-jobs-text">
                            <div class="careerfy-applied-jobs-left" style="width: 80%;">
                              <span>Candidate:</span> {{ apply.candidateName }}
                              <h2><a href="#">{{ apply.jobName }}</a></h2>
                              <ul>
                                <li><i class="fa fa-map-marker"></i>Hà Nội</li>
                                <li><i class="careerfy-icon careerfy-calendar"></i>{{ apply.interviewDate }}</li>
                              </ul>
                            </div>
                            <a class="careerfy-savedjobs-links"><i class="careerfy-icon careerfy-rubbish"
                                                                   @click="deleteCv(index)"></i></a>
                            <a href="#" class="careerfy-savedjobs-links" @click="viewModel(index)"><i
                              class="careerfy-icon careerfy-view"></i></a>
                            <input type="hidden">
                            <button @click="accept(index)"
                                    style="position: absolute;right: 10px;bottom: 10px;width: 100px;height: 30px;">
                              Passing
                            </button>
                          </div>
                        </div>
                      </li>
                    </ul>
                  </div>
                  <!-- Pagination -->
                  <div class="careerfy-pagination-blog" v-if="applied_job.length > 6">
                    <ul class="page-numbers">
                      <li><a class="prev page-numbers" href="#"><span><i
                        class="careerfy-icon careerfy-arrows4"></i></span></a></li>
                      <li><span class="page-numbers current">01</span></li>
                      <li><a class="page-numbers" href="#">02</a></li>
                      <li><a class="page-numbers" href="#">03</a></li>
                      <li><a class="page-numbers" href="#">04</a></li>
                      <li><a class="next page-numbers" href="#"><span><i
                        class="careerfy-icon careerfy-arrows4"></i></span></a></li>
                    </ul>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <!-- Main Section -->

    </div>
    <!-- Main Content -->
  </div>
</template>

<script>
export default {
  name: "applied-job.vue",
  layout: 'home',
  data() {
    return {
      titlejobs: 'casc',
      view_model: {
        status: 'none',
        detail: '',
        cvPath: '',
        user_name: '',
        user_thumbnail: '',
        user_location: '',
        user_phone: '',
        user_email: '',
      },
      applied_job: [{
        id: 0,
        candidateCv: "",
        candidateEmail: "",
        candidateLocation: "",
        candidateName: "",
        candidatePhone: "",
        candidateThumbnail: "",
        interviewDate: "",
        jobId: 1,
        jobName: "",
        mentorId: 0,
        messenger: "",
        status: 0
      }
      ],
      mailResult: {
        UserName: '',
        UserEmailId: '',
        IdVacancy: '',
        IdApplicant: '',
        Time: '',
      },
      mentors: [
        {
          id: '0',
          name: 'Đào Thắng',
          experience: '2',
          jobs: 'C#'
        }, {
          id: '1',
          name: 'Mạnh Quân',
          experience: '2',
          jobs: 'C#'
        }
      ]
    }
  },
  created() {
    this.getcandidateData()
  },
  // mounted() {
  //   this.getcandidateData()
  // },
  methods: {
    // async getJobsName(id) {
    //   const uri = 'Vacancies/'+this.applied_job[id].jobId
    //   var jobs = await this.$axios.$get(uri)
    //   this.applied_job[id].jobName = jobs.title
    //   console.log(this.applied_job[id].jobName)
    // },
    async getcandidateData() {
      const uri = 'AppliedJobs'
      var arr = await this.$axios.$get(uri)
      for (let i = 0; i < arr.length; i++) {
        const uri2 = 'nameJob/' + arr[i].jobId
        arr[i].jobName = await this.$axios.$get(uri2)
      }
      this.applied_job = arr.reverse()
    },
    candidateData(id) {
    },
    viewModel(id) {
      this.view_model.status = 'block'
      this.view_model.user_name = this.applied_job[id].candidateName
      this.view_model.user_thumbnail = this.applied_job[id].candidateThumbnail
      this.view_model.title = this.applied_job.jobName
      this.view_model.user_location = 'Hà nội'
      this.view_model.user_email = this.applied_job[id].candidateEmail
      this.view_model.user_phone = this.applied_job[id].candidatePhone
      this.view_model.detail = this.applied_job[id].messenger
      this.view_model.cvPath = 'http://res.cloudinary.com/thangdao04/image/upload/f_auto/fl_attachment/'+ this.applied_job[id].candidateCv
    },
    viewModelEx() {
      this.view_model.status = 'none'
    },
    async accept(index) {
      this.applied_job[index].status = 2;
      const uri2 = 'AppliedJobs/' + this.applied_job[index].id
      await this.$axios.$put(uri2, this.applied_job[index])
      const uri = '/Email/SendConfirmEmail'
      const formData = new FormData();
      formData.append('UserName' ,this.applied_job[index].candidateName);
      formData.append('UserEmailId',this.applied_job[index].candidateEmail);
      formData.append('IdVacancy',this.applied_job[index].jobId);
      formData.append('IdApplicant','1');
      formData.append('Time', new Date().toISOString());
      await this.$axios.$post(uri,formData)

    },
    async deleteCv(index) {
      this.applied_job[index].status = 3;
      const uri = 'AppliedJobs/' + this.applied_job[index].id
      await this.$axios.$delete(uri)
      const uri2 = '/Email/SendRefuseEmail'
      const formData = new FormData();
      formData.append('UserName' ,this.applied_job[index].candidateName);
      formData.append('UserEmailId',this.applied_job[index].candidateEmail);
      formData.append('IdVacancy',this.applied_job[index].jobId);
      formData.append('IdApplicant','1');
      console.log(formData)
      await this.$axios.$post(uri2,formData)
    }
  }
}

</script>
<style scoped>

</style>
