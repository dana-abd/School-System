using Xunit;

namespace Students.Tests
{
    public class StudentValidationTests
    {
        [Fact]
        public void Test_EmptyStudentName_ShouldFail()
        {
            string studentName = "";
            bool isValid = !string.IsNullOrWhiteSpace(studentName);
            Assert.False(isValid);
        }

        [Fact]
        public void Test_ValidStudentName_ShouldPass()
        {
            string studentName = "Dana";
            bool isValid = !string.IsNullOrWhiteSpace(studentName);
            Assert.True(isValid);
        }
    }
}