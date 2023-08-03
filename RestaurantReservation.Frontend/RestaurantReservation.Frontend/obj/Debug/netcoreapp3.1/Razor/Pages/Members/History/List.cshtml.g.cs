#pragma checksum "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d4447ca530accec23c78f8ec81932893176db2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RestaurantReservation.Frontend.Pages.Members.History.Pages_Members_History_List), @"mvc.1.0.razor-page", @"/Pages/Members/History/List.cshtml")]
namespace RestaurantReservation.Frontend.Pages.Members.History
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
#line 1 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\_ViewImports.cshtml"
using RestaurantReservation.Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
using RestaurantReservation.Core.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d4447ca530accec23c78f8ec81932893176db2a", @"/Pages/Members/History/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4a7de8ba1ec93f43ed197b2782228620bd7ec22", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Members_History_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Members/History/List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
  
    ViewData["Title"] = "Booking History List";

    var status = HttpContext.Request.Query["status"];

    var all = "text-dark";
    var expired = "text-dark";
    var pending = "text-dark";
    var complete = "text-dark";

    switch (status)
    {
        case SD.BookingStatus.PENDING:
            pending = "active";
            break;
        case SD.BookingStatus.EXPIRED:
            expired = "active";
            break;
        case SD.BookingStatus.COMPLETE:
            complete = "active";
            break;
        default:
            all = "active";
            break;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"card\">\n    <div class=\"card-header\">\n        <h3 class=\"card-title\">Bookings</h3>\n    </div>\n    <div class=\"card-body p-0\">\n        <br />\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d4447ca530accec23c78f8ec81932893176db2a6031", async() => {
                WriteLiteral("\n            <div class=\"row\">\n                <div class=\"col-6\">\n                    <ul class=\"list-group list-group-horizontal-sm\" style=\"margin-left:20px;\">\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d4447ca530accec23c78f8ec81932893176db2a6483", async() => {
                    WriteLiteral("\n                            <li");
                    BeginWriteAttribute("class", " class=\"", 1183, "\"", 1221, 3);
                    WriteAttributeValue("", 1191, "list-group-item", 1191, 15, true);
                    WriteAttributeValue(" ", 1206, "rounded-0", 1207, 10, true);
#nullable restore
#line 44 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
WriteAttributeValue(" ", 1216, all, 1217, 4, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\n                                All\n                            </li>\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d4447ca530accec23c78f8ec81932893176db2a8569", async() => {
                    WriteLiteral("\n                            <li");
                    BeginWriteAttribute("class", " class=\"", 1490, "\"", 1532, 3);
                    WriteAttributeValue("", 1498, "list-group-item", 1498, 15, true);
                    WriteAttributeValue(" ", 1513, "rounded-0", 1514, 10, true);
#nullable restore
#line 49 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
WriteAttributeValue(" ", 1523, pending, 1524, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\n                                Pending\n                            </li>\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-status", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                                                                                                WriteLiteral(SD.BookingStatus.PENDING);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-status", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d4447ca530accec23c78f8ec81932893176db2a11863", async() => {
                    WriteLiteral("\n                            <li");
                    BeginWriteAttribute("class", " class=\"", 1805, "\"", 1847, 3);
                    WriteAttributeValue("", 1813, "list-group-item", 1813, 15, true);
                    WriteAttributeValue(" ", 1828, "rounded-0", 1829, 10, true);
#nullable restore
#line 54 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
WriteAttributeValue(" ", 1838, expired, 1839, 8, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\n                                Expired\n                            </li>\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-status", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                                                                                                WriteLiteral(SD.BookingStatus.EXPIRED);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-status", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d4447ca530accec23c78f8ec81932893176db2a15158", async() => {
                    WriteLiteral("\n                            <li");
                    BeginWriteAttribute("class", " class=\"", 2121, "\"", 2164, 3);
                    WriteAttributeValue("", 2129, "list-group-item", 2129, 15, true);
                    WriteAttributeValue(" ", 2144, "rounded-0", 2145, 10, true);
#nullable restore
#line 59 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
WriteAttributeValue(" ", 2154, complete, 2155, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\n                                Complete\n                            </li>\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-status", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                                                                                                WriteLiteral(SD.BookingStatus.COMPLETE);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-status", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    </ul>\n                </div>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        <hr />

        <br />
        <table class=""table table-striped projects text-center"">
            <thead>
                <tr>
                    <th style=""width: 1%"">
                        No
                    </th>
                    <th>Booking Date</th>
                    <th>Booking Number</th>
                    <th>Restaurant Name</th>
                    <th>Booking Session</th>
                    <th>Number of Person</th>
                    <th>Check In</th>
                    <th>Check Out</th>
                    <th>Status</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 88 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                 if (Model.BookingHistoryList != null)
                {
                    int count = 1;

                    var bookings = Model.BookingHistoryList.Bookings;
                    var bookingDetails = Model.BookingHistoryList.BookingDetails;

                    var allBookingDetail = bookings.Zip(bookingDetails, (b, bd) => new { Booking = b, BookingDetail = bd });   /* Iterate 2 lists together in one foreach */

                    foreach (var singleBookingDetail in allBookingDetail)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>\n                                ");
#nullable restore
#line 101 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 104 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                           Write(singleBookingDetail.Booking.BookingDate.ToString("dd/MM/yyyy hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 107 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                           Write(singleBookingDetail.Booking.BookingNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 110 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                           Write(singleBookingDetail.BookingDetail.RestaurantSchedule.Restaurant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 113 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                           Write(singleBookingDetail.BookingDetail.RestaurantSchedule.ScheduleDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 113 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                                                                                                                     Write(singleBookingDetail.BookingDetail.RestaurantSchedule.StartTime.ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 113 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                                                                                                                                                                                                            Write(singleBookingDetail.BookingDetail.RestaurantSchedule.EndTime.ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 116 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                           Write(singleBookingDetail.BookingDetail.Pax);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n");
#nullable restore
#line 119 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                                 if (singleBookingDetail.Booking.CheckIn.HasValue)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                               Write(singleBookingDetail.Booking.CheckIn?.ToString("dd/MM/yyyy hh:mm ttt"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                                                                                                          
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            WriteLiteral(" &nbsp;\n");
#nullable restore
#line 126 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\n                            <td>\n");
#nullable restore
#line 129 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                                 if (singleBookingDetail.Booking.CheckOut.HasValue)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                               Write(singleBookingDetail.Booking.CheckOut?.ToString("dd/MM/yyyy hh:mm ttt"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                                                                                                           
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            WriteLiteral(" &nbsp;\n");
#nullable restore
#line 136 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\n                            <td>\n");
#nullable restore
#line 139 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                                  
                                    switch (singleBookingDetail.Booking.BookingStatus)
                                    {
                                        case SD.BookingStatus.COMPLETE:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"badge badge-success\">Complete</span>\n");
#nullable restore
#line 144 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                                            break;
                                        case SD.BookingStatus.PENDING:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"badge badge-primary\">Pending</span>\n");
#nullable restore
#line 147 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                                            break;
                                        case SD.BookingStatus.EXPIRED:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"badge badge-danger\">Expired</span>\n");
#nullable restore
#line 150 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                                            break;
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </td>\n                        </tr>\n");
#nullable restore
#line 155 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"

                        count++;
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"bg-light\">\n                        <td colspan=\"3\">\n                            No booking history record found.\n                        </td>\n                    </tr>\n");
#nullable restore
#line 166 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Members\History\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n        <br />\n    </div>\n</div>\n\n\n");
            DefineSection("PageHeader", async() => {
                WriteLiteral("\n    <div class=\"col-sm-6\">\n        <h1 class=\"m-0\">Booking History</h1>\n    </div>\n    <div class=\"col-sm-6\">\n        <ol class=\"breadcrumb float-sm-right\">\n            <li class=\"breadcrumb-item\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d4447ca530accec23c78f8ec81932893176db2a31810", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\n            <li class=\"breadcrumb-item active\">Booking History</li>\n        </ol>\n    </div>\n");
            }
            );
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RestaurantReservation.Frontend.Pages.Members.History.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestaurantReservation.Frontend.Pages.Members.History.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RestaurantReservation.Frontend.Pages.Members.History.ListModel>)PageContext?.ViewData;
        public RestaurantReservation.Frontend.Pages.Members.History.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
