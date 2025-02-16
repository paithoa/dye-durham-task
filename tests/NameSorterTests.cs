using Xunit;
using System.Collections.Generic;

public class NameSorterTests
{
    private readonly NameSorter _nameSorter = new NameSorter(); // ✅ Use the actual class

    [Fact]
    public void SortNames_ShouldSortNamesCorrectly()
    {
        // Arrange
        var unsortedNames = new List<string>
        {
            "Janet Parsons",
            "Vaughn Lewis",
            "Adonis Julius Archer",
            "Shelby Nathan Yoder",
            "Marin Alvarez",
            "London Lindsey",
            "Beau Tristan Bentley",
            "Leo Gardner",
            "Hunter Uriah Mathew Clarke",
            "Mikayla Lopez",
            "Frankie Conner Ritter"
        };

        var expectedSortedNames = new List<string>
        {
            "Marin Alvarez",
            "Adonis Julius Archer",
            "Beau Tristan Bentley",
            "Hunter Uriah Mathew Clarke",
            "Leo Gardner",
            "Vaughn Lewis",
            "London Lindsey",
            "Mikayla Lopez",
            "Janet Parsons",
            "Frankie Conner Ritter",
            "Shelby Nathan Yoder"
        };

        // Act
        var sortedNames = _nameSorter.SortNames(unsortedNames);

        // Assert
        Assert.Equal(expectedSortedNames, sortedNames);
    }

    [Fact]
    public void SortNames_ShouldHandleSingleName()
    {
        // Arrange
        var input = new List<string> { "John Doe" };
        var expected = new List<string> { "John Doe" };

        // Act
        var sorted = _nameSorter.SortNames(input);

        // Assert
        Assert.Equal(expected, sorted);
    }

    [Fact]
    public void SortNames_ShouldSortByGivenNamesIfLastNamesAreTheSame()
    {
        // Arrange
        var input = new List<string>
        {
            "John Doe",
            "Alice Doe",
            "Bob Doe"
        };
        var expected = new List<string>
        {
            "Alice Doe",
            "Bob Doe",
            "John Doe"
        };

        // Act
        var sorted = _nameSorter.SortNames(input);

        // Assert
        Assert.Equal(expected, sorted);
    }

    [Fact]
    public void SortNames_ShouldNotChangeAlreadySortedList()
    {
        // Arrange
        var input = new List<string>
        {
            "Alice Brown",
            "Bob Clark",
            "Charlie Davis"
        };
        var expected = new List<string>(input);

        // Act
        var sorted = _nameSorter.SortNames(input);

        // Assert
        Assert.Equal(expected, sorted);
    }

    [Fact]
    public void SortNames_ShouldHandleDuplicateNames()
    {
        // Arrange
        var input = new List<string>
        {
            "Alice Brown",
            "Bob Clark",
            "Alice Brown"
        };
        var expected = new List<string>
        {
            "Alice Brown",
            "Alice Brown",
            "Bob Clark"
        };

        // Act
        var sorted = _nameSorter.SortNames(input);

        // Assert
        Assert.Equal(expected, sorted);
    }

    [Fact]
    public void SortNames_ShouldHandleEmptyList()
    {
        // Arrange
        var input = new List<string>();
        var expected = new List<string>();

        // Act
        var sorted = _nameSorter.SortNames(input);

        // Assert
        Assert.Equal(expected, sorted);
    }

    [Fact]
    public void SortNames_ShouldHandleDifferentGivenNameLengths()
    {
        // Arrange
        var input = new List<string>
        {
            "John Smith",
            "Anna Maria Smith",
            "Bob Smith"
        };
        var expected = new List<string>
        {
            "Anna Maria Smith",
            "Bob Smith",
            "John Smith"
        };

        // Act
        var sorted = _nameSorter.SortNames(input);

        // Assert
        Assert.Equal(expected, sorted);
    }
}
