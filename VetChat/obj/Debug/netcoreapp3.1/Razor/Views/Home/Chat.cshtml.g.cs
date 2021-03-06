#pragma checksum "C:\Users\flora\OneDrive\Documents\GitHub\VetChat\VetChat\Views\Home\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3affa0e5bebcbdddafc477fa78731b2f779218ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Chat), @"mvc.1.0.razor-page", @"/Views/Home/Chat.cshtml")]
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
#line 1 "C:\Users\flora\OneDrive\Documents\GitHub\VetChat\VetChat\Views\_ViewImports.cshtml"
using VetChat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\flora\OneDrive\Documents\GitHub\VetChat\VetChat\Views\_ViewImports.cshtml"
using VetChat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3affa0e5bebcbdddafc477fa78731b2f779218ad", @"/Views/Home/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"353f6663b5cde766e2e243a004aaa4b991eef9e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Chat : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dataEntry"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\flora\OneDrive\Documents\GitHub\VetChat\VetChat\Views\Home\Chat.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"" style="" background: rgba(0, 0, 0, 0.4);"">
    <div class=""page-header"">
        <h2 class=""text-center"" id=""chats"">Chat</h2>
    </div>
    <div class=""row display fill"" id=""displayMessage"">
        <div class=""col-sm-10 fill"" id=""chatRoom"">
            <p id=""noMessages"">No messages yet</p>
        </div>
        <div class=""col-sm-2 fill"" style=""border-left: 1px solid #000"" id=""members"">
            <div class=""page-header"">
                <h4 class=""text-center"" id=""mems"">Members</h4>
            </div>
        </div>
    </div>

    <div class=""row"" id=""entry"">
        <div class=""col-md-12"" id=""dataEntry"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3affa0e5bebcbdddafc477fa78731b2f779218ad4830", async() => {
                WriteLiteral(@"
                <input type=""text"" class=""form-control form-control-static text-white"" id=""name"" placeholder=""Name"" />
                <input type=""text"" class=""form-control text-white"" style=""width: 400px; height:100px;"" id=""chatMessage"" placeholder=""Chat Message"" />
                <button type=""button"" class=""btn btn-primary"" id=""sendMessage"">Send <i class=""fa fa-paper-plane"" aria-hidden=""true""></i></button>
            ");
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script src=""/lib/microsoft/signalr/dist/browser/signalr.js""></script>
    <script type=""text/javascript"">
        (function () {

            var theHub;
            const chatRoom = document.getElementById(""chatRoom"");
            const members = document.getElementById(""members"");

            OnLoad();

            function OnLoad() {

                theHub = new signalR.HubConnectionBuilder()
                    .withUrl(""/Chat"")
                    .build();

                theHub.on(""OnMessageReceived"", OnMessageReceived);
                theHub.on(""OnManageChatters"", ManageChatters);
                theHub.on(""OnConnected"", CurrentChatters);
                theHub.on(""OnPrivateMessage"", Whisper);

                theHub.start();

                document.getElementById(""sendMessage"").addEventListener(""click"", event => {

                    var name = document.getElementById(""name"").value;
                    var message = document.getElementById(""chatMessage"").valu");
                WriteLiteral(@"e;
                    SendMessage(name, message);
                    event.preventDefault();

                });

            }

            function OnMessageReceived(name, message) {

                var noMsg = document.getElementById(""noMessages"");
                if (noMsg) noMsg.remove();

                var newMsg = document.createElement(""p"");
                newMsg.innerHTML = `<b>${name}</b> - ${message}`;
                chatRoom.appendChild(newMsg);

            }

            function SendMessage(name, message) {

                theHub.invoke(""SendMessage"", name, message);

            }

            function ManageChatters(name, action) {

                if (action) {
                    var newChatter = document.createElement(""p"");
                    newChatter.id = `");
                WriteLiteral("@${name}`;\r\n                    newChatter.textContent = name;\r\n                    members.appendChild(newChatter);\r\n                } else {\r\n                    document.getElementById(`");
                WriteLiteral(@"@${name}`).remove();
                }

            }

            function CurrentChatters(chatters) {

                console.log(chatters);

                for (var i = 0; i < chatters.length; i++) {
                    var newChatter = document.createElement(""p"");
                    newChatter.id = `");
                WriteLiteral(@"@${chatters[i]}`;
                    newChatter.textContent = chatters[i];
                    members.appendChild(newChatter);
                }

            }

            function Whisper(name, message) {

                var noMsg = document.getElementById(""noMessages"");
                if (noMsg) noMsg.remove();

                var newMsg = document.createElement(""p"");
                newMsg.innerHTML = `<i>PRIVATE: <b>${name}</b> - ${message}</i>`;
                chatRoom.appendChild(newMsg);

            }

        })();
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Views_Home_Chat> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Home_Chat> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Views_Home_Chat>)PageContext?.ViewData;
        public Views_Home_Chat Model => ViewData.Model;
    }
}
#pragma warning restore 1591
