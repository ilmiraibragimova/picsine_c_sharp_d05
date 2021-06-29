using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Markdown.Generator.Core.Markdown;
using Markdown.Generator.Core.Markdown.Elements;
using Xunit;
using Xunit.Abstractions;

namespace Tests.Markdown.Generator.Core.Tests
{
    public class MarkdownBuilderTests
    {
        [Fact]
        public void Markdown_Builder_When_Code_As_Parametr()
        {
            var markdownBuilder = new MarkdownBuilder();
            Code code = new Code("csharp", "some code");
            markdownBuilder.Code("csharp", "some code");
            Console.WriteLine(markdownBuilder.Elements);
            Assert.Equal(markdownBuilder.Elements.Count(), 1);
            foreach (var element in markdownBuilder.Elements)
            {
                Assert.Equal(element.GetType(), code.GetType());
            }

        }

        [Fact]
        public void Markdown_Builder_When_List_As_Parametr()
        {
            var markdownBuilder = new MarkdownBuilder();
            var list = new List("some code");
            markdownBuilder.List("some code");
            Console.WriteLine(markdownBuilder.Elements);
            Assert.Equal(markdownBuilder.Elements.Count(), 1);
            foreach (var element in markdownBuilder.Elements)
            {
                Assert.Equal(element.GetType(), list.GetType());
            }

        }

        [Fact]
        public void Markdown_Builder_When_Header_As_Parametr()
        {
            var markdownBuilder = new MarkdownBuilder();
            var header = new Header(2, "text");
            markdownBuilder.Header(2, "text");
            Console.WriteLine(markdownBuilder.Elements);
            Assert.Equal(markdownBuilder.Elements.Count(), 1);
            foreach (var element in markdownBuilder.Elements)
            {
                Assert.Equal(element.GetType(), header.GetType());
            }
        }

        [Fact]
        public void Markdown_Builder_When_CodeQuote_As_Parametr()
        {
            var markdownBuilder = new MarkdownBuilder();
            var codeQuote = new CodeQuote("some code");
            var expected = codeQuote.Create();
            markdownBuilder.CodeQuote("some code");
            Console.WriteLine(markdownBuilder.Elements);
            Assert.Equal(markdownBuilder.Elements.Count(), 1);
            foreach (var element in markdownBuilder.Elements)
            {
                Assert.Equal(element.GetType(), codeQuote.GetType());
            }

        }

    }
}

