using System.Collections.Generic;
using System.IO;
using Xunit;

namespace MidPointLocator.Tests
{
    public class PostcodeFileImporterTests
    {
        [Fact]
        public void Test_GetPostcodes_Throws_Exception_If_File_Cannot_Be_Found()
        {
            string fullPath = System.Reflection.Assembly.GetAssembly(typeof(PostcodeFileImporterTests)).Location;
            string directory = Path.GetDirectoryName(fullPath);

            var filePath = $"{directory}/assets/non-existant-file.txt";
            var target = new PostcodeFileImporter(filePath);

            Assert.Throws<FileNotFoundException>(() => target.GetPostcodes());
        }

        [Fact]
        public void Test_GetPostcodes_Returns_Collection_Of_Postcodes_When_Importing_From_A_File_With_Valid_And_Invalid_Postcodes()
        {
            // arrange
            string fullPath = System.Reflection.Assembly.GetAssembly(typeof(PostcodeFileImporterTests)).Location;
            string directory = Path.GetDirectoryName(fullPath);

            var filePath = $"{directory}/assets/test-some-valid-postcodes.txt";
            var target = new PostcodeFileImporter(filePath);
            var expected = new List<string> { "MK1 2AB", "MK2 3CD" };

            // act
            var result = target.GetPostcodes();

            // assert
            Assert.Equal(result, expected);
        }

        [Fact]
        public void Test_GetPostcodes_Returns_Empty_Collection_When_Importing_From_A_File_With_Only_Invalid_Postcodes()
        {
            // arrange
            string fullPath = System.Reflection.Assembly.GetAssembly(typeof(PostcodeFileImporterTests)).Location;
            string directory = Path.GetDirectoryName(fullPath);

            var filePath = $"{directory}/assets/test-no-valid-postcodes.txt";
            var target = new PostcodeFileImporter(filePath);
            var expected = new List<string>();

            // act
            var result = target.GetPostcodes();

            // assert
            Assert.Equal(result, expected);
        }

        [Fact]
        public void Test_GetPostcodes_Returns_Empty_Collection_When_Importing_From_An_Empty_File()
        {
            // arrange
            string fullPath = System.Reflection.Assembly.GetAssembly(typeof(PostcodeFileImporterTests)).Location;
            string directory = Path.GetDirectoryName(fullPath);

            var filePath = $"{directory}/assets/test-no-valid-postcodes.txt";
            var target = new PostcodeFileImporter(filePath);
            var expected = new List<string>();

            // act
            var result = target.GetPostcodes();

            // assert
            Assert.Equal(result, expected);
        }
    }
}
