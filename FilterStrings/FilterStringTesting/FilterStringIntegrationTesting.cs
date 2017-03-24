using FilterString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FilterStringTesting
{
    public class FilterStringIntegrationTesting
    {
        [Theory]
        [InlineData("albums")]
        public void GivenStringFilterTest(string filter)
        {
            var result = WordListSingleton.StringsInstance.Filter(filter);

            Assert.Equal(filter, result);
        }
    }
}
