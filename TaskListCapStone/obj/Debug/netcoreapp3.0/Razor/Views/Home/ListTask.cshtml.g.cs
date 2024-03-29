#pragma checksum "C:\Users\Prophesy\source\repos\TaskListCapStone\TaskListCapStone\Views\Home\ListTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb25c71f110604f84f97969300d1e62addf1e7d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListTask), @"mvc.1.0.view", @"/Views/Home/ListTask.cshtml")]
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
#line 1 "C:\Users\Prophesy\source\repos\TaskListCapStone\TaskListCapStone\Views\_ViewImports.cshtml"
using TaskListCapStone;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Prophesy\source\repos\TaskListCapStone\TaskListCapStone\Views\Home\ListTask.cshtml"
using TaskListCapStone.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb25c71f110604f84f97969300d1e62addf1e7d8", @"/Views/Home/ListTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d18992eb7362727dc700ac71802fadd6d9b5add1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Tasks>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Prophesy\source\repos\TaskListCapStone\TaskListCapStone\Views\Home\ListTask.cshtml"
  
    ViewData["Title"] = "ListTask";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<h1>List Task</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Task Description</th>\r\n        <th>Due Date</th>\r\n        <th>Completed</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\Prophesy\source\repos\TaskListCapStone\TaskListCapStone\Views\Home\ListTask.cshtml"
     foreach (Tasks task in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\Prophesy\source\repos\TaskListCapStone\TaskListCapStone\Views\Home\ListTask.cshtml"
           Write(task.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Prophesy\source\repos\TaskListCapStone\TaskListCapStone\Views\Home\ListTask.cshtml"
           Write(task.TaskDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Prophesy\source\repos\TaskListCapStone\TaskListCapStone\Views\Home\ListTask.cshtml"
           Write(task.DueDate.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Prophesy\source\repos\TaskListCapStone\TaskListCapStone\Views\Home\ListTask.cshtml"
           Write(task.Completed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 511, "\"", 548, 2);
            WriteAttributeValue("", 518, "../Home/UpdateTask?id=", 518, 22, true);
#nullable restore
#line 23 "C:\Users\Prophesy\source\repos\TaskListCapStone\TaskListCapStone\Views\Home\ListTask.cshtml"
WriteAttributeValue("", 540, task.Id, 540, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update Task</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 590, "\"", 627, 2);
            WriteAttributeValue("", 597, "../Home/DeleteTask?id=", 597, 22, true);
#nullable restore
#line 24 "C:\Users\Prophesy\source\repos\TaskListCapStone\TaskListCapStone\Views\Home\ListTask.cshtml"
WriteAttributeValue("", 619, task.Id, 619, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete Task</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 26 "C:\Users\Prophesy\source\repos\TaskListCapStone\TaskListCapStone\Views\Home\ListTask.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"../Home/FilterListByCompletion\">Filter List By Completed</a> <br />\r\n<a href=\"../Home/FilterListByInCompletion\">Filter List By Incompleted</a>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Tasks>> Html { get; private set; }
    }
}
#pragma warning restore 1591
