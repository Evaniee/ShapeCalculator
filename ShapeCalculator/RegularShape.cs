namespace ShapeCalculator
{
    public abstract class RegularShape
    {
        protected double _length;

        /// <summary>
        /// Length of one side of the regular shape
        /// </summary>
        public double Length
        {
            get
            {
                return this._length;
            }

            set
            {
                if (value <= 0) throw new ArgumentException("Length must be positive.");
                this._length = value;
            }
        }

        /// <summary>
        /// Represents a regular shape
        /// </summary>
        /// <param name="length">Length of one side of the regular shape</param>
        /// <exception cref="ArgumentException"></exception>
        public RegularShape(double length)
        {
            Length = _length;
        }
    }
}