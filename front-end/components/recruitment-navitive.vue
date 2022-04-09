<template>
  <aside class="careerfy-column-3">
    <div class="careerfy-typo-wrap">
      <div class="careerfy-employer-dashboard-nav">
        <figure>
          <a href="#" class="employer-dashboard-thumb"><img
            :src="currentAccount.thumbnail" alt=""></a>
          <figcaption>

            <h2>{{ currentAccount.name }}</h2>
            <span v-if="currentAccount.role==0" style="color: red">Admin</span>
            <span v-if="currentAccount.role==1" style="color: orange">Manager</span>
            <span v-if="currentAccount.role==2" style="color: blue">Mentor</span>
            <span v-if="currentAccount.role==3" style="color: violet;">Hr</span>
            <span v-if="currentAccount.role==4" style="color: yellow;">Applicants</span>
          </figcaption>
        </figure>
        <ul>
          <li>
            <NuxtLink to="/recruitment/profile"><i class="careerfy-icon careerfy-user"></i> My
              Profile
            </NuxtLink>
          </li>
          <li><a href="candidate-dashboard-resume.html"><i class="careerfy-icon careerfy-resume"></i> My Resume</a></li>
          <li><a href="candidate-dashboard-saved-jobs.html"><i class="careerfy-icon careerfy-heart"></i> Saved jobs</a>
          </li>
          <li>
            <NuxtLink to="/recruitment/applied-job"><i
              class="careerfy-icon careerfy-briefcase-1"></i> Applied jobs
            </NuxtLink>
          </li>
          <li>
            <NuxtLink to="/recruitment/alert-job"><i class="careerfy-icon careerfy-alarm"></i> Job Alerts
            </NuxtLink>
          </li>
          <li><a href="candidate-dashboard-cv-manager.html"><i class="careerfy-icon careerfy-id-card"></i> CV
            Manager</a></li>
          <li><a href="candidate-dashboard-changed-password.html"><i class="careerfy-icon careerfy-multimedia"></i>
            Change Password</a></li>
          <li @click="logout()"><a><i class="careerfy-icon careerfy-logout"></i> Logout</a></li>
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
  methods: {
    async getAccount() {
      this.currentAccount = await this.$axios.$get('CurrentAccounts')
    },
    async logout() {
      await this.$axios.$get('logout')
      await this.$router.push('/')
    },
  }
}
</script>

<style scoped>

</style>
