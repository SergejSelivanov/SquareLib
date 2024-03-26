namespace SquareLibrary.Figures.Abstractions;

/// <summary>
/// Base figure POCO model.
/// </summary>
public abstract class FigureBase
{
    /// <summary>
    /// Square parameter.
    /// </summary>
    public double Square => CalculateSquare();

    /// <summary>
    /// Method for calculating square of figures.
    /// </summary>
    /// <returns> Square value. </returns>
    protected abstract double CalculateSquare();
}