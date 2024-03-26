using SquareLibrary.Figures.Abstractions;
using SquareLibrary.Figures.Helpers;

namespace SquareLibrary.Figures.Models;

/// <summary>
/// Triangle figure POCO model.
/// </summary>
public class Triangle : FigureBase
{
    private const double Tolerance = 0.000000001;
    
    /// <summary>
    /// Triangle figure POCO model.
    /// </summary>
    /// <param name="firstLine">  First side of a triangle. </param>
    /// <param name="secondLine"> Second side of a triangle. </param>
    /// <param name="thirdLine"> Third side of a triangle. </param>
    public Triangle(double firstLine, double secondLine, double thirdLine)
    {
        if (firstLine <= 0 || secondLine <= 0 || thirdLine <= 0)
            throw new Exception(Constants.NonValidLines);

        FirstLine = firstLine;
        SecondLine = secondLine;
        ThirdLine = thirdLine;
    }
    
    /// <summary>
    /// First line of a triangle.
    /// </summary>
    public double FirstLine { get; }
    
    /// <summary>
    /// Second line of a triangle.
    /// </summary>
    public double SecondLine { get; }
    
    /// <summary>
    /// Third line of a triangle.
    /// </summary>
    public double ThirdLine { get; }

    /// <summary>
    /// Is triangle right.
    /// </summary>
    public bool IsRightTriangle => CheckIsRightTriangle();
    
    /// <summary>
    /// Check is triangle right or not.
    /// </summary>
    /// <returns> Boolean answer. </returns>
    private bool CheckIsRightTriangle() =>
        Math.Abs(FirstLine * FirstLine + SecondLine * SecondLine - ThirdLine * ThirdLine) < Tolerance ||
        Math.Abs(FirstLine * FirstLine + ThirdLine * ThirdLine - SecondLine * SecondLine) < Tolerance ||
        Math.Abs(ThirdLine * ThirdLine + SecondLine * SecondLine - FirstLine * FirstLine) < Tolerance;

    /// <inheritdoc />
    protected sealed override double CalculateSquare()
    {
        var semiPerimeter = (FirstLine + SecondLine + ThirdLine) / 2;
        return Math.Sqrt(
            semiPerimeter * 
            (semiPerimeter - FirstLine) *
            (semiPerimeter - SecondLine) *
            (semiPerimeter - ThirdLine));
    }
}