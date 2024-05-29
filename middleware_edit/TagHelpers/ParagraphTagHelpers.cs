using Microsoft.AspNetCore.Razor.TagHelpers;

namespace middleware_edit.TagHelpers
{
    [HtmlTargetElement("paragraph")]

    public class ParagraphTagHelpers : TagHelper
    {
        public string ShortDescription { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

            output.Content.SetHtmlContent($"<b>Custom Tag Helper is working, param is {ShortDescription}</b>");
            base.Process(context, output);
        }
    }
}
