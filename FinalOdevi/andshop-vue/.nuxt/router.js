import Vue from 'vue'
import Router from 'vue-router'
import { normalizeURL, decode } from 'ufo'
import { interopDefault } from './utils'
import scrollBehavior from './router.scrollBehavior.js'

const _8873c404 = () => interopDefault(import('..\\pages\\404.vue' /* webpackChunkName: "pages/404" */))
const _29f58f08 = () => interopDefault(import('..\\pages\\about-us.vue' /* webpackChunkName: "pages/about-us" */))
const _e661e394 = () => interopDefault(import('..\\pages\\blog\\index.vue' /* webpackChunkName: "pages/blog/index" */))
const _61b147f8 = () => interopDefault(import('..\\pages\\cart\\index.vue' /* webpackChunkName: "pages/cart/index" */))
const _53a1740d = () => interopDefault(import('..\\pages\\coming-soon.vue' /* webpackChunkName: "pages/coming-soon" */))
const _6621bc4d = () => interopDefault(import('..\\pages\\contact-us\\index.vue' /* webpackChunkName: "pages/contact-us/index" */))
const _c6b2e686 = () => interopDefault(import('..\\pages\\electronics.vue' /* webpackChunkName: "pages/electronics" */))
const _67b6c0dc = () => interopDefault(import('..\\pages\\faq.vue' /* webpackChunkName: "pages/faq" */))
const _5c4a3590 = () => interopDefault(import('..\\pages\\furniture.vue' /* webpackChunkName: "pages/furniture" */))
const _4bd4b75a = () => interopDefault(import('..\\pages\\grocery.vue' /* webpackChunkName: "pages/grocery" */))
const _5fd81fa2 = () => interopDefault(import('..\\pages\\login.vue' /* webpackChunkName: "pages/login" */))
const _e33e919c = () => interopDefault(import('..\\pages\\lookbook.vue' /* webpackChunkName: "pages/lookbook" */))
const _09deee0c = () => interopDefault(import('..\\pages\\my-account\\index.vue' /* webpackChunkName: "pages/my-account/index" */))
const _69bbd746 = () => interopDefault(import('..\\pages\\pharmacy.vue' /* webpackChunkName: "pages/pharmacy" */))
const _8418a97e = () => interopDefault(import('..\\pages\\privacy-policy.vue' /* webpackChunkName: "pages/privacy-policy" */))
const _02e6f366 = () => interopDefault(import('..\\pages\\register.vue' /* webpackChunkName: "pages/register" */))
const _4228c662 = () => interopDefault(import('..\\pages\\shop\\index.vue' /* webpackChunkName: "pages/shop/index" */))
const _e6d49b2e = () => interopDefault(import('..\\pages\\vendor-dashboard\\index.vue' /* webpackChunkName: "pages/vendor-dashboard/index" */))
const _d1c54cda = () => interopDefault(import('..\\pages\\blog\\blog-2.vue' /* webpackChunkName: "pages/blog/blog-2" */))
const _d1a91dd8 = () => interopDefault(import('..\\pages\\blog\\blog-3.vue' /* webpackChunkName: "pages/blog/blog-3" */))
const _198ed81c = () => interopDefault(import('..\\pages\\blog\\blog-single-2.vue' /* webpackChunkName: "pages/blog/blog-single-2" */))
const _49a0e5e2 = () => interopDefault(import('..\\pages\\cart\\cart-2.vue' /* webpackChunkName: "pages/cart/cart-2" */))
const _4984b6e0 = () => interopDefault(import('..\\pages\\cart\\cart-3.vue' /* webpackChunkName: "pages/cart/cart-3" */))
const _496887de = () => interopDefault(import('..\\pages\\cart\\cart-4.vue' /* webpackChunkName: "pages/cart/cart-4" */))
const _18ef656a = () => interopDefault(import('..\\pages\\cart\\empty-cart.vue' /* webpackChunkName: "pages/cart/empty-cart" */))
const _32e691a5 = () => interopDefault(import('..\\pages\\contact-us\\contact-us-2.vue' /* webpackChunkName: "pages/contact-us/contact-us-2" */))
const _30289d5c = () => interopDefault(import('..\\pages\\my-account\\account-details.vue' /* webpackChunkName: "pages/my-account/account-details" */))
const _bcedc23a = () => interopDefault(import('..\\pages\\my-account\\account-info-edit.vue' /* webpackChunkName: "pages/my-account/account-info-edit" */))
const _1ce89048 = () => interopDefault(import('..\\pages\\my-account\\addresses.vue' /* webpackChunkName: "pages/my-account/addresses" */))
const _33099ec0 = () => interopDefault(import('..\\pages\\my-account\\checkout-1.vue' /* webpackChunkName: "pages/my-account/checkout-1" */))
const _32ed6fbe = () => interopDefault(import('..\\pages\\my-account\\checkout-2.vue' /* webpackChunkName: "pages/my-account/checkout-2" */))
const _37af3fc2 = () => interopDefault(import('..\\pages\\my-account\\compare.vue' /* webpackChunkName: "pages/my-account/compare" */))
const _01ffb8a5 = () => interopDefault(import('..\\pages\\my-account\\downloads.vue' /* webpackChunkName: "pages/my-account/downloads" */))
const _251e348c = () => interopDefault(import('..\\pages\\my-account\\order-tracking.vue' /* webpackChunkName: "pages/my-account/order-tracking" */))
const _3637c39b = () => interopDefault(import('..\\pages\\my-account\\orders.vue' /* webpackChunkName: "pages/my-account/orders" */))
const _e9a0120a = () => interopDefault(import('..\\pages\\my-account\\wishlist.vue' /* webpackChunkName: "pages/my-account/wishlist" */))
const _f1c85a00 = () => interopDefault(import('..\\pages\\product\\product-single-2.vue' /* webpackChunkName: "pages/product/product-single-2" */))
const _f1ac2afe = () => interopDefault(import('..\\pages\\product\\product-single-3.vue' /* webpackChunkName: "pages/product/product-single-3" */))
const _50e1833b = () => interopDefault(import('..\\pages\\shop\\shop-2.vue' /* webpackChunkName: "pages/shop/shop-2" */))
const _50ef9abc = () => interopDefault(import('..\\pages\\shop\\shop-3.vue' /* webpackChunkName: "pages/shop/shop-3" */))
const _50fdb23d = () => interopDefault(import('..\\pages\\shop\\shop-4.vue' /* webpackChunkName: "pages/shop/shop-4" */))
const _510bc9be = () => interopDefault(import('..\\pages\\shop\\shop-5.vue' /* webpackChunkName: "pages/shop/shop-5" */))
const _732934cc = () => interopDefault(import('..\\pages\\vendor-dashboard\\add-product.vue' /* webpackChunkName: "pages/vendor-dashboard/add-product" */))
const _b53f1a36 = () => interopDefault(import('..\\pages\\vendor-dashboard\\order.vue' /* webpackChunkName: "pages/vendor-dashboard/order" */))
const _53eafc46 = () => interopDefault(import('..\\pages\\vendor-dashboard\\product.vue' /* webpackChunkName: "pages/vendor-dashboard/product" */))
const _912a6800 = () => interopDefault(import('..\\pages\\vendor-dashboard\\profile.vue' /* webpackChunkName: "pages/vendor-dashboard/profile" */))
const _b4eab5b2 = () => interopDefault(import('..\\pages\\vendor-dashboard\\setting.vue' /* webpackChunkName: "pages/vendor-dashboard/setting" */))
const _066c4d18 = () => interopDefault(import('..\\pages\\index.vue' /* webpackChunkName: "pages/index" */))
const _e9cf2624 = () => interopDefault(import('..\\pages\\blog\\_slug.vue' /* webpackChunkName: "pages/blog/_slug" */))
const _046b2155 = () => interopDefault(import('..\\pages\\product\\_id.vue' /* webpackChunkName: "pages/product/_id" */))

const emptyFn = () => {}

Vue.use(Router)

export const routerOptions = {
  mode: 'history',
  base: '/',
  linkActiveClass: 'nuxt-link-active',
  linkExactActiveClass: 'nuxt-link-exact-active',
  scrollBehavior,

  routes: [{
    path: "/404",
    component: _8873c404,
    name: "404"
  }, {
    path: "/about-us",
    component: _29f58f08,
    name: "about-us"
  }, {
    path: "/blog",
    component: _e661e394,
    name: "blog"
  }, {
    path: "/cart",
    component: _61b147f8,
    name: "cart"
  }, {
    path: "/coming-soon",
    component: _53a1740d,
    name: "coming-soon"
  }, {
    path: "/contact-us",
    component: _6621bc4d,
    name: "contact-us"
  }, {
    path: "/electronics",
    component: _c6b2e686,
    name: "electronics"
  }, {
    path: "/faq",
    component: _67b6c0dc,
    name: "faq"
  }, {
    path: "/furniture",
    component: _5c4a3590,
    name: "furniture"
  }, {
    path: "/grocery",
    component: _4bd4b75a,
    name: "grocery"
  }, {
    path: "/login",
    component: _5fd81fa2,
    name: "login"
  }, {
    path: "/lookbook",
    component: _e33e919c,
    name: "lookbook"
  }, {
    path: "/my-account",
    component: _09deee0c,
    name: "my-account"
  }, {
    path: "/pharmacy",
    component: _69bbd746,
    name: "pharmacy"
  }, {
    path: "/privacy-policy",
    component: _8418a97e,
    name: "privacy-policy"
  }, {
    path: "/register",
    component: _02e6f366,
    name: "register"
  }, {
    path: "/shop",
    component: _4228c662,
    name: "shop"
  }, {
    path: "/vendor-dashboard",
    component: _e6d49b2e,
    name: "vendor-dashboard"
  }, {
    path: "/blog/blog-2",
    component: _d1c54cda,
    name: "blog-blog-2"
  }, {
    path: "/blog/blog-3",
    component: _d1a91dd8,
    name: "blog-blog-3"
  }, {
    path: "/blog/blog-single-2",
    component: _198ed81c,
    name: "blog-blog-single-2"
  }, {
    path: "/cart/cart-2",
    component: _49a0e5e2,
    name: "cart-cart-2"
  }, {
    path: "/cart/cart-3",
    component: _4984b6e0,
    name: "cart-cart-3"
  }, {
    path: "/cart/cart-4",
    component: _496887de,
    name: "cart-cart-4"
  }, {
    path: "/cart/empty-cart",
    component: _18ef656a,
    name: "cart-empty-cart"
  }, {
    path: "/contact-us/contact-us-2",
    component: _32e691a5,
    name: "contact-us-contact-us-2"
  }, {
    path: "/my-account/account-details",
    component: _30289d5c,
    name: "my-account-account-details"
  }, {
    path: "/my-account/account-info-edit",
    component: _bcedc23a,
    name: "my-account-account-info-edit"
  }, {
    path: "/my-account/addresses",
    component: _1ce89048,
    name: "my-account-addresses"
  }, {
    path: "/my-account/checkout-1",
    component: _33099ec0,
    name: "my-account-checkout-1"
  }, {
    path: "/my-account/checkout-2",
    component: _32ed6fbe,
    name: "my-account-checkout-2"
  }, {
    path: "/my-account/compare",
    component: _37af3fc2,
    name: "my-account-compare"
  }, {
    path: "/my-account/downloads",
    component: _01ffb8a5,
    name: "my-account-downloads"
  }, {
    path: "/my-account/order-tracking",
    component: _251e348c,
    name: "my-account-order-tracking"
  }, {
    path: "/my-account/orders",
    component: _3637c39b,
    name: "my-account-orders"
  }, {
    path: "/my-account/wishlist",
    component: _e9a0120a,
    name: "my-account-wishlist"
  }, {
    path: "/product/product-single-2",
    component: _f1c85a00,
    name: "product-product-single-2"
  }, {
    path: "/product/product-single-3",
    component: _f1ac2afe,
    name: "product-product-single-3"
  }, {
    path: "/shop/shop-2",
    component: _50e1833b,
    name: "shop-shop-2"
  }, {
    path: "/shop/shop-3",
    component: _50ef9abc,
    name: "shop-shop-3"
  }, {
    path: "/shop/shop-4",
    component: _50fdb23d,
    name: "shop-shop-4"
  }, {
    path: "/shop/shop-5",
    component: _510bc9be,
    name: "shop-shop-5"
  }, {
    path: "/vendor-dashboard/add-product",
    component: _732934cc,
    name: "vendor-dashboard-add-product"
  }, {
    path: "/vendor-dashboard/order",
    component: _b53f1a36,
    name: "vendor-dashboard-order"
  }, {
    path: "/vendor-dashboard/product",
    component: _53eafc46,
    name: "vendor-dashboard-product"
  }, {
    path: "/vendor-dashboard/profile",
    component: _912a6800,
    name: "vendor-dashboard-profile"
  }, {
    path: "/vendor-dashboard/setting",
    component: _b4eab5b2,
    name: "vendor-dashboard-setting"
  }, {
    path: "/",
    component: _066c4d18,
    name: "index"
  }, {
    path: "/blog/:slug",
    component: _e9cf2624,
    name: "blog-slug"
  }, {
    path: "/product/:id?",
    component: _046b2155,
    name: "product-id"
  }],

  fallback: false
}

export function createRouter (ssrContext, config) {
  const base = (config._app && config._app.basePath) || routerOptions.base
  const router = new Router({ ...routerOptions, base  })

  // TODO: remove in Nuxt 3
  const originalPush = router.push
  router.push = function push (location, onComplete = emptyFn, onAbort) {
    return originalPush.call(this, location, onComplete, onAbort)
  }

  const resolve = router.resolve.bind(router)
  router.resolve = (to, current, append) => {
    if (typeof to === 'string') {
      to = normalizeURL(to)
    }
    return resolve(to, current, append)
  }

  return router
}
