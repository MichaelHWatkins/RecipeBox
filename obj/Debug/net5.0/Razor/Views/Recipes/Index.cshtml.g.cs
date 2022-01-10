#pragma checksum "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "923e8fe87bd22bddbd354ac1ba2ee446f7700c70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_Index), @"mvc.1.0.view", @"/Views/Recipes/Index.cshtml")]
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
#line 5 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Index.cshtml"
using RecipeBox.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"923e8fe87bd22bddbd354ac1ba2ee446f7700c70", @"/Views/Recipes/Index.cshtml")]
    public class Views_Recipes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RecipeBox.Models.Recipe>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Recipes for ");
#nullable restore
#line 8 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Index.cshtml"
           Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n");
#nullable restore
#line 10 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <ul>\n");
#nullable restore
#line 13 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Index.cshtml"
     foreach (Recipe recipe in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <li>");
#nullable restore
#line 15 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Index.cshtml"
     Write(Html.ActionLink($"{recipe.Name}", "Details", new { id = recipe.RecipeId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 16 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\n");
#nullable restore
#line 18 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No recipes have been added yet!</h3>\n");
#nullable restore
#line 22 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 24 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Index.cshtml"
Write(Html.ActionLink("Add new recipe", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<p>");
#nullable restore
#line 26 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RecipeBox.Models.Recipe>> Html { get; private set; }
    }
}
#pragma warning restore 1591
