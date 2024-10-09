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
                return this._width;
            }

            set
            {
                if (value <= 0) throw new ArgumentException("Width must be positive.");
                this._width = value;
            }
        }

        /// <summary>
        /// Height of the 2D shape
        /// </summary>
        public double Height
        {
            get
            {
                return this._height;
            }

            set
            {
                if (value <= 0) throw new ArgumentException("Height must be positive.");
                this._height = value;
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