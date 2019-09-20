using System;
using Xunit;

namespace DailyKata.Tests
{
    public class HaystackNeedleKataTests
    {
        [Fact]
        public void FindNeedle_StringOnlyArray_FindsNeedle()
        {
            var stringOnlyArray = new object[] { "283497238987234", "a dog", "a cat", "some random junk", "a piece of hay", "needle", "something somebody lost a while ago" };

            var actual = HaystackNeedleKata.FindNeedle(stringOnlyArray);

            Assert.Equal("found the needle at position 5", actual);
        }

        [Fact]
        public void FindNeedle_ArrayWithInts_FindsNeedle()
        {
            var arrayWithInts = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 8, 7, 5, 4, 3, 4, 5, 6, 67, 5, 5, 3, 3, 4, 2, 34, 234, 23, 4, 234, 324, 324, "needle", 1, 2, 3, 4, 5, 5, 6, 5, 4, 32, 3, 45, 54 };

            var actual = HaystackNeedleKata.FindNeedle(arrayWithInts);

            Assert.Equal("found the needle at position 30", actual);
        }

        [Fact]
        public void FindNeedle_ArrayWithMixedType_FindsNeedle()
        {
            var mixedTypesArray = new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false };

            var actual = HaystackNeedleKata.FindNeedle(mixedTypesArray);

            Assert.Equal("found the needle at position 3", actual);
        }

        [Fact]
        public void FindNeedle_ArrayWithOnlyInts_DoesNotFindNeedle()
        {
            var mixedTypesArray = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 8, 7, 5, 4, 3, 4, 5, 6, 67, 5, 5, 3, 3, 4, 2, 34, 234, 23, 4, 234, 324, 324 };

            var actual = HaystackNeedleKata.FindNeedle(mixedTypesArray);

            Assert.Equal("needle not found", actual);
        }

        [Fact]
        public void FindNeedle_ArrayWithOnlyString_DoesNotFindNeedle()
        {
            var mixedTypesArray = new object[] { "a dog", "a cat", "some random junk", "283497238987234", "world" };

            var actual = HaystackNeedleKata.FindNeedle(mixedTypesArray);

            Assert.Equal("needle not found", actual);
        }

        [Fact]
        public void FindNeedle_EmptyArray_DoesNotFindNeedle()
        {
            var emptyArray = new object[0];

            var actual = HaystackNeedleKata.FindNeedle(emptyArray);

            Assert.Equal("needle not found", actual);
        }

        [Fact]
        public void FindNeedle_NullArray_ThrowsException()
        {
            Action act = () => HaystackNeedleKata.FindNeedle(default(object[]));

            Assert.Throws<ArgumentNullException>("haystack", act);
        }
    }
}
