using TestUnit.Console.Services;

namespace TestUnit;

public class ValidationsTestsList
{
    private ValidationsList _validations = new ValidationsList();
    

        [Fact]
    public void MustRemoveNegativeNumbersFromAList()
    {
        // Arrange
        var list = new List<int> { 5, -1, -8, 9 };
        var expectedOutcome = new List<int> { 5, 9 };

        // Act
        var result = _validations.RemoveNegativeNumbers(list);

        // Assert
        Assert.Equal(expectedOutcome, result);
    }

    [Fact]
    public void MustContainNumber9InList()
    {
        // Arrange
        var list = new List<int> { 5, -1, -8, 9 };
        var numberToSearch = 9;

        // Act
        var result = _validations.ListContainsDeterminedNumber(list, numberToSearch);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void MustNotContainNumber10InList()
    {
        // Arrange
        var list = new List<int> { 5, -1, -8, 9 };
        var numberToSearch = 10;

        // Act
        var result = _validations.ListContainsDeterminedNumber(list, numberToSearch);

        // Assert
        Assert.False(result);
    }

    //TODO: Corrigir a anotação [Fact]
    [Fact]
    public void MustMultiplyListElementsBy2()
    {
        // Arrange
        var list = new List<int> { 5, 7, 8, 9 };
        var multiplier = 2;
        var expectedOutcome = new List<int> { 10, 14, 16, 18 };
        
        // Act
        var result = _validations.MultiplyNumbersList(list, multiplier);
        // Assert
        Assert.Equal(expectedOutcome, result);
    }

    [Fact]
    public void MustReturn9AsLargestNumberInList()
    {
        // Arrange
        var list = new List<int> { 5, -1, -8, 9 };

        // Act
        var result = _validations.ReturnLargestNumberList(list);

        // Assert
        Assert.Equal(9, result);
    }

    [Fact]
    public void ShouldReturnNegativeEightAsLowestNumberInList()
    {
        // Arrange
        var list = new List<int> { 5, -1, -8, 9 };

        // Act
        var result = _validations.ReturnSmallNumberList(list);

        // Assert
        Assert.Equal(-8, result);
    }
}