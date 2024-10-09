namespace ShapeCalculator
{
    public abstract class Shape2D
    {
        protected double _width;
        
        protected double _height;

        /// <summary>
        /// Width of the 2D shape
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }

            private set
            {
                if (value <= 0) throw new ArgumentException("Width must be positive.");
                _width = value;
            }
        }

        /// <summary>
        /// Height of the 2D shape
        /// </summary>
        public double Height
        {
            get
            {
                return _height;
            }

            private set
            {
                if (value <= 0) throw new ArgumentException("Height must be positive.");
                _height = value;
            }
        }
        
        /// <summary>
        /// Represents a 2D shape
        /// </summary>
        /// <param name="width">Width of the 2D shape</param>
        /// <param name="height">Height of the 2D shape</param>
        /// <exception cref="ArgumentException"></exception>
        public Shape2D(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
}