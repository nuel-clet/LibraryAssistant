#pragma checksum "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e7cc02e2d4a9ce5da72f25565fc724b62f691c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
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
#line 1 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\_ViewImports.cshtml"
using LibraryAssistant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\_ViewImports.cshtml"
using LibraryAssistant.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\_ViewImports.cshtml"
using LibraryAssistant.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e7cc02e2d4a9ce5da72f25565fc724b62f691c3", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c08a658a27dbd473493930d165b488d564b890e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary mt-1 mr-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary mt-1 mx-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"
  
    ViewBag.Title = "Book List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row g-4 mb-4\">\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"
     foreach (var book in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-6 col-lg-3"">
            <div class=""card bg-light border-primary mb-3"">
                <div class=""card-body text-center my-4"">


                    <ul class=""list-group list-group-flush"">
                        <li class=""card-header"">");
#nullable restore
#line 20 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"
                                           Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li class=\"list-group-item\">ISBN: ");
#nullable restore
#line 21 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"
                                                     Write(book.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li class=\"list-group-item\">PUBLISH YEAR: ");
#nullable restore
#line 22 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"
                                                             Write(book.PublishYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li class=\"list-group-item\">COVER PRICE: ");
#nullable restore
#line 23 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"
                                                            Write(book.CoverPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li class=\"list-group-item\">AVAILABILITY: ");
#nullable restore
#line 24 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"
                                                             Write(book.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n\r\n                    </ul>\r\n                    <div class=\"btn-toolbar\">\r\n\r\n                        <div class=\"btn-group \">\r\n");
#nullable restore
#line 30 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"
                             if (book.Status == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a disabled class=\"btn btn-secondary mt-1 mr-1\">\r\n                                    Check-In\r\n                                </a>\r\n");
#nullable restore
#line 35 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e7cc02e2d4a9ce5da72f25565fc724b62f691c38370", async() => {
                WriteLiteral("\r\n                                    Check-In\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"
                                                          WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"btn-group \">\r\n");
#nullable restore
#line 47 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"
                             if (book.Status != true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a disabled class=\"btn btn-secondary mt-1 mx-auto\">\r\n                                    Check-Out\r\n                                </a>\r\n");
#nullable restore
#line 52 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e7cc02e2d4a9ce5da72f25565fc724b62f691c312020", async() => {
                WriteLiteral("\r\n                                    Check-Out\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"
                                                           WriteLiteral(book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>

                        <div class=""btn-group"">
                            <input id=""details-btn"" type=""button"" class=""btn btn-info mt-1 ml-1"" data-toggle=""modal"" data-target=""#details""
                                   data-id=""");
#nullable restore
#line 65 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"
                                       Write(book.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2559, "\"", 2589, 3);
            WriteAttributeValue("", 2569, "getDetails(", 2569, 11, true);
#nullable restore
#line 65 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"
WriteAttributeValue("", 2580, book.Id, 2580, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2588, ")", 2588, 1, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                               value=\"Details\" \r\n                            />\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 75 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"


        //MODAL

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""modal fade"" id=""details"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h5 class=""modal-title"" id=""details"">Details</h5>
                       
                    </div>
                    <div class=""modal-body"">
                        
                        <div class=""card-header"">
                            <h4>Title: <span id=""detailsTitle""></span></h4>
                        </div>

                        <div class=""card-body"">
                            <h5>ISBN: <span id=""detailsISBN""></span></h5>
                            <h5>PublishYear: <span id=""detailsPublishYear""></span></h5>
                            <h5>CoverPrice: <span id=""detailsCoverprice""></span></h5>
                            <h5>Status: <span id=""detailsStatus""></span></h5>
    ");
            WriteLiteral(@"                        <h5><span id=""detailsPatronName""></span></h5>
                            <h5><span id=""detailsHistory""></span></h5>
                        </div>

                    </div>
                   
                </div>
            </div>
        </div>
");
#nullable restore
#line 105 "C:\Users\USER\source\repos\LibraryAssistant\LibraryAssistant\Views\Book\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">            
        function getDetails(bookId) {                    
                $.ajax({
                    url: 'Book/Details',
                    type: 'POST',
                    data: { Id: bookId },
                    dataType: ""json"",
                    success: function (response) {
                      
                        for (var i in response) {
                            if (Array.isArray(response[i])) {                                                                     
                                var detailsTitle = response.bookInventory[0].book.title;
                                var detailsISBN = response.bookInventory[0].book.isbn;
                                var detailsCoverprice = response.bookInventory[0].book.coverPrice;
                                var detailsPublishYear = response.bookInventory[0].book.publishYear;
                                var detailsStatus = ""Available"";
                      ");
                WriteLiteral(@"          var patronName = """";                                
                                $('#detailsHistory').innerHTML = ('History; <br>');

                                for (var item of response.bookInventory) {
                                    if (item.isCheckedIn) {
                                        //detailsStatus = 'Available';                                        
                                    }
                                    else {
                                        detailsStatus = 'Not Available';
                                        patronName = item.bookPatron.name;                                        
                                    } 
                                    
                                    //CHECK OUT HISTORY
                                    var name = item.bookPatron.name;
                                    var checkoutDate = item.checkedOutDate;
                                    var checkInDate = item.checkedInD");
                WriteLiteral(@"ate;

                                    checkoutDate = checkoutDate.substring(0, 10);                                    
                                    checkInDate = checkInDate.substring(0, 10);
                                    var format = ('Name: ' + name + '<br> Checked Out On: ' + checkoutDate + '<br>Checked In On: ' + checkInDate + '<br> <br>');
                                    document.getElementById(""detailsHistory"").innerHTML += format;
                                    format = """";

                                    $("".modal"").on(""hidden.bs.modal"", function () {
                                        document.getElementById(""detailsHistory"").innerHTML = format;
                                    });                                                           
                                }

                            }
                            
                            //SHOULD WE RECEIVE A BOOK OBJECT FROM THE CONTROLLER
                            //USE");
                WriteLiteral(@"D FOR TESTING PURPOSES
                            else {                               
                                var detailsTitle = response.book.title;
                                var detailsISBN = response.book.isbn;
                                var detailsCoverprice = response.book.coverPrice;
                                var detailsPublishYear = response.book.publishYear;
                                var detailsStatus;
                                if (response.book.status) {
                                    detailsStatus = 'Available';
                                }
                                else {
                                    detailsStatus = 'Not Available';
                                }                                  
                            }
                        }
                       //POPULATE THE DETAILS IN THE MODAL-BODY
                        $('#detailsTitle').html(detailsTitle);
                        $('#detailsISBN')");
                WriteLiteral(@".html(detailsISBN);
                        $('#detailsCoverprice').html(detailsCoverprice);
                        $('#detailsPublishYear').html(detailsPublishYear);
                        $('#detailsStatus').html(detailsStatus);  
                        $('#detailsPatronName').html('Checked Out by: ' + patronName);
                                                 
                    },                   
                    failure: function (response) {
                        console.log('this is from failure');
                        console.log(response);
                    }
                });
          };        
            
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
