using System;
using System.Linq;
using Markdown.Generator.Core.Markdown;
using Xunit;

namespace Tests.Markdown.Generator.Core.Tests
{
    public class MarkdownableTypeTests
    {
        [Fact]
        public void MarkdownableTypeTests_For_GetMethods()
        {
            Type t = typeof(Sut);
            ILookup<string, XmlDocumentComment> commentLookup = null;
            MarkdownableType markdownable = new MarkdownableType(t, commentLookup);
            var real = markdownable.GetMethods();
            foreach (var met in real)
            {
                bool actial = !met.IsPrivate;
                bool expected = true;

                Assert.Equal(expected, actial);
            }
        }

        [Fact]
        public void MarkdownableTypeTests_For_GetFields()
        {
            Type t = typeof(Sut);
            ILookup<string, XmlDocumentComment> commentLookup = null;
            MarkdownableType markdownable = new MarkdownableType(t, commentLookup);
            var real = markdownable.GetFields();
            foreach (var met in real)
            {
                bool actial = !met.IsPrivate;
                bool expected = true;
                Assert.Equal(expected, actial);
            }
        }
        
        [Fact]
        public void MarkdownableTypeTests_For_GetProperties()
        {
            Type t = typeof(Sut);
            ILookup<string, XmlDocumentComment> commentLookup = null;
            MarkdownableType markdownable = new MarkdownableType(t, commentLookup);
            var real = markdownable.GetProperties();
            foreach (var prop in real)
            {
                var met = prop.GetGetMethod();
                var actial = !met.IsPrivate;
                bool expected = true;
                Assert.Equal(expected, actial);
            }
        }

    }
    public class Sut
    {
        public int publicInt;
        private int privatInt;
        
        public void PublicMethod() {}

        private void PrivateMethod() {}
        
        public void PublicMethod1() {}
    }

}