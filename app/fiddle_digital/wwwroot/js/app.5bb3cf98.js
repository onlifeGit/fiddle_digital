(function(t){function e(e){for(var n,i,o=e[0],c=e[1],l=e[2],u=0,d=[];u<o.length;u++)i=o[u],r[i]&&d.push(r[i][0]),r[i]=0;for(n in c)Object.prototype.hasOwnProperty.call(c,n)&&(t[n]=c[n]);p&&p(e);while(d.length)d.shift()();return s.push.apply(s,l||[]),a()}function a(){for(var t,e=0;e<s.length;e++){for(var a=s[e],n=!0,i=1;i<a.length;i++){var c=a[i];0!==r[c]&&(n=!1)}n&&(s.splice(e--,1),t=o(o.s=a[0]))}return t}var n={},r={app:0},s=[];function i(t){return o.p+"js/"+({contact:"contact",faces:"faces",journal:"journal",performance:"performance",project:"project",singlearticle:"singlearticle"}[t]||t)+"."+{contact:"40447e3e",faces:"021e3f3a",journal:"e4396672",performance:"3bfe3697",project:"13d6105c",singlearticle:"d28257d1"}[t]+".js"}function o(e){if(n[e])return n[e].exports;var a=n[e]={i:e,l:!1,exports:{}};return t[e].call(a.exports,a,a.exports,o),a.l=!0,a.exports}o.e=function(t){var e=[],a=r[t];if(0!==a)if(a)e.push(a[2]);else{var n=new Promise(function(e,n){a=r[t]=[e,n]});e.push(a[2]=n);var s,c=document.createElement("script");c.charset="utf-8",c.timeout=120,o.nc&&c.setAttribute("nonce",o.nc),c.src=i(t),s=function(e){c.onerror=c.onload=null,clearTimeout(l);var a=r[t];if(0!==a){if(a){var n=e&&("load"===e.type?"missing":e.type),s=e&&e.target&&e.target.src,i=new Error("Loading chunk "+t+" failed.\n("+n+": "+s+")");i.type=n,i.request=s,a[1](i)}r[t]=void 0}};var l=setTimeout(function(){s({type:"timeout",target:c})},12e4);c.onerror=c.onload=s,document.head.appendChild(c)}return Promise.all(e)},o.m=t,o.c=n,o.d=function(t,e,a){o.o(t,e)||Object.defineProperty(t,e,{enumerable:!0,get:a})},o.r=function(t){"undefined"!==typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(t,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(t,"__esModule",{value:!0})},o.t=function(t,e){if(1&e&&(t=o(t)),8&e)return t;if(4&e&&"object"===typeof t&&t&&t.__esModule)return t;var a=Object.create(null);if(o.r(a),Object.defineProperty(a,"default",{enumerable:!0,value:t}),2&e&&"string"!=typeof t)for(var n in t)o.d(a,n,function(e){return t[e]}.bind(null,n));return a},o.n=function(t){var e=t&&t.__esModule?function(){return t["default"]}:function(){return t};return o.d(e,"a",e),e},o.o=function(t,e){return Object.prototype.hasOwnProperty.call(t,e)},o.p="/",o.oe=function(t){throw console.error(t),t};var c=window["webpackJsonp"]=window["webpackJsonp"]||[],l=c.push.bind(c);c.push=e,c=c.slice();for(var u=0;u<c.length;u++)e(c[u]);var p=l;s.push([0,"chunk-vendors"]),a()})({0:function(t,e,a){t.exports=a("56d7")},"365c":function(t,e,a){"use strict";a("7f7f"),a("96cf");var n=a("3b8d"),r=a("795b"),s=a.n(r),i=a("bc3a"),o=a.n(i),c=o.a.create({baseURL:"/home"}),l=function(t){var e=function(t){return t.data},a=function(t){return s.a.reject(t.response||t.message)};return c(t).then(e).catch(a)};function u(t){return p.apply(this,arguments)}function p(){return p=Object(n["a"])(regeneratorRuntime.mark(function t(e){return regeneratorRuntime.wrap(function(t){while(1)switch(t.prev=t.next){case 0:return t.abrupt("return",l({url:"/uploadpdf",method:"POST",data:e,headers:{"Content-Type":"multipart/form-data"}}));case 1:case"end":return t.stop()}},t)})),p.apply(this,arguments)}function d(t){return f.apply(this,arguments)}function f(){return f=Object(n["a"])(regeneratorRuntime.mark(function t(e){var a,n,r,s;return regeneratorRuntime.wrap(function(t){while(1)switch(t.prev=t.next){case 0:return a=e.name,n=e.phone,r=e.email,s=e.message,t.abrupt("return",l({url:"/send_mail",method:"POST",data:{name:a,phone:n,email:r,message:s}}));case 2:case"end":return t.stop()}},t)})),f.apply(this,arguments)}function m(){return h.apply(this,arguments)}function h(){return h=Object(n["a"])(regeneratorRuntime.mark(function t(){return regeneratorRuntime.wrap(function(t){while(1)switch(t.prev=t.next){case 0:return t.abrupt("return",l({url:"/get_projects",method:"GET"}));case 1:case"end":return t.stop()}},t)})),h.apply(this,arguments)}function v(t){return g.apply(this,arguments)}function g(){return g=Object(n["a"])(regeneratorRuntime.mark(function t(e){return regeneratorRuntime.wrap(function(t){while(1)switch(t.prev=t.next){case 0:return t.abrupt("return",l({url:"/get_project_details?id=".concat(e),method:"POST"}));case 1:case"end":return t.stop()}},t)})),g.apply(this,arguments)}function _(){return b.apply(this,arguments)}function b(){return b=Object(n["a"])(regeneratorRuntime.mark(function t(){return regeneratorRuntime.wrap(function(t){while(1)switch(t.prev=t.next){case 0:return t.abrupt("return",l({url:"/get_last_project",method:"GET"}));case 1:case"end":return t.stop()}},t)})),b.apply(this,arguments)}function w(){return j.apply(this,arguments)}function j(){return j=Object(n["a"])(regeneratorRuntime.mark(function t(){return regeneratorRuntime.wrap(function(t){while(1)switch(t.prev=t.next){case 0:return t.abrupt("return",l({url:"/get_articles",method:"GET"}));case 1:case"end":return t.stop()}},t)})),j.apply(this,arguments)}function C(t){return y.apply(this,arguments)}function y(){return y=Object(n["a"])(regeneratorRuntime.mark(function t(e){return regeneratorRuntime.wrap(function(t){while(1)switch(t.prev=t.next){case 0:return t.abrupt("return",l({url:"/get_article?id=".concat(e),method:"POST"}));case 1:case"end":return t.stop()}},t)})),y.apply(this,arguments)}e["a"]={uploadPdf:u,sendFeedback:d,getProjects:m,getProject:v,getLastProject:_,getArticles:w,getArticle:C}},"56d7":function(t,e,a){"use strict";a.r(e);a("cadf"),a("551c"),a("f751"),a("097d");var n=a("2b0e"),r=function(){var t=this,e=t.$createElement,a=t._self._c||e;return a("transition",{attrs:{name:"component-fade",mode:"out-in"}},[a(t.currentView,{tag:"component"})],1)},s=[],i=function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("div",{staticClass:"container"},[t.loading?[n("div",{staticStyle:{"text-align":"center","padding-top":"50px"}},[t._v("LOADING")])]:[n("router-view"),n("header",[n("div",{staticClass:"hw"},[n("nav",[n("div",{staticClass:"h_l"},[n("router-link",{attrs:{to:{name:"home"},exact:""}},[n("span",[t._v("Fiddle digital")]),n("label",{staticClass:"descriptor"},[t._v("House of digital"),n("br"),t._v("aesthetics")])])],1),n("router-link",{attrs:{to:{name:"performance"}}},[t._v("Performance")]),n("router-link",{attrs:{to:{name:"faces"}}},[t._v("Faces")]),n("router-link",{attrs:{to:{name:"journal"}}},[t._v("Journal")]),n("router-link",{attrs:{to:{name:"contact"}}},[t._v("Contact")])],1),n("router-link",{staticClass:"main_logo",attrs:{to:{name:"home"}}},[n("span",{staticClass:"s1"}),n("span",{staticClass:"s2"}),n("span",{staticClass:"s3"}),n("span",{staticClass:"s4"}),n("img",{attrs:{src:a("6552")}})]),n("div",{staticClass:"m_menu_show",on:{click:function(e){t.showModal=!t.showModal}}},[n("div",{staticClass:"mm1"}),n("div",{staticClass:"mm2"}),n("div",{staticClass:"mm3"})])],1)]),t._m(0),n("transition",{attrs:{name:"modal_menu_fade"}},[t.showModal?n("div",{staticClass:"modal modal_menu"},[n("div",{staticClass:"modal_wrapper"},[n("div",{staticClass:"modal_header"},[n("figure",{staticClass:"main_logo"},[n("span",{staticClass:"s1"}),n("span",{staticClass:"s2"}),n("span",{staticClass:"s3"}),n("span",{staticClass:"s4"}),n("img",{attrs:{src:a("6552")}})]),n("div",{staticClass:"m_menu_close",on:{click:function(e){t.showModal=!t.showModal}}},[n("div",{staticClass:"mm1"}),n("div",{staticClass:"mm2"})])]),n("nav",{on:{click:function(e){t.showModal=!t.showModal}}},[n("router-link",{staticClass:"home",attrs:{to:{name:"home"},exact:""}},[n("span",[t._v("Fiddle digital")]),n("label",{staticClass:"descriptor"},[t._v("House of digital"),n("br"),t._v("aesthetics")])]),n("router-link",{attrs:{to:{name:"performance"}}},[t._v("Performance")]),n("router-link",{attrs:{to:{name:"faces"}}},[t._v("Faces")]),n("router-link",{attrs:{to:{name:"journal"}}},[t._v("Journal")]),n("router-link",{attrs:{to:{name:"contact"}}},[t._v("Contact")])],1)])]):t._e()])]],2)},o=[function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("footer",[n("div",{staticClass:"fw"},[n("address",[n("label",{staticClass:"minapper"},[t._v("Let’s make"),n("br"),t._v("it together."),n("br"),t._v("Say::")]),n("h4",[t._v("hello@fiddle.digital")]),n("div",{staticClass:"next"},[n("div",{staticClass:"phone"},[n("a",{attrs:{href:"tel:+38 066 530 56 59",type:"phone"}},[t._v("+38 066 530 56 59")])]),n("div",{staticClass:"social"},[n("a",{staticClass:"fb",attrs:{href:"https://www.facebook.com/fiddle.digital",target:"_blank"}}),n("a",{staticClass:"insta",attrs:{href:"https://www.instagram.com/fiddle.digital",target:"_blank"}}),n("a",{staticClass:"behance",attrs:{href:"https://www.behance.net/Fiddledigital",target:"_blank"}}),n("a",{staticClass:"dribbble",attrs:{href:"https://dribbble.com/Fiddle-digital",target:"_blank"}})])])]),n("div",{staticClass:"laststand"},[n("div",{staticClass:"rewards"},[n("ul",[n("li",{staticClass:"awwwwards"},[n("a",{attrs:{href:"https://www.awwwards.com/Fiddle.digital/",target:"_blank"}},[n("span",[n("img",{attrs:{src:a("c96c")}})]),n("span",{staticClass:"h6"},[t._v("1")]),n("label",{staticClass:"minapper"},[t._v("Awwwards")])])])])]),n("div",[n("a",{staticClass:"presentation",attrs:{href:"#",target:"/Files/Presentation/file.pdf"}},[t._v("Fiddle presentation")])]),n("label",{staticClass:"copy"},[t._v("© 2019 "),n("span",{staticClass:"minapper"},[t._v("s.—17")])])])])])}],c=a("cebc"),l=a("2f62"),u={name:"base-view",data:function(){return{showModal:!1}},computed:Object(c["a"])({},Object(l["c"])({loading:"loading"}))},p=u,d=a("2877"),f=Object(d["a"])(p,i,o,!1,null,"7fc146fc",null),m=f.exports,h={name:"App",components:{"base-view":m},data:function(){return{currentView:"base-view"}}},v=h,g=(a("5c0b"),Object(d["a"])(v,r,s,!1,null,null,null)),_=g.exports,b=a("8c4f"),w=function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("main",{staticClass:"home"},[n("div",{staticClass:"cm mcm"},[n("section",{staticClass:"last_project"},[n("div",{staticClass:"hidden"},[n("h2",[t._v(t._s(t.lastProject.title))]),n("p",[t._v(t._s(t.created))]),n("p",[t._v("Banner: "+t._s(t.lastProject.bannerPhotoPath))]),n("router-link",{attrs:{to:{name:"project",params:{id:t.lastProject.id}}}},[t._v("Project link")])],1),n("figure",{staticClass:"lp_i"},[n("router-link",{attrs:{to:{name:"project",params:{id:t.lastProject.id}}}},[n("img",{attrs:{src:a("70ff")}}),n("span",{staticClass:"bordered"},[t._v(t._s(t.lastProject.title))])])],1),n("router-link",{staticClass:"lp_l",attrs:{to:{name:"project",params:{id:t.lastProject.id}}}},[n("label",{staticClass:"minapper"},[t._v("Featuring"),n("br"),t._v("perfomance")]),n("span",{staticClass:"title"},[t._v(t._s(t.lastProject.title))]),n("span",{staticClass:"year"},[t._v(t._s(t.created))])])],1)]),n("hr"),t._m(0),t._m(1),t._m(2)])},j=[function(){var t=this,e=t.$createElement,a=t._self._c||e;return a("div",{staticClass:"cm"},[a("section",{staticClass:"if_only"},[a("div",{staticClass:"title"},[a("label",{staticClass:"minapper"},[t._v("Once two creative non conformist minds"),a("br"),t._v("made a small wish to the universe:")]),a("h2",[t._v("If only global web became a cozy place for doing business…")])]),a("div",{staticClass:"p"},[a("p",[t._v("As a first step in this story we are looking for clients adherent to values of maximum trust and close collaboration. Who are brave enough to counter & approve unconventional solutions.")]),a("p",[t._v("Who are ready to show the world their business distinctive attributes. Who are strangers to “purchaser-executor” paradigm but rather cherish human “partner-to-partner” relations.")]),a("p",[t._v("That’s what we call Harmony in the making. That’s how great projects are born. And how we will make our wish come true.")])])])])},function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("section",{staticClass:"creative_faces"},[n("img",{attrs:{src:a("7ee4")}}),n("span",{staticClass:"bordered"},[t._v("Creative faces")])])},function(){var t=this,e=t.$createElement,n=t._self._c||e;return n("div",{staticClass:"cm"},[n("section",{staticClass:"directions"},[n("div",{staticClass:"title"},[n("h2",[t._v("Directions")]),n("span",[t._v("Good design sells well ©")])]),n("div",{staticClass:"p"},[n("div",{staticClass:"p_design"},[n("img",{attrs:{src:a("d128")}}),n("h6",[t._v("Digital design")]),n("p",[t._v("Concept creation, research, design, and much more to shape your brand image in web.")])]),n("div",{staticClass:"p_consult"},[n("img",{attrs:{src:a("c536")}}),n("h6",[t._v("Digital consulting")]),n("p",[t._v("We strategize businesses all for the love of clients and their best online experience.")])]),n("div",{staticClass:"p_logo"},[n("img",{attrs:{src:a("f10b")}}),n("h6",[t._v("Logo creation")]),n("p",[t._v("We create mighty visual messages to reveal your business identity and help people fall in love with your brand.")])])])])])}],C=a("1315"),y={name:"Home",computed:Object(c["a"])({created:function(){return this.lastProject.createdOn?C["DateTime"].fromISO(this.lastProject.createdOn).toLocaleString({year:"numeric"}):""}},Object(l["c"])({lastProject:"last"})),methods:Object(c["a"])({},Object(l["b"])({load:"last"})),beforeRouteEnter:function(t,e,a){a(function(t){t.load()})}},k=y,P=Object(d["a"])(k,w,j,!1,null,"e6c77396",null),O=P.exports;n["a"].use(b["a"]);var x=new b["a"]({mode:"history",base:"/",routes:[{path:"/",name:"home",component:O},{path:"/performance",name:"performance",component:function(){return a.e("performance").then(a.bind(null,"190d"))}},{path:"/project/:id",name:"project",component:function(){return a.e("project").then(a.bind(null,"1766"))}},{path:"/contact",name:"contact",component:function(){return a.e("contact").then(a.bind(null,"371a"))}},{path:"/faces",name:"faces",component:function(){return a.e("faces").then(a.bind(null,"1ca5"))}},{path:"/journal",name:"journal",component:function(){return a.e("journal").then(a.bind(null,"f1c7"))}},{path:"/article/:id",name:"article",component:function(){return a.e("singlearticle").then(a.bind(null,"3e3e"))}},{path:"*",redirect:"/"}]}),R=a("365c");n["a"].use(l["a"]);var T=new l["a"].Store({strict:!1,state:{loading:!1,projects:{},project:{nextProjectId:null,previousProjectId:null,project:{id:null,title:"",description:"",projectLink:"",videoLink:null,behanceLink:"",bannerPhotoPath:"",previewPhotoPath:"",releaseYear:"",createdOn:"",isDisabled:!1,sOrder:null}},last:{},articles:{},article:{}},mutations:{loading:function(t,e){t.loading=e},projects:function(t,e){t.projects=e},project:function(t,e){t.project=e},last:function(t,e){t.last=e},articles:function(t,e){t.articles=e},article:function(t,e){t.article=e}},getters:{loading:function(t){return t.loading},projects:function(t){return t.projects},project:function(t){return t.project},last:function(t){return t.last},articles:function(t){return t.articles},article:function(t){return t.article}},actions:{projects:function(t){var e=t.commit;e("loading",!0),R["a"].getProjects().then(function(t){e("projects",t),e("loading",!1)})},project:function(t,e){var a=t.commit;a("loading",!0),R["a"].getProject(e).then(function(t){a("project",t),a("loading",!1)})},last:function(t){var e=t.commit;e("loading",!0),R["a"].getLastProject().then(function(t){e("last",t),e("loading",!1)})},articles:function(t){var e=t.commit;e("loading",!0),R["a"].getArticles().then(function(t){e("articles",t),e("loading",!1)})},article:function(t,e){var a=t.commit;a("loading",!0),R["a"].getArticle(e).then(function(t){a("article",t),a("loading",!1)})}}});n["a"].config.productionTip=!1,new n["a"]({store:T,router:x,render:function(t){return t(_)}}).$mount("#app")},"5c0b":function(t,e,a){"use strict";var n=a("5e27"),r=a.n(n);r.a},"5e27":function(t,e,a){},6552:function(t,e,a){t.exports=a.p+"img/logo.95af0208.svg"},"70ff":function(t,e,a){t.exports=a.p+"img/last_project.20d43652.png"},"7ee4":function(t,e,a){t.exports=a.p+"img/home_faces.607d30ab.jpg"},c536:function(t,e,a){t.exports=a.p+"img/consult_icon.b9fa0ec5.svg"},c96c:function(t,e,a){t.exports=a.p+"img/awwwards.163dc116.svg"},d128:function(t,e,a){t.exports=a.p+"img/design_icon.985414ae.svg"},f10b:function(t,e,a){t.exports=a.p+"img/logo_icon.8c512904.svg"}});
//# sourceMappingURL=app.5bb3cf98.js.map