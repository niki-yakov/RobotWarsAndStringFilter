using System;
using Xunit;
using FilterString;

namespace FilterStringTesting
{
    public class FilterStringTestinf
    {
        private readonly string[] stringSet = null;
        public FilterStringTestinf()
        {
            Moq.Mock<IWordListRepository> stringsMoq = new Moq.Mock<IWordListRepository>();

            stringsMoq.Setup(s => s.GetAllStrings()).Returns(new string[] {
                "al", "albums", "aver", "bar", "barely", "be", "befoul", "bums", "by", "cat", "con", "convex", "ely", "foul", "here", "hereby", "jig", "jigsaw", "or", "saw", "tail", "tailor", "vex", "we", "weaver"
            });

            stringSet = stringsMoq.Object.GetAllStrings();
        }

        [Theory]
        [InlineData("album")]
        [InlineData("albumsa")]
        [InlineData("album1")]
        public void GivenFilterStringTestForValidationArgumentException(string filter)
        {
            Assert.Throws<ArgumentException>(() => stringSet.Filter(filter));
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void GivenFilterStringTestForValidationArgumentNullException(string filter)
        {
            Assert.Throws<ArgumentNullException>(() => stringSet.Filter(filter));
        }

        [Theory]
        [InlineData("albums")]
        [InlineData("barely")]
        [InlineData("befoul")]
        public void GivenFilterStringTestingForExistingWord(string filter)
        {
            var result = stringSet.Filter(filter);

            Assert.Equal(filter, result);
        }

        [Theory]
        [InlineData("alboms")]
        [InlineData("byrely")]
        [InlineData("befoll")]
        public void GivenFilterStringTestingForNotExistingWord(string filter)
        {
            var result = stringSet.Filter(filter);

            Assert.Null(result);
        }
    }
}
