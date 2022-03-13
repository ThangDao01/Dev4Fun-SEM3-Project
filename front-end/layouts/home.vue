<template>
  <div>
    <!-- Wrapper -->
    <div class="careerfy-wrapper">

      <!-- Header -->
      <header id="careerfy-header" class="careerfy-header-one">
        <div class="container">
          <div class="row">
            <aside class="col-md-2">
                <NuxtLink class="careerfy-logo" to="/home"><img src="/images/logo.png" alt=""></NuxtLink>
            </aside>
            <aside class="col-md-6">
              <nav class="careerfy-navigation">
                <div class="navbar-header">
                  <button type="button" class="navbar-toggle collapsed" data-toggle="collapse"
                          data-target="#careerfy-navbar-collapse-1" aria-expanded="false">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                  </button>
                </div>
                <div class="collapse navbar-collapse" id="careerfy-navbar-collapse-1">
                  <ul class="navbar-nav">
                    <li class="active">
                      <NuxtLink to="/home"> Home</NuxtLink>
                    </li>
                    <li>
                      <NuxtLink to="/jobs">Jobs</NuxtLink>
                      <ul class="sub-menu">
                        <li>
                          <NuxtLink to="/jobs"> Job Grid W/filter</NuxtLink>
                        </li>
                        <li>
                          <NuxtLink to="/jobs/1">Job Detail</NuxtLink>
                        </li>
                      </ul>
                    </li>
                    <li><a href="#">Recuitment</a>
                      <ul class="sub-menu">
                        <li><a href="candidate-dashboard-applied-jobs.html">Applied Jobs</a></li>
                        <li><a href="candidate-dashboard-changed-password.html">Changed Password</a>
                        </li>
                        <li><a href="candidate-dashboard-cv-manager.html">CV Manager</a></li>
                        <li><a href="candidate-dashboard-job-alert.html">Job Alert</a></li>
                        <li><a href="candidate-dashboard-profile-seting.html">Profile Setting</a></li>
                        <li><a href="candidate-dashboard-resume.html">Candidate Resume</a></li>
                        <li><a href="candidate-dashboard-saved-jobs.html">Saved Jobs</a></li>
                      </ul>
                    </li>
                    <li><a href="about-us.html">About Us</a></li>
                    <li><a href="contact-us.html">Contact</a></li>
                    <li><a href="faq.html">FAQ's</a></li>
                  </ul>
                </div>
              </nav>
            </aside>
            <aside class="col-md-4">
              <div class="careerfy-right">
                <ul class="careerfy-user-section">
                  <li><a class="careerfy-color careerfy-open-signin-tab" href="#">Register</a></li>
                  <li><a class="careerfy-color careerfy-open-signup-tab" href="#">Sign in</a></li>
                </ul>
              </div>
            </aside>
          </div>
        </div>
      </header>
      <!-- Header -->
      <!-- Main Content -->
      <nuxt/>
      <!-- Main Content -->
      <!-- Footer -->
      <footer id="careerfy-footer" class="careerfy-footer-one">
        <div class="container">
          <!-- Footer Widget -->
          <div class="careerfy-footer-widget">
            <div class="row">
              <aside class="widget col-md-4 widget_contact_info">
                <div class="widget_contact_wrap">
                  <NuxtLink to="/home" class="careerfy-footer-logo"><img src="/images/footer-logo.png" alt=""></NuxtLink>
                  <p>Sed consequat sapien faus quam bibendum convallis quis in nulla. Pellentesque volutpat
                    odio eget diam cursus semper. Sed coquat sapien faucibus quam.</p>
                  <a href="#" class="careerfy-classic-btn careerfy-bgcolor">Learn more</a>
                </div>
              </aside>
              <aside class="widget col-md-3 widget_nav_manu">
                <div class="footer-widget-title"><h2>Quick Links</h2></div>
                <ul>
                  <li><a href="#">Shortcodes</a></li>
                  <li><a href="#">Job Page</a></li>
                  <li><a href="#">Job Page Alternative</a></li>
                  <li><a href="#">Resume Page</a></li>
                  <li><a href="#">Blog</a></li>
                  <li><a href="#">Contact</a></li>
                </ul>
              </aside>
              <aside class="widget col-md-3 widget_nav_manu">
                <div class="footer-widget-title"><h2>For Candidates</h2></div>
                <ul>
                  <li><a href="#">Browse Jobs</a></li>
                  <li><a href="#">Browse Categories</a></li>
                  <li><a href="#">Submit Resume</a></li>
                  <li><a href="#">Candidate Dashboard</a></li>
                  <li><a href="#">Job Alerts</a></li>
                  <li><a href="#">My Bookmarks</a></li>
                </ul>
              </aside>
              <aside class="widget col-md-2 widget_nav_manu">
                <div class="footer-widget-title"><h2>For Employers</h2></div>
                <ul>
                  <li><a href="#">Browse Candidates</a></li>
                  <li><a href="#">Employer Dashboard</a></li>
                  <li><a href="#">Add Job</a></li>
                  <li><a href="#">Job Packages</a></li>
                </ul>
              </aside>
            </div>
          </div>
          <!-- Footer Widget -->
          <!-- CopyRight -->
          <div class="careerfy-copyright">
            <p>Copyrights © 2018 All Rights Reserved by <a href="#" class="careerfy-color">EyeCix</a></p>
            <ul class="careerfy-social-network">
              <li><a href="#" class="careerfy-bgcolorhover fa fa-facebook"></a></li>
              <li><a href="#" class="careerfy-bgcolorhover fa fa-twitter"></a></li>
              <li><a href="#" class="careerfy-bgcolorhover fa fa-dribbble"></a></li>
              <li><a href="#" class="careerfy-bgcolorhover fa fa-linkedin"></a></li>
              <li><a href="#" class="careerfy-bgcolorhover fa fa-instagram"></a></li>
            </ul>
          </div>
          <!-- CopyRight -->
        </div>
      </footer>
      <!-- Footer -->

    </div>
    <!-- Wrapper -->

    <!-- ModalLogin Box -->
    <div class="careerfy-modal fade careerfy-typo-wrap" id="JobSearchModalSignup">
      <div class="modal-inner-area">&nbsp;</div>
      <div class="modal-content-area">
        <div class="modal-box-area">

          <div class="careerfy-modal-title-box">
            <h2>Login to your account</h2>
            <span class="modal-close"><i class="fa fa-times"></i></span>
          </div>
          <form>
            <div class="careerfy-box-title">
              <span>Choose your Account Type</span>
            </div>
            <div class="careerfy-user-options">
              <ul>
                <li class="active">
                  <a href="#">
                    <i class="careerfy-icon careerfy-user"></i>
                    <span>Candidate</span>
                    <small>I want to discover awesome companies.</small>
                  </a>
                </li>
                <li>
                  <a href="#">
                    <i class="careerfy-icon careerfy-building"></i>
                    <span>Employer</span>
                    <small>I want to attract the best talent.</small>
                  </a>
                </li>
              </ul>
            </div>
            <div class="careerfy-user-form">
              <ul>
                <li>
                  <label>Email Address:</label>
                  <input value="Enter Your Email Address"
                         onblur="if(this.value == '') { this.value ='Enter Your Email Address'; }"
                         onfocus="if(this.value =='Enter Your Email Address') { this.value = ''; }"
                         type="text">
                  <i class="careerfy-icon careerfy-mail"></i>
                </li>
                <li>
                  <label>Password:</label>
                  <input value="Enter Password"
                         onblur="if(this.value == '') { this.value ='Enter Password'; }"
                         onfocus="if(this.value =='Enter Password') { this.value = ''; }" type="text">
                  <i class="careerfy-icon careerfy-multimedia"></i>
                </li>
                <li>
                  <input type="submit" value="Sign In">
                </li>
              </ul>
              <div class="clearfix"></div>
              <div class="careerfy-user-form-info">
                <p>Forgot Password? | <a href="#">Sign Up</a></p>
                <div class="careerfy-checkbox">
                  <input type="checkbox" id="r10" name="rr"/>
                  <label for="r10"><span></span> Remember Password</label>
                </div>
              </div>
            </div>
            <div class="careerfy-box-title careerfy-box-title-sub">
              <span>Or Sign In With</span>
            </div>
            <div class="clearfix"></div>
            <ul class="careerfy-login-media">
              <li><a href="#"><i class="fa fa-facebook"></i> Sign In with Facebook</a></li>
              <li><a href="#" data-original-title="google"><i class="fa fa-google"></i> Sign In with Google</a>
              </li>
              <li><a href="#" data-original-title="twitter"><i class="fa fa-twitter"></i> Sign In with Twitter</a>
              </li>
              <li><a href="#" data-original-title="linkedin"><i class="fa fa-linkedin"></i> Sign In with LinkedIn</a>
              </li>
            </ul>
          </form>

        </div>
      </div>
    </div>
    <!-- Modal Signup Box -->
    <div class="careerfy-modal fade careerfy-typo-wrap" id="JobSearchModalLogin">
      <div class="modal-inner-area">&nbsp;</div>
      <div class="modal-content-area">
        <div class="modal-box-area">

          <div class="careerfy-modal-title-box">
            <h2>Signup to your account</h2>
            <span class="modal-close"><i class="fa fa-times"></i></span>
          </div>
          <form>
            <div class="careerfy-box-title">
              <span>Choose your Account Type</span>
            </div>
            <div class="careerfy-user-options">
              <ul>
                <li class="active">
                  <a href="#">
                    <i class="careerfy-icon careerfy-user"></i>
                    <span>Candidate</span>
                    <small>I want to discover awesome companies.</small>
                  </a>
                </li>
                <li>
                  <a href="#">
                    <i class="careerfy-icon careerfy-building"></i>
                    <span>Employer</span>
                    <small>I want to attract the best talent.</small>
                  </a>
                </li>
              </ul>
            </div>
            <div class="careerfy-user-form careerfy-user-form-coltwo">
              <ul>
                <li>
                  <label>First Name:</label>
                  <input value="Enter Your Name"
                         onblur="if(this.value == '') { this.value ='Enter Your Name'; }"
                         onfocus="if(this.value =='Enter Your Name') { this.value = ''; }" type="text">
                  <i class="careerfy-icon careerfy-user"></i>
                </li>
                <li>
                  <label>Last Name:</label>
                  <input value="Enter Your Name"
                         onblur="if(this.value == '') { this.value ='Enter Your Name'; }"
                         onfocus="if(this.value =='Enter Your Name') { this.value = ''; }" type="text">
                  <i class="careerfy-icon careerfy-user"></i>
                </li>
                <li>
                  <label>Email Address:</label>
                  <input value="Enter Your Email Address"
                         onblur="if(this.value == '') { this.value ='Enter Your Email Address'; }"
                         onfocus="if(this.value =='Enter Your Email Address') { this.value = ''; }"
                         type="text">
                  <i class="careerfy-icon careerfy-mail"></i>
                </li>
                <li>
                  <label>Phone Number:</label>
                  <input value="Enter Your Phone Number"
                         onblur="if(this.value == '') { this.value ='Enter Your Phone Number'; }"
                         onfocus="if(this.value =='Enter Your Phone Number') { this.value = ''; }"
                         type="text">
                  <i class="careerfy-icon careerfy-technology"></i>
                </li>
                <li class="careerfy-user-form-coltwo-full">
                  <label>Categories:</label>
                  <div class="careerfy-profile-select">
                    <select>
                      <option>Sales & Marketing</option>
                      <option>Sales & Marketing</option>
                    </select>
                  </div>
                </li>
                <li class="careerfy-user-form-coltwo-full">
                  <img src="extra-images/login-robot.png" alt="">
                </li>
                <li class="careerfy-user-form-coltwo-full">
                  <input type="submit" value="Sign Up">
                </li>
              </ul>
            </div>
            <div class="careerfy-box-title careerfy-box-title-sub">
              <span>Or Sign Up With</span>
            </div>
            <div class="clearfix"></div>
            <ul class="careerfy-login-media">
              <li><a href="#"><i class="fa fa-facebook"></i> Sign In with Facebook</a></li>
              <li><a href="#" data-original-title="google"><i class="fa fa-google"></i> Sign In with Google</a>
              </li>
              <li><a href="#" data-original-title="twitter"><i class="fa fa-twitter"></i> Sign In with Twitter</a>
              </li>
              <li><a href="#" data-original-title="linkedin"><i class="fa fa-linkedin"></i> Sign In with LinkedIn</a>
              </li>
            </ul>
          </form>

        </div>
      </div>
    </div>


    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <!--  <script src="script/jquery.js"></script>-->
    <!--  <script src="script/bootstrap.js"></script>-->
    <!--  <script src="script/slick-slider.js"></script>-->
    <!--  <script src="plugin-script/counter.js"></script>-->
    <!--  <script src="plugin-script/progressbar.js"></script>-->
    <!--  <script src="plugin-script/fancybox.pack.js"></script>-->
    <!--  <script src="plugin-script/isotope.min.js"></script>-->
    <!--  <script src="plugin-script/functions.js"></script>-->
    <!--  <script src="script/functions.js"></script>-->

  </div>

</template>

<script>
export default {
  name: "home.vue",
  head() {
    return {
      link: [
        {rel: 'stylesheet', href: '/css/bootstrap.min.css'},
        {rel: 'stylesheet', href: '/css/bootstrap.css'},
        {rel: 'stylesheet', href: '/css/font-awesome.css'},
        {rel: 'stylesheet', href: '/css/flaticon.css'},
        {rel: 'stylesheet', href: '/css/slick-slider.css'},
        {rel: 'stylesheet', href: '/plugin-css/fancybox.css'},
        {rel: 'stylesheet', href: '/plugin-css/plugin.css'},
        {rel: 'stylesheet', href: '/css/color.css'},
        {rel: 'stylesheet', href: '/css/style.css'},
        {rel: 'stylesheet', href: '/css/responsive.css'},

        {rel: 'stylesheet',href: 'https://fonts.googleapis.com/css?family=Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i&amp;subset=cyrillic-ext,vietnamese'},

      ],
      script: [
        {hid: 'stripe', src: '/script/jquery.js', defer: true},
        {hid: 'stripe', src: '/script/bootstrap.js', defer: true},
        {hid: 'stripe', src: '/script/slick-slider.js', defer: true},
        {hid: 'stripe', src: '/plugin-script/counter.js', defer: true},
        {hid: 'stripe', src: '/plugin-script/progressbar.js', defer: true},
        {hid: 'stripe', src: '/plugin-script/fancybox.pack.js', defer: true},
        {hid: 'stripe', src: '/plugin-script/isotope.min.js', defer: true},
        {hid: 'stripe', src: '/plugin-script/functions.js', defer: true},
        {hid: 'stripe', src: '/script/functions.js', defer: true},
        {hid: 'stripe', src: 'https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js', defer: true},
        {hid: 'stripe', src: 'https://oss.maxcdn.com/respond/1.4.2/respond.min.js', defer: true},
      ]
    }
  }
}
</script>

<style scoped>

</style>
