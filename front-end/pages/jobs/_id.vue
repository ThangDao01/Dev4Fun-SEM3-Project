<template>
  <div>
    <!-- JobDetail SubHeader Main List -->
    <div class="careerfy-jobdetail-four-list">

      <span class="careerfy-jobdetail-four-transparent"></span>
      <div class="container">
        <div class="row">
          <div class="careerfy-column-12">
            <figure><a href="#"><img :src="job.thumbnail" alt="null thumbnail"></a></figure>
            <div class="careerfy-jobdetail-four-list-text">
              <span class="careerfy-jobdetail-four-list-status">Part-Time</span>
              <span class="careerfy-jobdetail-four-list-status color">Offered Salary: ${{job.salary}}</span>
              <h1>{{job.title}}</h1>
              <ul class="careerfy-jobdetail-four-options">
                <li><i class="fa fa-map-marker"></i>{{job.address}}  <a href="#" class="careerfy-jobdetail-view">View om Map</a></li>
                <li><i class="careerfy-icon careerfy-building"></i> Small Business <small>Posted now</small></li>
                <li><a href="#"><i class="careerfy-icon careerfy-view"></i> Views {{job.views}}</a></li>
                <li><i class="careerfy-icon careerfy-calendar"></i> Posted Date: {{job.dateOfCreation}}</li>
                <li><i class="careerfy-icon careerfy-calendar"></i> Last Date: {{job.dateOfCreation}}</li>
              </ul>
              <a href="#" class="careerfy-jobdetail-four-btn" @click="showApplyModel()">Apply Now<i class="fa fa-arrow-right"></i></a>
              <ul class="careerfy-jobdetail-four-media">
                <li><span>Share this Job:</span></li>
                <li><a href="#" class="fa fa-twitter"></a></li>
                <li><a href="#" class="fa fa-facebook"></a></li>
                <li><a href="#" class="fa fa-linkedin"></a></li>
                <li><a href="#" class="fa fa-google-plus"></a></li>
                <li><a href="#" class="fa fa-dribbble"></a></li>
              </ul>
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- JobDetail SubHeader Main List -->

    <!-- Main Content -->
    <!-- Success Alert -->

    <div class="careerfy-main-content">
      <div class="alert alert-success alert-dismissible show" :class="successAlert" style="z-index: 999;position: fixed;top: 100px;left: 25%;width: 50%;">
        <strong>Success!</strong> Your profile has been sent successfully. Please wait for the manager to approve your application
        <i class="fa fa-times" style="float: right" @click="successAlertOff()"></i>
      </div>
      <!-- Main Section -->
      <div class="careerfy-main-section">
        <div class="container">
          <div class="row">

            <!-- Job Detail Content -->
            <div class="careerfy-column-8">
              <div class="careerfy-typo-wrap">
                <div class="careerfy-jobdetail-content">

                  <div class="careerfy-content-title"><h2>Description</h2></div>
                  <div class="careerfy-description">
                    <p>{{job.description}}</p>
                  </div>

                  <div class="careerfy-jobdetail-tags-style2">
                    <a href="#">AutoCAD</a>
                    <a href="#">Civils</a>
                    <a href="#">food</a>
                    <a href="#">17th edition</a>
                    <a href="#">electrical</a>
                    <a href="#">engineer</a>
                    <a href="#">engineer</a>
                    <a href="#">engineering</a>
                    <a href="#">dairy</a>
                    <a href="#">projects</a>
                    <a href="#">Maintenance engineer</a>
                  </div>
                  <div class="careerfy-jobdetail-four-links">
                    <a href="#"><i class="careerfy-icon careerfy-heart"></i> Shortlist</a>
                    <a href="#" class="color1">Apply Now</a>
                    <a href="#" class="color2">Apply with LinkedIn</a>
                    <a href="#" class="color3">Apply with Facebook</a>
                  </div>
                </div>
              </div>
            </div>
            <!-- Job Detail Content -->
            <div class="careerfy-modal fade careerfy-typo-wrap" :class="applyModel" id="JobSearchModalLogin">
              <div class="modal-inner-area"  >&nbsp;</div>
              <div class="modal-content-area"  @click="cvPathChange()">
                <div class="modal-box-area">

                  <div class="careerfy-modal-title-box">
                    <h2>Confirm your information</h2>
                    <span @click="showApplyModelOff()" style="float: right;"><i class="fa fa-times"></i></span>
                  </div>
                  <form @submit.prevent="sendJobs()">
                    <div class="careerfy-user-form careerfy-user-form-coltwo-full">
                      <img id="avatarUser" :src="avatarDefault" style="width: 150px;margin: 50px 35%;border-radius: 100px" alt="Error Image Url">
                      <ul>
                        <li style="width: 100%;">
                          <label style="font-size: 30px ;">{{job.departmentId}} : {{job.title}}  </label>
                        </li>
                        <li>
                          <label>Full Name: </label>
                          <input placeholder="Enter Your Name"
                                 type="text"
                                 v-model="applyResult.candidateName">
                          <i class="careerfy-icon careerfy-user"></i>
                        </li>
                        <li>
                          <label>Email Address:</label>
                          <input placeholder="Enter Your Email Address:"
                                 type="text"
                                 v-model="applyResult.candidateEmail">
                          <i class="careerfy-icon careerfy-mail"></i>
                        </li>
                        <li>
                          <label>Phone Number:</label>
                          <input placeholder="Enter Your Phone Number:"
                                 type="text"
                                 v-model="applyResult.candidatePhone">
                          <i class="careerfy-icon careerfy-technology"></i>
                        </li>
                        <li>
                          <label>Avatar:
                          </label>
                          <input id="avatarurl" type="hidden" v-model="applyResult.candidateThumbnail">
                          <button type="button" id="in-btn-avatar" style="width: 100px;height: 40px; border-radius: 2px;background-color: #13b5ea;color: whitesmoke">Upload avatar</button>
                        </li>
                        <li>
                          <label>Cv File:{{applyResult.candidateCv}}
                            <a id="cvDowload" style="display: none" href="" download class="btn btn-sm btn-sub-color" >
                            Download<i class="fa fa-file-pdf-o" aria-hidden="true"></i>
                          </a></label>
                          <input id="cvPath" type="hidden" v-model="applyResult.candidateCv">
                          <button type="button" id="in-btn-pdf" style="width: 100px;height: 40px; border-radius: 2px;background-color: #13b5ea;color: whitesmoke">Upload Cv file</button>
                        </li>
                        <li style="width: 100%;">
                          <label>Messenger to Manager:</label>
                          <textarea style="width: 100%;height: 100px;background-color: rgb(153 153 153 / 43%)" v-model="applyResult.messenger">
                          </textarea>
                        </li>
                        <li class="careerfy-user-form-coltwo-full" @click="showApplyModelOff()">
                          <input type="submit" value="Send">
                        </li>
                      </ul>
                    </div>
                    <div class="clearfix"></div>
                  </form>

                </div>
              </div>
            </div>
            <!-- Job Detail SideBar -->
            <aside class="careerfy-column-4">
              <div class="careerfy-typo-wrap">

                <!-- Widget Detail Services -->
                <div class="widget careerfy-candidatedetail-services">
                  <ul>
                    <li>
                      <i class="careerfy-color careerfy-icon careerfy-salary"></i>
                      <div class="careerfy-services-text">
                        <span>Offerd Salary</span>
                        <small>${{job.salary}}+</small>
                      </div>
                    </li>
                    <li>
                      <i class="careerfy-color careerfy-icon careerfy-group"></i>
                      <div class="careerfy-services-text">
                        <span>Career Level</span>
                        <small>{{job.careerLevel}}</small>
                      </div>
                    </li>
                    <li>
                      <i class="careerfy-color careerfy-icon careerfy-briefcase"></i>
                      <div class="careerfy-services-text">
                        <span>Experience</span>
                        <small>{{job.experience}}</small>
                      </div>
                    </li>
                    <li>
                      <i class="careerfy-color careerfy-icon careerfy-time"></i>
                      <div class="careerfy-services-text">
                        <span>Industry</span>
                        <small>Dev</small>
                      </div>
                    </li>
                    <li>
                      <i class="careerfy-color careerfy-icon careerfy-mortarboard"></i>
                      <div class="careerfy-services-text">
                        <span>Qualification</span>
                        <small>{{job.qualification}}</small>
                      </div>
                    </li>
                  </ul>
                </div>
                <!-- Widget Detail Services -->

                <div class="widget widget_contact_form">
                  <form>
                    <div class="careerfy-widget-title"><h2>Contact Form</h2></div>
                    <ul>
                      <li>
                        <input value="Enter Your Name" onblur="if(this.value == '') { this.value ='Enter Your Name'; }" onfocus="if(this.value =='Enter Your Name') { this.value = ''; }" type="text">
                        <i class="careerfy-icon careerfy-user"></i>
                      </li>
                      <li>
                        <input value="Enter Your Email Address" onblur="if(this.value == '') { this.value ='Enter Your Email Address'; }" onfocus="if(this.value =='Enter Your Email Address') { this.value = ''; }" type="text">
                        <i class="careerfy-icon careerfy-mail"></i>
                      </li>
                      <li>
                        <input value="Enter Your Phone Number" onblur="if(this.value == '') { this.value ='Enter Your Phone Number'; }" onfocus="if(this.value =='Enter Your Phone Number') { this.value = ''; }" type="text">
                        <i class="careerfy-icon careerfy-technology"></i>
                      </li>
                      <li>
                        <textarea>After using Big Interview, I now feel much more confident about handling real interviews. I really liked the recording & playback functionality, which allowed me to hear my voice and analyze the strength and confidence of my answer.</textarea>
                      </li>
                      <li> </li>
                      <li>
                        <input type="submit" value="Send now">
                        <p>You accepts our <a href="#">Terms and Conditions</a></p>
                      </li>
                    </ul>
                  </form>
                </div>

              </div>
            </aside>
            <!-- Job Detail SideBar -->

            <div class="careerfy-column-12">
              <div class="careerfy-section-title"><h2>Related Jobs by Viant Timeline</h2></div>
              <!-- Job Listings -->
              <div class="careerfy-job careerfy-joblisting-plain">
                <ul class="row">
                  <li class="col-md-12">
                    <div class="careerfy-joblisting-plain-wrap">
                      <figure><a href="#"><img src="/extra-images/joblisting-plain-1.png" alt=""></a></figure>
                      <div class="careerfy-joblisting-plain-text">
                        <div class="careerfy-joblisting-plain-left">
                          <h2><a href="#">Need Senior Rolling Stock Technician</a> <span>Featured</span> </h2>
                          <ul>
                            <li><span>@ Rose Clinic</span></li>
                            <li><i class="careerfy-icon careerfy-filter-tool-black-shape"></i> Healthcare</li>
                            <li><i class="careerfy-icon careerfy-money"></i> $70000</li>
                          </ul>
                        </div>
                        <div class="careerfy-joblisting-plain-right">
                          <small><i class="careerfy-icon careerfy-maps-and-flags"></i>  Netherlands, Rotterdam</small>
                          <a href="#" class="careerfy-job-like"><i class="fa fa-heart"></i></a>
                          <span class="careerfy-joblisting-plain-status">Freelance</span>
                        </div>
                        <div class="clearfix"></div>
                      </div>
                    </div>
                  </li>
                  <li class="col-md-12">
                    <div class="careerfy-joblisting-plain-wrap">
                      <figure><a href="#"><img src="/extra-images/joblisting-plain-2.png" alt=""></a></figure>
                      <div class="careerfy-joblisting-plain-text">
                        <div class="careerfy-joblisting-plain-left">
                          <h2><a href="#">Senior Health And Nutrition Advisor</a> </h2>
                          <ul>
                            <li><span>@ Telimed</span></li>
                            <li><i class="careerfy-icon careerfy-filter-tool-black-shape"></i> Healthcare</li>
                            <li><i class="careerfy-icon careerfy-money"></i> $30 - $50 / hour</li>
                          </ul>
                        </div>
                        <div class="careerfy-joblisting-plain-right">
                          <small><i class="careerfy-icon careerfy-maps-and-flags"></i>  Netherlands, Rotterdam</small>
                          <a href="#" class="careerfy-job-like"><i class="fa fa-heart"></i></a>
                          <span class="careerfy-joblisting-plain-status careerfy-blue-status">Full Time</span>
                        </div>
                        <div class="clearfix"></div>
                      </div>
                    </div>
                  </li>
                  <li class="col-md-12">
                    <div class="careerfy-joblisting-plain-wrap">
                      <figure><a href="#"><img src="/extra-images/joblisting-plain-3.png" alt=""></a></figure>
                      <div class="careerfy-joblisting-plain-text">
                        <div class="careerfy-joblisting-plain-left">
                          <h2><a href="#">Restaurant Dishwasher</a></h2>
                          <ul>
                            <li><span>@ King LLC</span></li>
                            <li><i class="careerfy-icon careerfy-filter-tool-black-shape"></i> Restaurant</li>
                            <li><i class="careerfy-icon careerfy-money"></i> $55000 - $70000</li>
                          </ul>
                        </div>
                        <div class="careerfy-joblisting-plain-right">
                          <small><i class="careerfy-icon careerfy-maps-and-flags"></i>  Netherlands, Rotterdam</small>
                          <a href="#" class="careerfy-job-like"><i class="fa fa-heart"></i></a>
                          <span class="careerfy-joblisting-plain-status careerfy-red-status">Temporary</span>
                        </div>
                        <div class="clearfix"></div>
                      </div>
                    </div>
                  </li>
                </ul>
              </div>
              <!-- Job Listings -->
              <div class="bottom-spacer"></div>
            </div>

          </div>
        </div>
      </div>
      <!-- Main Section -->
      <script type="text/javascript">
        var PdfUrl = cloudinary.createUploadWidget({
            cloudName: 'thangdao04',
            uploadPreset: 'ekcloudinary'
          }, (error, result) => {
            if (!error && result && result.event === "success") {
              // console.log('Done! Here is the image info: ', result.info);
              document.getElementById("cvDowload").href = 'http://res.cloudinary.com/thangdao04/image/upload' + '/f_auto/fl_attachment/' + result.info.path
              document.getElementById("cvDowload").style.display='block'
              document.getElementById("cvPath").value = result.info.path
            }
          }
        )
        document.getElementById("in-btn-pdf").addEventListener("click", function () {
          PdfUrl.open();
        }, false);
        var AvatarUrl = cloudinary.createUploadWidget({
            cloudName: 'thangdao04',
            uploadPreset: 'ekcloudinary'
          }, (error, result) => {
            if (!error && result && result.event === "success") {
              // console.log('Done! Here is the image info: ', result.info);
              document.getElementById("avatarUser").src = result.info.secure_url
              document.getElementById("avatarurl").value = result.info.secure_url
            }
          }
        )
        document.getElementById("in-btn-avatar").addEventListener("click", function () {
          AvatarUrl.open();
        }, false);
      </script>

    </div>
    <!-- Main Content -->
  </div>
</template>

<script>
export default {
  name: "jobs-detail",
  layout: 'home',
  data() {
    return {
      applyModel:'fade',
      successAlert:'fade',
      avatarDefault:"https://www.floresdevida.org/wp-content/uploads/2018/06/default-user-thumbnail-1.png",
      applyResult:{
        jobId: this.$route.params.id,
        candidateEmail: "",
        candidateName: "",
        candidateThumbnail: "",
        candidatePhone: "",
        candidateLocation: "",
        candidateCv: "",
        messenger: "",
        mentorId: 0,
        status: 0,
        interviewDate: '',
      },
      job: {
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
  head() {
    return {
      link: [
        {rel: 'stylesheet', href: '/css/bootstrap.min.css'},
        {rel: 'stylesheet', href: '/css/job-detail-two.css'},
        {rel: 'stylesheet', href: '/css/job-detail-three.css'},
        {rel: 'stylesheet', href: '/css/job-detail-four.css'},
      ],
    }
  },
  mounted() {
    this.getVacancies()
  },
  methods:{
    async getVacancies() {
      const uri = 'Vacancies/' + this.$route.params.id
      this.job = await this.$axios.$get(uri)
      return this.job
    },
    changeThumbnail(){
      if(this.applyResult.candidateThumbnail){
        this.avatarDefault = this.applyResult.candidateThumbnail
      }
    },
    async sendJobs() {
      const uri = 'AppliedJobs'
      this.applyResult.interviewDate =new Date().toISOString()
      this.applyResult.candidateCv= document.getElementById('cvPath').value
      this.applyResult.candidateThumbnail= document.getElementById('avatarurl').value
      await this.$axios.$post(uri, this.applyResult).then((response) => {
        this.successAlert='fade-in'
        this.applyModel = 'fade'
      })
    },
    showApplyModel(){
      this.applyModel = 'fade-in'
    },
    showApplyModelOff(){
      this.applyModel = 'fade'
    },
    cvPathChange(){
      this.applyResult.candidateCv= document.getElementById('cvPath').value
      this.applyResult.candidateThumbnail= document.getElementById('avatarurl').value
    },
    successAlertOff(){
      this.successAlert='fade'
    }
  }
}
</script>

<style scoped>

</style>
