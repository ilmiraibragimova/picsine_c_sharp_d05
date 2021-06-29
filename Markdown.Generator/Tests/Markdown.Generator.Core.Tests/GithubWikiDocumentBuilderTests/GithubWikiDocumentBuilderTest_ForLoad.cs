using System;
using System.Linq;
using Castle.DynamicProxy.Contributors;
using Markdown.Generator.Core.Markdown;
using Microsoft.VisualBasic;
using Moq;

namespace Tests.Markdown.Generator.Core.Tests.GithubWikiDocumentBuilderTests
{
    public class GithubWikiDocumentBuilderTest_ForLoad
    {
        public Mock<IMarkdownGenerator> mock = new();

        public void GithubWikiDocumentBuilderTest_ForLoad_Method()
        {
            Type[] types = new Type[2];
            types[0] = typeof(Sut);
            types[1] = typeof(int);
            ILookup<string, XmlDocumentComment> commentLookup = null;
            mock.Setup(x => x.Load()).Returns(MarkdownableType(types, commentLookup));
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