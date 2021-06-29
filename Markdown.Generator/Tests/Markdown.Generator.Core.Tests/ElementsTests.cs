using System;
using System.Reflection.Metadata.Ecma335;
using Markdown.Generator.Core.Markdown.Elements;
using Xunit;

namespace Tests.Markdown.Generator.Core.Tests
{
    public class ElementsTests
    {
        [Fact]
        public void Given_Code_When_LanguageAndCodeAsParameter_Then_ReturnMarkdownCodeMarkup()
        {
            var expected = "```csharp\nsome code\n```\n";
            var code = new Code("csharp","some code");
            var actial = code.Create();
            Assert.Equal(expected, actial);
        }
        [Fact]
        public void Given_Code_Quote_When_CodeAsParameter_Then_ReturnMarkdownCodeMarkup()
        {
            var expected = "`some code`";
            var codeQuote = new CodeQuote("some code");
            var actial = codeQuote.Create();
            Assert.Equal(expected, actial);
        }
        [Fact]
        public void Given_Header_When_Header_And_Level_AsParameter_Then_ReturnMarkdownHeaderMarkup()
        {
            var expected = "# header\n";
            var header = new Header(1, "header");
            var actial = header.Create();
            Assert.Equal(expected, actial);
        }
        [Fact]
        public void Given_Lik_When_Url_And_Title_AsParameter_Then_ReturnMarkdownLinkMarkup()
        {
            var expected = "[title](url)";
            var link = new Link("title", "url");
            var actial = link.Create();
            Assert.Equal(expected, actial);
        }
        [Fact]
        public void Given_List_When_List_AsParameter_Then_ReturnMarkdownListMarkup()
        {
            var expected = "- list\n";
            var list = new List("list");
            var actial = list.Create();
            Assert.Equal(expected, actial);
        }
        
        [Fact]
        public void Given_Image_When_Url_AsParameter_Then_ReturnMarkdownImageMarkup()
        {
            var expected = "![title](url)";
            var image = new Image("title", "url");
            var actial = image.Create();
            Assert.Equal(expected, actial);
        }
    }
}