using System;
using System.IO;
using Group.Core.Services;
using Xunit;

namespace Group.Core.Test.Services
{
    public class LoadFileShould
    {
        private readonly ILoadFileService _service = new LoadFileService();

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData(" ")]
        public void ThrownExceptionIfEmptyUrl(string url)
        {
            try
            {
                _service.Parse(string.Empty);
                Assert.True(false, "Should thrown an exception for empty or null url");
            }
            catch (System.ArgumentException)
            {
                Assert.True(true, "Should thrown an exception for empty or null url");
            }
        }

        [Theory]
        [InlineData("temp/test.json")]
        [InlineData("../test.json")]
        [InlineData("./test.json")]
        public void ThrownExceptionIfUrlIsNotAbsolute(string url)
        {
            try
            {
                _service.Parse(url);
                Assert.True(false, "Should thrown an exception for non absolute url");
            }
            catch (System.InvalidOperationException)
            {
                Assert.True(true, "Should thrown an exception for non absolute url");
            }
        }

        [Theory]
        [InlineData("http://endereco.url.com/arquivo.csv")]
        [InlineData("/home/user/arquivo.csv")]
        public void NotThrownExceptionIfUrlIsNotAbsolute(string url)
        {
            try
            {
                _service.Parse(url);
                Assert.True(true, "Should no thrown an exception for valid url");
            }
            catch (System.Exception)
            {
                Assert.True(false, "Should no thrown an exception for valid url");
            }
        }

        [Theory]
        [InlineData("http://endereco.url.com/arquivo.csv", false)]
        [InlineData("/home/user/arquivo.csv", true)]
        [InlineData("http://endereco.url.com/arquivo.json", false)]
        [InlineData("/home/user/arquivo.json", true)]
        [InlineData("http://endereco.url.com/arquivo", false)]
        [InlineData("/home/user/arquivo", true)]
        public void ShoudlDetectLocalAddress(string url, bool isLocal)
        {
            var uri = new Uri(url);
            var result = _service.IsLocal(uri);
            Assert.Equal(isLocal, result);
        }
    }
}