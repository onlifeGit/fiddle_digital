(window["webpackJsonp"]=window["webpackJsonp"]||[]).push([["contact"],{"371a":function(e,s,a){"use strict";a.r(s);var t=function(){var e=this,s=e.$createElement,a=e._self._c||s;return a("main",{staticClass:"contact"},[a("div",{staticClass:"cm mcm"},[a("section",{staticClass:"form_section"},[e._m(0),a("form",{staticClass:"request_form",on:{submit:e.send}},[a("div",{staticClass:"row"},[e.nameErrors?a("div",{staticClass:"field name"},[e._m(1),a("input",{directives:[{name:"model",rawName:"v-model",value:e.name,expression:"name"}],attrs:{id:"name",type:"text",name:"name",placeholder:"¿"},domProps:{value:e.name},on:{keyup:e.checkName,input:function(s){s.target.composing||(e.name=s.target.value)}}}),a("transition",{attrs:{name:"error_transition"}},e._l(e.nameErrors,function(s){return a("div",{key:s,staticClass:"form-control"},[e._v(e._s(s)+"  ←")])}),0)],1):e._e(),e.emailErrors?a("div",{staticClass:"field email"},[e._m(2),a("input",{directives:[{name:"model",rawName:"v-model",value:e.email,expression:"email"}],attrs:{id:"email",name:"email",placeholder:"@"},domProps:{value:e.email},on:{keyup:e.checkEmail,input:function(s){s.target.composing||(e.email=s.target.value)}}}),a("transition",{attrs:{name:"error_transition"}},e._l(e.emailErrors,function(s){return a("div",{key:s,staticClass:"form-control"},[e._v(e._s(s)+"  ←")])}),0)],1):e._e(),a("div",{staticClass:"field phone"},[a("label",{attrs:{for:"phone"}},[e._v("Phone")]),a("input",{directives:[{name:"model",rawName:"v-model",value:e.phone,expression:"phone"}],attrs:{id:"phone",type:"tel",name:"phone",placeholder:"+"},domProps:{value:e.phone},on:{input:function(s){s.target.composing||(e.phone=s.target.value)}}})])]),a("div",{staticClass:"row"},[e.messageErrors?a("div",{staticClass:"field message"},[e._m(3),a("input",{directives:[{name:"model",rawName:"v-model",value:e.message,expression:"message"}],attrs:{id:"message",type:"text",name:"message",placeholder:"I need a site, logo etc."},domProps:{value:e.message},on:{keyup:e.checkMessage,input:function(s){s.target.composing||(e.message=s.target.value)}}}),a("transition",{attrs:{name:"error_transition"}},e._l(e.messageErrors,function(s){return a("div",{key:s,staticClass:"form-control"},[e._v(e._s(s)+"  ←")])}),0)],1):e._e()]),a("div",{staticClass:"row"},[a("button",{class:[e.name&&e.email&&e.message?e.disClass:"disable"],attrs:{type:"submit"}},[a("span",[e._v("Send message")])])])])])])])},r=[function(){var e=this,s=e.$createElement,a=e._self._c||s;return a("div",{staticClass:"page_title"},[a("h1",[e._v("Contact")])])},function(){var e=this,s=e.$createElement,a=e._self._c||s;return a("label",{attrs:{for:"name"}},[e._v("Name "),a("span",{staticClass:"required"},[e._v("Required")])])},function(){var e=this,s=e.$createElement,a=e._self._c||s;return a("label",{attrs:{for:"email"}},[e._v("Email "),a("span",{staticClass:"required"},[e._v("Required")])])},function(){var e=this,s=e.$createElement,a=e._self._c||s;return a("label",{attrs:{for:"message"}},[e._v("Message "),a("span",{staticClass:"required"},[e._v("Required")])])}],i=(a("7f7f"),a("cadf"),a("551c"),a("f751"),a("097d"),a("365c")),n={name:"contact",data:function(){return{name:"",phone:"",email:"",message:"",nameErrors:[],emailErrors:[],messageErrors:[],disClass:""}},methods:{send:function(e){if(e.preventDefault(),this.nameErrors=[],this.emailErrors=[],this.messageErrors=[],this.name||this.nameErrors.push("How can we call you?"),this.email?this.validEmail(this.email)||this.emailErrors.push("Seems like something is wrong."):this.emailErrors.push("We need to know how to contact you."),this.message||this.messageErrors.push("How can we help you?"),!this.nameErrors.length&&!this.emailErrors.length&&!this.messageErrors.length)return!0;i["a"].sendFeedback({name:this.name,phone:this.phone,email:this.email,message:this.message}).then(function(e){}).catch(function(e){})},validEmail:function(e){var s=/^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;return s.test(e)},checkName:function(){this.nameErrors&&(this.nameErrors=[])},checkEmail:function(){this.emailErrors&&(this.emailErrors=[])},checkMessage:function(){this.messageErrors&&(this.messageErrors=[])}},mounted:function(){}},o=n,m=a("2877"),l=Object(m["a"])(o,t,r,!1,null,"ad060618",null);s["default"]=l.exports}}]);
//# sourceMappingURL=contact.40447e3e.js.map