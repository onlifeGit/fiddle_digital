(window["webpackJsonp"]=window["webpackJsonp"]||[]).push([["singlearticle"],{"3e3e":function(e,t,a){"use strict";a.r(t);var c=function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("main",{staticClass:"j_one"},[a("div",{staticClass:"cm"},[a("section",[a("h2",[e._v(e._s(e.article.title))]),a("p",{domProps:{innerHTML:e._s(e.article.body)}})])])])},i=[],n=a("cebc"),r=a("1315"),o=a("2f62"),l={name:"singlearticle",computed:Object(n["a"])({created:function(){return this.article.createdOn?r["DateTime"].fromISO(this.article.createdOn).toLocaleString({weekday:"long",month:"long",day:"2-digit",year:"numeric"}):""}},Object(o["c"])({article:"article"})),methods:Object(n["a"])({},Object(o["b"])({load:"article"})),beforeRouteEnter:function(e,t,a){a(function(e){e.load(e.$route.params.id)})}},s=l,d=a("2877"),u=Object(d["a"])(s,c,i,!1,null,"d00381a6",null);t["default"]=u.exports}}]);
//# sourceMappingURL=singlearticle.6875f133.js.map