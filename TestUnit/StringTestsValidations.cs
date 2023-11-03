using TestUnit.Console.Services;

namespace TestUnit
{
    public class StringTestsValidations
    {
        private ValidationsString _validations = new ValidationsString();

        [Fact]
    public void MustReturn6QuantityCharactersOfWordMatrix()
    {
        // Arrange
        var text = "Daniel";
        var expectedOutcome = 6;

        // Act
        var result = _validations.ReturnQuantityCharacters(text);

        // Assert
        Assert.Equal(expectedOutcome, result);
    }

    [Fact]
    public void MustContainAnyWordInText()
    {
        // Arrange
        var text = "This is any text";
        var textWanted = "any";

        // Act
         var result = _validations.ContainsCharacter(text, textWanted);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void MustNotContainTheWordTestInTheText()
    {
        // Arrange
        var text = "This is any text";
        var textWanted = "test";

        // Act
        var result = _validations.ContainsCharacter(text, textWanted);

        // Assert
        Assert.False(result);
    }


    [Fact]
    public void TextMustEndWithWordWanted()
    {
        // Arrange
        var text = "Beginning, middle and end of the text wanted";
        var textWanted = "wanted";

        // Act
        var result = _validations.TextTerminaWith(text, textWanted);

        // Assert
        Assert.True(result);
    }
    }
}