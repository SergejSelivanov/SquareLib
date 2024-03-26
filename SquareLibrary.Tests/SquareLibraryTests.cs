using FluentAssertions;
using SquareLibrary.Figures.Models;
using Xunit;

namespace SquareLibrary.Tests;

/// <summary>
/// Square library tests.
/// </summary>
public class SquareLibraryTests
{
    /// <summary>
    /// Testing not valid circle radius.
    /// </summary>
    [Fact]
    public void CircleNotValidRadiusTest()
    {
        Action act = () =>
        {
            var unused = new Circle(-100);
        };
        act.Should().Throw<Exception>();
    }

    /// <summary>
    /// Testing not valid triangle first line.
    /// </summary>
    [Fact]
    public void TriangleNotValidFirstLineTest()
    {
        Action act = () =>
        {
            var unused = new Triangle(-100, 0, 0);
        };
        act.Should().Throw<Exception>();
    }

    /// <summary>
    /// Testing not valid triangle second line.
    /// </summary>
    [Fact]
    public void TriangleNotValidSecondLineTest()
    {
        Action act = () =>
        {
            var unused = new Triangle(0, -100, 0);
        };
        act.Should().Throw<Exception>();
    }

    /// <summary>
    /// Testing not valid triangle third line.
    /// </summary>
    [Fact]
    public void TriangleNotValidThirdLineTest()
    {
        Action act = () =>
        {
            var unused = new Triangle(0, 0, -100);
        };
        act.Should().Throw<Exception>();
    }

    /// <summary>
    /// Testing not valid triangle lines.
    /// </summary>
    [Fact]
    public void TriangleNotValidLinesTest()
    {
        Action act = () =>
        {
            var unused = new Triangle(-100, -100, -100);
        };
        act.Should().Throw<Exception>();
    }

    /// <summary>
    /// Testing valid circle first radius.
    /// </summary>
    [Fact]
    public void CircleValidSquareTest()
    {
        var circle = new Circle(100);
        var circleSquare = circle.Square;
        circleSquare.Should().Be(31415.926535897931);
    }

    /// <summary>
    /// Testing valid triangle lines.
    /// </summary>
    [Fact]
    public void TriangleValidSquareTest()
    {
        var triangle = new Triangle(3, 4, 5);
        var triangleSquare = triangle.Square;
        triangleSquare.Should().Be(6);
    }

    /// <summary>
    /// Testing right triangle.
    /// </summary>
    [Fact]
    public void RightAngleTriangleTest()
    {
        var triangle = new Triangle(3, 4, 5);
        var isTriangleRightAngle = triangle.IsRightTriangle;
        isTriangleRightAngle.Should().Be(true);
    }

    /// <summary>
    /// Testing not right triangle.
    /// </summary>
    [Fact]
    public void NotRightAngleTriangleTest()
    {
        var triangle = new Triangle(10, 3, 5);
        var isTriangleRightAngle = triangle.IsRightTriangle;
        isTriangleRightAngle.Should().Be(false);
    }
}