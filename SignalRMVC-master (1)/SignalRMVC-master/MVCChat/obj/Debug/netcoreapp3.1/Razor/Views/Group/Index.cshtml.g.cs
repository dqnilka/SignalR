#pragma checksum "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\Group\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "762fb76ac4c1a11cffe52ce06e84963761ee7aec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Group_Index), @"mvc.1.0.view", @"/Views/Group/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\_ViewImports.cshtml"
using MVCChat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\_ViewImports.cshtml"
using MVCChat.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\Group\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"762fb76ac4c1a11cffe52ce06e84963761ee7aec", @"/Views/Group/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80e3a6956f1aec49cc22981d28d2a88cd7dfa404", @"/Views/_ViewImports.cshtml")]
    public class Views_Group_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserInGroups>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Group", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Ban", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/microsoft/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\Group\Index.cshtml"
  
    var users = Model.Users;
    var group = Model.Group;


#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "762fb76ac4c1a11cffe52ce06e84963761ee7aec5008", async() => {
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <title>");
#nullable restore
#line 11 "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\Group\Index.cshtml"
      Write(group.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "762fb76ac4c1a11cffe52ce06e84963761ee7aec6264", async() => {
                WriteLiteral(@"

<h1 align=""center""> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Добро пожаловать в ");
#nullable restore
#line 16 "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\Group\Index.cshtml"
                                                                                                                                                                                                                                                                                  Write(group.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" !</h1>\n<div id=\"chatroom\"> \n    <div class=\"page-tape__card\">\n        <a class=\"page-tape__card-link\">\n            <div class=\"page-tape__user user-tape\" style=\"text-align:left;\">\n");
#nullable restore
#line 21 "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\Group\Index.cshtml"
             foreach (var i in users)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\Group\Index.cshtml"
                 if (User.Claims.SingleOrDefault(p => p.Type == ClaimTypes.NameIdentifier)?.Value == group.AdminId.ToString() && i.Id != group.AdminId)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"user-tape__name\" style=\"text-align:left; color:firebrick;\">");
#nullable restore
#line 25 "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\Group\Index.cshtml"
                                                                                      Write(i.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div> \n");
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "762fb76ac4c1a11cffe52ce06e84963761ee7aec8618", async() => {
                    WriteLiteral(" (Ban)\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-groupId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\Group\Index.cshtml"
                             WriteLiteral(group.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["groupId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-groupId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["groupId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\Group\Index.cshtml"
                            WriteLiteral(i.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 32 "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\Group\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"user-tape__status\">\n                        <span>Online</span>\n                    </div>\n                    <div style=\"text-align:left; color:firebrick;\">");
#nullable restore
#line 38 "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\Group\Index.cshtml"
                                                              Write(i.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n");
#nullable restore
#line 39 "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\Group\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\Group\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </div></a>
    </div>
</div>

<div>
    <div class=""mb-3"">
        <textarea class=""form-control"" name=""message"" id=""message"" placeholder=""Enter your message"" rows=""3""></textarea>
    </div>
    <input type=""submit"" id=""sendBtn"" value=""Send Message"">
</div>
");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "762fb76ac4c1a11cffe52ce06e84963761ee7aec13358", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n<script>\nconst hubConnection = new signalR.HubConnectionBuilder()\n            .withUrl(\"/chat\")\n            .build();\n\n        let userName = \"");
#nullable restore
#line 57 "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\Group\Index.cshtml"
                   Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
        // получение сообщения от сервера
        hubConnection.on('Push', function (userName, message) {
            var div = document.createElement(""div"");
            div.id =""page-tape__card""
            // создаем элемент <b> для имени пользователя
            div.innerHTML = ""  <a class=\""page - tape__card - link\""> < div class=\""page-tape__user user-tape\"" > <div class=\""user-tape__name\""> Name</div>""
            let userNameElem = document.createElement(""b"");
            userNameElem.appendChild(document.createTextNode(userName + ': '));

            // создает элемент <p> для сообщения пользователя
            let elem = document.createElement(""p"");
            elem.appendChild(userNameElem);
            elem.appendChild(document.createTextNode(message));

            document.getElementById(""chatroom"").appendChild(elem);

        });



        // отправка сообщения на сервер
        document.getElementById(""sendBtn"").addEventListener(""click"", function (e) {
            let message = document.ge");
                WriteLiteral("tElementById(\"message\").value;\n            document.getElementById(\"message\").value = \"\";\n            hubConnection.invoke(\"Send\", userName, message, \"");
#nullable restore
#line 82 "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\Group\Index.cshtml"
                                                        Write(group.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\n        });\n\n        async function SetUp(){\n            await hubConnection.start();\n            await hubConnection.invoke(\"Enter\", \"");
#nullable restore
#line 87 "C:\Users\Danila\Downloads\SignalRMVC-master (1)\SignalRMVC-master\MVCChat\Views\Group\Index.cshtml"
                                            Write(group.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\n        }\n        SetUp();\n\n    </script>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserInGroups> Html { get; private set; }
    }
}
#pragma warning restore 1591
