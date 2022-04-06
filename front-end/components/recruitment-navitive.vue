<template>
  <aside class="careerfy-column-3">
    <div class="careerfy-typo-wrap">
      <div class="careerfy-employer-dashboard-nav">
        <figure>
          <a href="#" class="employer-dashboard-thumb"><img
            src="https://res.cloudinary.com/thangdao04/image/upload/v1648307730/avatar_auto_x2_hbajbf.jpg" alt=""></a>
          <figcaption>
            <div class="careerfy-fileUpload">
              <span><i class="careerfy-icon careerfy-add"></i> Upload Photo</span>
              <input type="file" class="careerfy-upload"/>
            </div>
            <h2>Đào Thắng</h2>
            <span class="careerfy-dashboard-subtitle">Admin</span>
          </figcaption>
        </figure>
        <ul>
          <li><a href="candidate-dashboard-profile-seting.html"><i class="careerfy-icon careerfy-user"></i> My
            Profile</a></li>
          <li><a href="candidate-dashboard-resume.html"><i class="careerfy-icon careerfy-resume"></i> My Resume</a></li>
          <li><a href="candidate-dashboard-saved-jobs.html"><i class="careerfy-icon careerfy-heart"></i> Saved jobs</a>
          </li>
          <li><a href="candidate-dashboard-applied-jobs.html"><i
            class="careerfy-icon careerfy-briefcase-1"></i> Applied jobs</a></li>
          <li><a href="candidate-dashboard-job-alert.html"><i class="careerfy-icon careerfy-alarm"></i> Job Alerts</a>
          </li>
          <li><a href="candidate-dashboard-cv-manager.html"><i class="careerfy-icon careerfy-id-card"></i> CV
            Manager</a></li>
          <li><a href="candidate-dashboard-changed-password.html"><i class="careerfy-icon careerfy-multimedia"></i>
            Change Password</a></li>
          <li @click="logout()"><a ><i class="careerfy-icon careerfy-logout"></i> Logout</a></li>
        </ul>
      </div>
    </div>
  </aside>

</template>

<script>
export default {
  name: "recruitment-navitive",
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
  async mounted() {
    await this.getAccount()
  },
  methods:{
    async getAccount() {
      this.currentAccount = await this.$axios.$get('CurrentAccounts')
    },
    async logout(){
      await this.$axios.$get('logout')
      await this.$router.push('/')
    },
  }
}
</script>

<style scoped>

</style>
