<template>
  <div class="careerfy-main-content">

    <!-- Main Section -->
    <div class="careerfy-main-section careerfy-dashboard-fulltwo">
      <div class="container">
        <div class="row">
          <recruitment-navitive></recruitment-navitive>
          <div class="careerfy-column-9">
            <div class="careerfy-typo-wrap">
              <form class="careerfy-employer-dasboard">
                <div class="careerfy-employer-box-section">
                  <div class="careerfy-profile-title"><h2>Basic Information</h2></div>
                  <ul class="careerfy-row careerfy-employer-profile-form">
                    <li class="careerfy-column-6">
                      <label>Your Name *</label>
                      <input value="Jody Wisternoff" v-model="currentAccount.name" onblur="if(this.value == '') { this.value ='Jody Wisternoff'; }" onfocus="if(this.value =='Jody Wisternoff') { this.value = ''; }" type="text">
                    </li>
                    <li class="careerfy-column-6">
                      <label>Email *</label>
                      <input value="contact@jodywisternoff" v-model="currentAccount.email" onblur="if(this.value == '') { this.value ='contact@jodywisternoff'; }" onfocus="if(this.value =='contact@jodywisternoff') { this.value = ''; }" type="text">
                    </li>
                    <li class="careerfy-column-6">
                      <label>Date of Birth:</label>
                      <div class="careerfy-three-column-row">
                        <div class="careerfy-profile-select careerfy-three-column">
                          <select>
                            <option>dd</option>
                            <option>dd</option>
                          </select>
                        </div>
                        <div class="careerfy-profile-select careerfy-three-column">
                          <select>
                            <option>mm</option>
                            <option>mm</option>
                          </select>
                        </div>
                        <div class="careerfy-profile-select careerfy-three-column">
                          <select>
                            <option>yyyy</option>
                            <option>yyyy</option>
                          </select>
                        </div>
                      </div>
                    </li>
                    <li class="careerfy-column-6">
                      <label>Phone *</label>
                      <input value="0979380947" v-model="currentAccount.phoneNumber" onblur="if(this.value == '') { this.value ='0979380947'; }" onfocus="if(this.value =='0979380947') { this.value = ''; }" type="text">
                    </li>
                    <li class="careerfy-column-6">
                      <label>Department</label>
                      <div class="careerfy-profile-select">
                        <select>
                          <option > {{currentAccount.departmentId}}</option>
                        </select>
                      </div>
                    </li>
                    <li class="careerfy-column-6">
                      <label>Role :
                        <span v-if="currentAccount.role==0" style="color: red">Admin</span>
                        <span v-if="currentAccount.role==1" style="color: orange">Manager</span>
                        <span v-if="currentAccount.role==2" style="color: blue">Mentor</span>
                        <span v-if="currentAccount.role==3" style="color: violet;">Hr</span>
                        <span v-if="currentAccount.role==4" style="color: yellow;">Applicants</span>
                      </label>
                    </li>
                    <li class="careerfy-column-12">
                      <label>Description *</label>
                      <textarea>{{currentAccount.description}}</textarea>
                    </li>
                  </ul>
                </div>
                <div class="careerfy-employer-box-section">
                  <div class="careerfy-profile-title"><h2>Address / Location</h2></div>
                  <ul class="careerfy-row careerfy-employer-profile-form">
                    <li class="careerfy-column-6">
                      <label>Country *</label>
                      <div class="careerfy-profile-select">
                        <select>
                          <option>United Kingdom</option>
                          <option>United Kingdom</option>
                        </select>
                      </div>
                    </li>
                    <li class="careerfy-column-6">
                      <label>Region *</label>
                      <div class="careerfy-profile-select">
                        <select>
                          <option>London</option>
                          <option>London</option>
                        </select>
                      </div>
                    </li>
                    <li class="careerfy-column-6">
                      <label>City / Town *</label>
                      <div class="careerfy-profile-select">
                        <select>
                          <option>London</option>
                          <option>London</option>
                        </select>
                      </div>
                    </li>
                    <li class="careerfy-column-6">
                      <label>Postcode *</label>
                      <input value="746000" onblur="if(this.value == '') { this.value ='746000'; }" onfocus="if(this.value =='746000') { this.value = ''; }" type="text">
                    </li>
                    <li class="careerfy-column-10">
                      <label>Full Address *</label>
                      <input value="Ha Dong - Ha Noi - Viet Nam" onblur="if(this.value == '') { this.value ='Ha Dong - Ha Noi - Viet Nam'; }" onfocus="if(this.value =='Ha Dong - Ha Noi - Viet Nam') { this.value = ''; }" type="text">
                    </li>
                    <li class="careerfy-column-2">
                      <button class="careerfy-findmap-btn">Find on Map</button>
                    </li>
                    <li class="careerfy-column-6">
                      <label>Latitude</label>
                      <input value="51.4935825" onblur="if(this.value == '') { this.value ='51.4935825'; }" onfocus="if(this.value =='51.4935825') { this.value = ''; }" type="text">
                    </li>
                    <li class="careerfy-column-6">
                      <label>Longitude</label>
                      <input value="-0.16803379999998924" onblur="if(this.value == '') { this.value ='-0.16803379999998924'; }" onfocus="if(this.value =='-0.16803379999998924') { this.value = ''; }" type="text">
                    </li>
                    <li class="careerfy-column-12">
                      <div class="careerfy-profile-map"><iframe src="https://www.google.com/maps/embed?pb=!1m14!1m12!1m3!1d22589232.038285658!2d-103.9763543971716!3d46.28054447273778!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!5e0!3m2!1sen!2s!4v1507595834401"></iframe></div>
                      <span class="careerfy-short-message">For the precise location, you can drag and drop the pin.</span>
                    </li>
                  </ul>
                </div>
                <div class="careerfy-employer-box-section">
                  <div class="careerfy-profile-title"><h2>Other Information</h2></div>
                  <ul class="careerfy-row careerfy-employer-profile-form">
                    <li class="careerfy-column-6">
                      <label>Experience *</label>
                      <div class="careerfy-profile-select">
                        <select>
                          <option>5 Years</option>
                          <option>5 Years</option>
                        </select>
                      </div>
                    </li>
                    <li class="careerfy-column-6">
                      <label>Age *</label>
                      <div class="careerfy-profile-select">
                        <select>
                          <option>24</option>
                          <option>24</option>
                        </select>
                      </div>
                    </li>
                    <li class="careerfy-column-6">
                      <label>Current Salary($) *</label>
                      <div class="careerfy-profile-select">
                        <select>
                          <option>$ 2400</option>
                          <option>$ 2400</option>
                        </select>
                      </div>
                    </li>
                    <li class="careerfy-column-6">
                      <label>Expected Salary($) *</label>
                      <div class="careerfy-profile-select">
                        <select>
                          <option>$ 4500</option>
                          <option>$ 4500</option>
                        </select>
                      </div>
                    </li>
                    <li class="careerfy-column-6">
                      <label>Languages *</label>
                      <div class="careerfy-profile-select">
                        <select>
                          <option>English</option>
                          <option>English</option>
                        </select>
                      </div>
                    </li>
                    <li class="careerfy-column-6">
                      <label>Education Levels *</label>
                      <div class="careerfy-profile-select">
                        <select>
                          <option>B.sc Master</option>
                          <option>B.sc Master</option>
                        </select>
                      </div>
                    </li>
                  </ul>
                </div>
                <input type="submit" class="careerfy-employer-profile-submit" value="Save Setting">
              </form>
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- Main Section -->
  </div>
</template>

<script>
export default {
  name: "profile",
  layout: 'home',
  data() {
    return {
      currentAccount: {
        name: '',
        email: '',
        phoneNumber: '',
        thumbnail: '',
        role: 5,
        description: '',
        departmentId: '',
        dateOfCreation: '',
        dateOfUpdate: '',
      },
    }
  },
  mounted() {
    this.getAccountDataValue()
  },
  methods:{
    async getAccountDataValue() {
      try {
        this.currentAccount = await this.$axios.$get('CurrentAccounts')
      } catch (error) {
        this.currentAccount = null
        this.$router.push('/')
      }
    },
  }

}
</script>

<style scoped>

</style>
