#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\MenuModify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72cff9d7d1aeb5d9ba7037d43e6752c50a9da423"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Sys.Pages_FytAdmin_Sys_MenuModify), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Sys/MenuModify.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Sys/MenuModify.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Sys.Pages_FytAdmin_Sys_MenuModify), null)]
namespace FytSoa.Web.Pages.FytAdmin.Sys
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72cff9d7d1aeb5d9ba7037d43e6752c50a9da423", @"/Pages/FytAdmin/Sys/MenuModify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Sys_MenuModify : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form form-cus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/themes/ztree/css/metroStyle/metroStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\MenuModify.cshtml"
  
    ViewData["Title"] = "菜单修改";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(150, 643, true);
            WriteLiteral(@"<style>
    .organize-tree {
        position: absolute;
        background-color: #fff;
        padding: 5px 25px;
        z-index: 1000;
        box-shadow: 0 0 24px rgba(0,0,0,.18);
        opacity: 0;
        height: 0;
        display: none;
    }

        .organize-tree.active {
            display: block;
            opacity: 1;
            height: auto;
            max-height: 330px;
            overflow: auto;
            transition: all .5s;
        }

        .organize-tree .ztree li a {
            height: 22px !important;
        }
    .layui-iconpicker {
        max-width: 100%;
    }
</style>
");
            EndContext();
            BeginContext(793, 3060, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea8aa928e59543a0961d8f776b3d730d", async() => {
                BeginContext(837, 196, true);
                WriteLiteral("\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">所属父级</label>\r\n        <div class=\"layui-input-block\">\r\n            <input type=\"text\" name=\"ParentName\" id=\"ParentName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1033, "\"", 1068, 1);
#line 39 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\MenuModify.cshtml"
WriteAttributeValue("", 1041, Model.MenuModel.ParentName, 1041, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1069, 467, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请选择所属父级"" class=""layui-input"">
            <div class=""organize-tree"">
                <ul id=""tree"" class=""ztree layui-tree-cus""></ul>
            </div>
        </div>
    </div>
    <div class=""layui-form-item"">
        <label for="""" class=""layui-form-label"">选择图标</label>
        <div class=""layui-input-block"">
            <input type=""text"" id=""iconPicker"" lay-filter=""iconPicker""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1536, "\"", 1565, 1);
#line 48 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\MenuModify.cshtml"
WriteAttributeValue("", 1544, Model.MenuModel.Icon, 1544, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1566, 223, true);
                WriteLiteral(" class=\"layui-input\">\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">菜单名称</label>\r\n        <div class=\"layui-input-block\">\r\n            <input type=\"text\" name=\"Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1789, "\"", 1818, 1);
#line 54 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\MenuModify.cshtml"
WriteAttributeValue("", 1797, Model.MenuModel.Name, 1797, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1819, 309, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请输入菜单名称"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">菜单编号</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""NameCode""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2128, "\"", 2161, 1);
#line 60 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\MenuModify.cshtml"
WriteAttributeValue("", 2136, Model.MenuModel.NameCode, 2136, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2162, 306, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请输入菜单编号"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">Url地址</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""Urls""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2468, "\"", 2497, 1);
#line 66 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\MenuModify.cshtml"
WriteAttributeValue("", 2476, Model.MenuModel.Urls, 2476, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2498, 263, true);
                WriteLiteral(@" autocomplete=""off"" placeholder=""请输入Url地址"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">排序</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""Sort""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2761, "\"", 2790, 1);
#line 72 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\MenuModify.cshtml"
WriteAttributeValue("", 2769, Model.MenuModel.Sort, 2769, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2791, 359, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请输入排序"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">是否显示</label>
        <div class=""layui-input-block"">
            <input type=""checkbox"" name=""Status"" lay-skin=""switch"" lay-text=""ON|OFF"" value=""true"" ");
                EndContext();
                BeginContext(3152, 39, false);
#line 78 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\MenuModify.cshtml"
                                                                                              Write(Model.MenuModel.Status ? "checked" : "");

#line default
#line hidden
                EndContext();
                BeginContext(3192, 366, true);
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
                BeginWriteAttribute("value", " value=\"", 3558, "\"", 3587, 1);
#line 87 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\MenuModify.cshtml"
WriteAttributeValue("", 3566, Model.MenuModel.Guid, 3566, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3588, 63, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"ParentGuid\" id=\"ParentGuid\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3651, "\"", 3686, 1);
#line 88 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\MenuModify.cshtml"
WriteAttributeValue("", 3659, Model.MenuModel.ParentGuid, 3659, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3687, 51, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Icon\" id=\"Icon\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3738, "\"", 3767, 1);
#line 89 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\MenuModify.cshtml"
WriteAttributeValue("", 3746, Model.MenuModel.Icon, 3746, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3768, 42, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Layer\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3810, "\"", 3840, 1);
#line 90 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Sys\MenuModify.cshtml"
WriteAttributeValue("", 3818, Model.MenuModel.Layer, 3818, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3841, 5, true);
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
            BeginContext(3853, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3855, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4f96ba1bc0fd4cbea9633fb8d7b54b25", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3946, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3965, 2260, true);
                WriteLiteral(@"
    <script>
        layui.config({
            base: '/themes/js/modules/'
        }).extend({
            iconPicker: 'iconPicker'
        }).use(['layer', 'jquery', 'common', 'iconPicker', 'form', 'ztree'], function () {
            var form = layui.form, $ = layui.$, os = layui.common, iconPicker = layui.iconPicker;
            iconPicker.render({
                elem: '#iconPicker',
                type: 'fontClass',
                search: true,
                page: false,
                click: function (data) {
                    console.log(data);
                    $(""#Icon"").val(data.icon);
                }
            });
            var index = parent.layer.getFrameIndex(window.name);
            //监听提交
            form.on('submit(submit)', function (data) {
                var urls = ""api/menu/add"";
                if ($(""#Guid"").val()) {
                    urls = ""api/menu/edit"";
                }
                os.ajax(urls, data.field, function (res) {
       ");
                WriteLiteral(@"             if (res.statusCode === 200) {
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

            var setting = {
                async: {
                    enable: true,
                    url: ""/api/menu/gettree""
                },
                callback: {
                    onClick: onClick
                }
            };
            $(""#ParentName"").click(function () {
                $("".organize-tree"").addClass('active');
            });
            $("".organize-tree"").mouseleave(function () {
                $("".organize-tree"").removeClass('active');
            });
            $.fn.zTree.init($(""#tree""), setting);
            function onClick(event, treeId, treeNode, clickFlag) {");
                WriteLiteral("\n                $(\"#ParentGuid\").val(treeNode.guid);\r\n                $(\"#ParentName\").val(treeNode.name);\r\n                $(\".organize-tree\").removeClass(\'active\');\r\n            }\r\n        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(6228, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Sys.MenuModifyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sys.MenuModifyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Sys.MenuModifyModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Sys.MenuModifyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
