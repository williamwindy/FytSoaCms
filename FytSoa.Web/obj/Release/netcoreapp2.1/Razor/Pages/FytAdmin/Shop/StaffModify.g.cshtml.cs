#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\StaffModify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbfe9918011205ad359abe9c445638464dd90e3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Shop.Pages_FytAdmin_Shop_StaffModify), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Shop/StaffModify.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Shop/StaffModify.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Shop.Pages_FytAdmin_Shop_StaffModify), null)]
namespace FytSoa.Web.Pages.FytAdmin.Shop
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbfe9918011205ad359abe9c445638464dd90e3a", @"/Pages/FytAdmin/Shop/StaffModify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Shop_StaffModify : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form form-cus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\StaffModify.cshtml"
  
    ViewData["Title"] = "加盟商管理-添加员工";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(158, 2778, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40bb81eed32e4731a7bb62384e968fb9", async() => {
                BeginContext(202, 179, true);
                WriteLiteral("\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">登录账号</label>\r\n        <div class=\"layui-input-block\">\r\n            <input type=\"text\" name=\"LoginName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 381, "\"", 416, 1);
#line 11 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\StaffModify.cshtml"
WriteAttributeValue("", 389, Model.staffModel.LoginName, 389, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(417, 313, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请输入登录账号"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">登录密码</label>
        <div class=""layui-input-block"">
            <input type=""password"" name=""LoginPwd""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 730, "\"", 764, 1);
#line 17 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\StaffModify.cshtml"
WriteAttributeValue("", 738, Model.staffModel.LoginPwd, 738, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(765, 309, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请输入登录密码"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">真实姓名</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""TrueName""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1074, "\"", 1108, 1);
#line 23 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\StaffModify.cshtml"
WriteAttributeValue("", 1082, Model.staffModel.TrueName, 1082, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1109, 309, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请输入真实姓名"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">手机号码</label>
        <div class=""layui-input-block"">
            <input type=""number"" name=""Mobile""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1418, "\"", 1450, 1);
#line 29 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\StaffModify.cshtml"
WriteAttributeValue("", 1426, Model.staffModel.Mobile, 1426, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1451, 324, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请输入手机号码"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">性别</label>
        <div class=""layui-input-block"">
            <input type=""radio"" name=""Sex"" value=""男"" title=""男"" ");
                EndContext();
                BeginContext(1777, 44, false);
#line 35 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\StaffModify.cshtml"
                                                           Write(Model.staffModel.Sex == "男" ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(1822, 66, true);
                WriteLiteral(">\r\n            <input type=\"radio\" name=\"Sex\" value=\"女\" title=\"女\" ");
                EndContext();
                BeginContext(1890, 44, false);
#line 36 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\StaffModify.cshtml"
                                                           Write(Model.staffModel.Sex == "女" ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(1935, 226, true);
                WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">状态</label>\r\n        <div class=\"layui-input-block\">\r\n            <input type=\"radio\" name=\"Status\" value=\"0\" title=\"正常\" ");
                EndContext();
                BeginContext(2163, 45, false);
#line 42 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\StaffModify.cshtml"
                                                               Write(Model.staffModel.Status == 0 ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(2209, 72, true);
                WriteLiteral(">\r\n            <input type=\"radio\" name=\"Status\" value=\"1\" title=\"账号冻结\" ");
                EndContext();
                BeginContext(2283, 45, false);
#line 43 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\StaffModify.cshtml"
                                                                 Write(Model.staffModel.Status == 1 ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(2329, 70, true);
                WriteLiteral(">\r\n            <input type=\"radio\" name=\"Status\" value=\"2\" title=\"离职\" ");
                EndContext();
                BeginContext(2401, 45, false);
#line 44 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\StaffModify.cshtml"
                                                               Write(Model.staffModel.Status == 2 ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(2447, 366, true);
                WriteLiteral(@">
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-input-block"">
            <button class=""layui-btn"" lay-submit="""" lay-filter=""submit"">立即提交</button>
            <button type=""button"" class=""layui-btn layui-btn-primary btn-open-close"">取消</button>
        </div>
    </div>
    <input type=""hidden"" name=""Guid"" id=""Guid""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2813, "\"", 2843, 1);
#line 53 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\StaffModify.cshtml"
WriteAttributeValue("", 2821, Model.staffModel.Guid, 2821, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2844, 45, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"ShopGuid\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2889, "\"", 2923, 1);
#line 54 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Shop\StaffModify.cshtml"
WriteAttributeValue("", 2897, Model.staffModel.ShopGuid, 2897, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2924, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2936, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2955, 1003, true);
                WriteLiteral(@"
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).use(['layer', 'jquery', 'common', 'form'], function () {
            var form = layui.form, $ = layui.$, os = layui.common;
            var index = parent.layer.getFrameIndex(window.name);
            //监听提交
            form.on('submit(submit)', function (data) {
                var urls = ""api/shops/addstaff"";
                if ($(""#Guid"").val()) {
                    urls = ""api/shops/editstaff"";
                }
                os.ajax(urls, data.field, function(res) {
                    if (res.statusCode === 200) {
                        parent.layer.close(index);
                    } else {
                        os.error(res.message);
                    }
                });
                return false;
            });
            $("".btn-open-close"").on('click', function () {
                parent.layer.close(index);
            });
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(3961, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Shop.StaffModifyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Shop.StaffModifyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Shop.StaffModifyModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Shop.StaffModifyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
