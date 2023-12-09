
/*
 * ovveride get hash code
 * override equals
 * explicit conversion 3D to 2D
 * explicit conversion 2D to 3D (add z axis)
 * 
 */


namespace FancyMath
{
    /// <summary>
    /// Represents a point in 2D Cartesian coordinates with x and y axes.
    /// </summary>
    public interface IPoint2D
    {
        /// <summary>
        /// Gets or sets the X coordinate.
        /// </summary>
        /// <returns><see cref="double"/></returns>
        double X { get; set; }
        /// <summary>
        /// Gets or sets the Y coordinate.
        /// </summary>
        double Y { get; set; }

        /// <summary>
        /// Finds the distance between this point and another 2D point.
        /// </summary>
        /// <param name="point2"></param>
        /// <returns></returns>
        double Distance(IPoint2D point2);
    }

    /// <summary>
    /// Represents a point in 3D Cartesian coordinates with x, y, and z axes.
    /// </summary>
    public interface IPoint3D
    {
        /// <summary>
        /// Gets or sets the X coordinate.
        /// </summary>
        /// <returns><see cref="double"/></returns>
        double X { get; set; }
        /// <summary>
        /// Gets or sets the Y coordinate.
        /// </summary>
        double Y { get; set; }
        /// <summary>
        /// Gets or sets the Z coordinate.
        /// </summary>
        double Z { get; set; }

        /// <summary>
        /// Finds the distance between this point and another 3D point.
        /// </summary>
        /// <param name="point2"></param>
        /// <returns></returns>
        double Distance(IPoint3D point2);
    }

    /// <inheritdoc/>
    class Point2D : IPoint2D
    {
        /// <inheritdoc/>
        public double X { get; set; }
        /// <inheritdoc/>
        public double Y { get; set; }

        /// <summary>
        /// Creates a new instance of <see cref="Point2D"/> with the specified <paramref name="x"/> and <paramref name="y"/> coordinates.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point2D(double x, double y )
        {
            X = x;
            Y = y;
        }

        /// <inheritdoc/>
        public double Distance(IPoint2D point2)
        {
            return Math.Sqrt( Math.Pow( X - point2.X, 2 ) + Math.Pow( Y - point2.Y, 2 ) );
        }
    }

    /// <inheritdoc/>
    class Point3D : IPoint3D
    {
        /// <inheritdoc/>
        public double X { get; set; }
        /// <inheritdoc/>
        public double Y { get; set; }
        /// <inheritdoc/>
        public double Z { get; set; }

        /// <summary>
        /// Creates a new instance of <see cref="Point3D"/> with the specified <paramref name="x"/>, <paramref name="y"/>, and <paramref name="z"/> coordinates.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <inheritdoc/>
        public double Distance(IPoint3D point2)
        {
            return Math.Sqrt(Math.Pow( X - point2.X, 2 ) + Math.Pow( Y - point2.Y, 2 ) + Math.Pow( Z - point2.Z, 2 ) );
        }

        /// <summary>
        /// Converts a Point3D to a Point2D.
        /// </summary>
        /// <param name="inst"></param>
        public static explicit operator Point2D(Point3D inst)
        {
            return new Point2D(inst.X, inst.Y);
        }
    }

    

}