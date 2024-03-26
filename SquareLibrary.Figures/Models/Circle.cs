using SquareLibrary.Figures.Abstractions;
using SquareLibrary.Figures.Helpers;

namespace SquareLibrary.Figures.Models;

/// <summary>
/// Circle figure POCO model.
/// </summary>
public class Circle : FigureBase
{
    /// <summary>
    /// Circle figure POCO model.
    /// </summary>
    /// <param name="radius"> Radius of circle. </param>
    public Circle(int radius)
    {
        if (radius <= 0)
            throw new Exception(Constants.NonValidRadius);

        Radius = radius;
    }
    
    /// <summary>
    /// Radius of circle.
    /// </summary>
    public double Radius { get; }

    /// <inheritdoc />
    protected sealed override double CalculateSquare() => Math.PI * Radius * Radius;
}