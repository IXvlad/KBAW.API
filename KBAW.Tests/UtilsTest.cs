using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using KBAW.ErrorHandler;
using KBAW.Utils;
using Xunit;

namespace KBAW.Tests;

public class UtilsTest
{
    private readonly int[] _dimensionalArray = { 1, 2, 3, 4, 5 };

    private readonly int[,] _multidimensionalArray =
    {
        { 1, 2, 3, 4, 5 },
        { 6, 7, 8, 9, 10 },
        { 11, 12, 13, 14, 15 }
    };

    [Fact]
    public void ConvertEnumToPropEnum()
    {
        Assert.NotEmpty(EnumHelper.GetListItems<TestEnum>());
        Assert.IsType<PropEnum>(EnumHelper.GetListItems<TestEnum>().FirstOrDefault());
    }

    [Fact]
    public void GetRow_MultidimensionalArray_Success()
    {
        // Second row in multidimensionalArray
        int[] expected = { 6, 7, 8, 9, 10 };

        Assert.Equal(expected, _multidimensionalArray.GetRow(1));
    }

    [Fact]
    public void GetColumn_MultidimensionalArray_Success()
    {
        // Second column in multidimensionalArray
        int[] expected = { 2, 7, 12 };

        Assert.Equal(expected, _multidimensionalArray.GetColumn(1));
    }

    [Fact]
    public void GetRowAndGetColumn_MultidimensionalArray_IndexOutException()
    {
        Assert.Throws<IndexOutOfRangeException>(
            () => _multidimensionalArray.GetRow(10)
        );

        Assert.Throws<IndexOutOfRangeException>(
            () => _multidimensionalArray.GetColumn(10)
        );
    }

    [Fact]
    public void FindIndex_ElementNotFound()
    {
        Assert.Throws<CustomApplicationException>(
            () => _dimensionalArray.FindIndex(1000).First()
        );

        Assert.Throws<CustomApplicationException>(
            () => _multidimensionalArray.FindIndex(1000).First()
        );
    }

    [Fact]
    public void FindIndex_DimensionalArray_Success()
    {
        // Index for element "4" in array
        const int expectedIndex = 3;

        Assert.Equal(expectedIndex, _dimensionalArray.FindIndex(4).First());
    }

    [Fact]
    public void FindIndex_MultidimensionalArray_Success()
    {
        // Index for element "13" in second row in array
        const int expectedIndex = 2;

        Assert.Equal(expectedIndex, _multidimensionalArray.GetRow(2).FindIndex(13).First());
    }

    private enum TestEnum
    {
        [Display(Name = "Test value")] TestValue = 1
    }
}