#pragma checksum "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Shared\Components\ReservationCount\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bae880ffaa82580681dd79a5e9739cd3d0e2c0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RestaurantReservation.Frontend.Pages.Shared.Components.ReservationCount.Pages_Shared_Components_ReservationCount_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/ReservationCount/Default.cshtml")]
namespace RestaurantReservation.Frontend.Pages.Shared.Components.ReservationCount
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bae880ffaa82580681dd79a5e9739cd3d0e2c0c", @"/Pages/Shared/Components/ReservationCount/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4a7de8ba1ec93f43ed197b2782228620bd7ec22", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_ReservationCount_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Shared\Components\ReservationCount\Default.cshtml"
 if (Model == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input hidden=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 58, "\"", 72, 1);
#nullable restore
#line 6 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Shared\Components\ReservationCount\Default.cshtml"
WriteAttributeValue("", 66, Model, 66, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 7 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Shared\Components\ReservationCount\Default.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"border-radius:50%;background:red;color:white;padding: 5px 10px;\">");
#nullable restore
#line 10 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Shared\Components\ReservationCount\Default.cshtml"
                                                                             Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 11 "C:\Users\RADURGA\source\repos\Restaurant-Reservation-Website-master\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Shared\Components\ReservationCount\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
