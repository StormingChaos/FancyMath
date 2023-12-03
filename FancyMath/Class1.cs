namespace FancyMath
{
    /// <summary>
    /// Represents a point in 2D Cartesian coordinates with x and y axes
    /// </summary>
    public interface IPoint2D
    {
        /// <summary>
        /// Gets or sets the X coordinate
        /// </summary>
        /// <returns><see cref="double"/></returns>
        double X { get; set; }
        /// <summary>
        /// Gets or sets the Y coordinate
        /// </summary>
        double Y { get; set; }
    }

    /// <summary>
    /// Represents a point in 3D Cartesian coordinates with x, y, and z axes
    /// </summary>
    public interface IPoint3D : IPoint2D
    {
        /// <summary>
        /// Gets or sets the Z coordinate
        /// </summary>
        double Z { get; set; }
    }

    class Point2D : IPoint2D
    {
        /// <inheritdoc/>
        public double X { get; set; }
        /// <inheritdoc/>
        public double Y { get; set; }
    }

    class Point3D : IPoint3D
    {
        public double Z { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}