namespace ShapeCalculator
{
    public abstract class Shape2D
    {
        protected double _width;
        /// <summary>
        /// Width of the 2D Shape
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
        
        protected double _height;
        /// <summary>
        /// Height of the 2D Shape
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
        /// Represents a 2D Shape
        /// </summary>
        /// <param name="width">Width of the 2D Shape</param>
        /// <param name="height">Height of the 2D Shape</param>
        /// <exception cref="ArgumentException"></exception>
        public Shape2D(double width, double height)
        {
            if (width <= 0) throw new ArgumentException("Width must be positive.");
            if (height <= 0) throw new ArgumentException("Height must be positive");

            this._width = width;
            this._height = height;
        }
    }
}
