#pragma checksum "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/AddTag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9cfbcc11f548b81ff29f846679237a095586bc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_AddTag), @"mvc.1.0.view", @"/Views/Recipes/AddTag.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9cfbcc11f548b81ff29f846679237a095586bc2", @"/Views/Recipes/AddTag.cshtml")]
    public class Views_Recipes_AddTag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/AddTag.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Add a Tag</h2>\n\n<h4>Add a Tag to this recipe: ");
#nullable restore
#line 9 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/AddTag.cshtml"
                         Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 11 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/AddTag.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/AddTag.cshtml"
Write(Html.HiddenFor(model => model.RecipeId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/AddTag.cshtml"
Write(Html.Label("Select Tag"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/AddTag.cshtml"
Write(Html.DropDownList("TagId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\n");
#nullable restore
#line 19 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/AddTag.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 21 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/AddTag.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBox.Models.Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
