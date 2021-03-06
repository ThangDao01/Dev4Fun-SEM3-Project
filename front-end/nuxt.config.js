export default {
  // Global page headers: https://go.nuxtjs.dev/config-head
  head: {
    title: 'front-end',
    htmlAttrs: {
      lang: 'en'
    },
    meta: [
      { charset: 'utf-8' },
      { name: 'viewport', content: 'width=device-width, initial-scale=1' },
      { hid: 'description', name: 'description', content: '' },
      { name: 'format-detection', content: 'telephone=no' }
    ],
    link: [
      { rel: 'icon', type: 'image/x-icon', href: '/favicon.ico' }
    ]
  },
  proxy: {
    '/api/': {
      target: process.env.MAIN_API_URL, // a url for your api
      secure: !process.env.ENV === 'development'
    }
  },
  // Axios module configuration: https://go.nuxtjs.dev/config-axios

  // axios: {
  //   baseURL: 'https://localhost:7187/api',
  //   timeout: 30000
  // },
  axios: {
    baseURL: 'https://localhost:7187/api/',
    timeout: 30000
  },

  // Global CSS: https://go.nuxtjs.dev/config-css
  css: [
  ],

  // Plugins to run before rendering page: https://go.nuxtjs.dev/config-plugins
  plugins: [
    '@/plugins/axios'
  ],

  // Auto import components: https://go.nuxtjs.dev/config-components
  components: true,

  // Modules for dev and build (recommended): https://go.nuxtjs.dev/config-modules
  buildModules: [
  ],

  // Modules: https://go.nuxtjs.dev/config-modules
  modules: [
    '@nuxtjs/axios'
  ],

  // Build Configuration: https://go.nuxtjs.dev/config-build
  build: {
  },
  cloudinary: {
    cloudName: 'thangdao04',
    apiKey: '787768913945176', //only needed if you are using server-side upload
    apiSecret: 'yC0bQkMU2N5C6HLpkAVFqjWx4Pc', //only needed if you are using server-side upload
    useComponent: true //use Vue components
  }
}
