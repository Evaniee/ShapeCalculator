namespace ShapeCalculator
{
    public abstract class Shape3D : Shape2D
    {
        protected double _depth;

        /// <summary>
        /// Depth of the 2D shape
        /// </summary>
        public double Depth
        {
            get
            {
                return _depth;
            }

            private set
            {
                if (value <= 0) throw new ArgumentException("Depth must be positive.");
                _depth = value;
            }
        }

        /// <summary>
        /// Represents a 3D shape
        /// </summary>
        /// <param name="width">Width of the 3D shape</param>
        /// <param name="height">Height of the 3D shape</param>
        /// <param name="depth">Depth of the 3D shape</param>
        /// <exception cref="ArgumentException"></exception>
        public Shape3D(double width, double height, double depth) : base(width, height)
        {
            Depth = depth;
        }
    }
}