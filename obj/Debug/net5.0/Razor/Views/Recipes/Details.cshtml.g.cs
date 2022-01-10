#pragma checksum "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c74c57c8020419091bad3e945fa260e57c53f1d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipes_Details), @"mvc.1.0.view", @"/Views/Recipes/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c74c57c8020419091bad3e945fa260e57c53f1d9", @"/Views/Recipes/Details.cshtml")]
    public class Views_Recipes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBox.Models.Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Recipe Details</h2>\n<hr />\n<h3>");
#nullable restore
#line 9 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n");
#nullable restore
#line 11 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Details.cshtml"
 if(@Model.JoinEntities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>This recipe does not have any tags</p>\n");
#nullable restore
#line 14 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>Tags the recipe belongs to:</h4>\n  <ul>\n");
#nullable restore
#line 19 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Details.cshtml"
   foreach(var join in Model.JoinEntities)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 21 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Details.cshtml"
   Write(join.Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 22 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Details.cshtml"
     using (Html.BeginForm("DeleteTag", "Recipes"))
    {
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Details.cshtml"
 Write(Html.Hidden("joinId", @join.RecipeTagId));

#line default
#line hidden
#nullable disable
            WriteLiteral("      <input type=\"submit\" value=\"Delete\"/>\n");
#nullable restore
#line 26 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Details.cshtml"
     
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\n");
#nullable restore
#line 29 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 31 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Details.cshtml"
Write(Html.ActionLink("Add a Tag", "AddTag", new { id = Model.RecipeId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<p>");
#nullable restore
#line 33 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 34 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Details.cshtml"
Write(Html.ActionLink("Edit Recipe", "Edit", new { id = Model.RecipeId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 35 "/Users/michaelwatkins1/Desktop/RecipeBox.Solution/RecipeBox/Views/Recipes/Details.cshtml"
Write(Html.ActionLink("Delete Recipe", "Delete", new { id = Model.RecipeId }));

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
