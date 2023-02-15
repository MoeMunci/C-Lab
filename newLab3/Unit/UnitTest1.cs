using Xunit;
using Test;

namespace Unit;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        double a = 3; // arrange
		double b = 2;
		double expected = 27;
	
		double actual = Test.Class1.MyPow(a,b); // act
 
		Assert.Equal(expected, actual); // assert

    }
    [Fact]
    public void TestSquareRootOf4() {
    
		double a = 8; // arrange
		double b = 2;
		double c = 3;
		double expected = 4096;
	
		double actual = Test.Class1.MyPow2(a,b,c); // act

		Assert.Equal(expected, actual); // assert
	} 
}