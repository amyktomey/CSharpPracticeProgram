using CSharpPracticeProgram;

namespace CSharpPracticeProgramTests
{
    public class EmployeeTests
    {
        [Fact]
        public void CreateNewEmployeeTest()
        {
            //arrange & act
            var employee = new Employee();

            //assert
            Assert.NotNull(employee);
        }
    }
}