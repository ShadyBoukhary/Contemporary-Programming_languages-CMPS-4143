// Shady Boukhary

namespace find_the_evidence
{
    class Point
    {
        /******************** Member Data ********************/

        private readonly int x;
        private readonly int y;

        /******************** Constructos ********************/

        public Point()
        {
            x = y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /******************** Properties ********************/

        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        /******************** Methods ********************/

        /// <summary>
        /// Override Equals To supress warnings
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>bool</returns>
        public override bool Equals(object obj)
        {
            Point a = (Point)obj;
            return x == a.X && y == a.Y;
        }

        /// <summary>
        /// Override GetHashCode to supress warnings
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Formats point to a string
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"({x}, {y})";
        }

        /******************** Overloaded Operators ********************/

        /// <summary>
        /// Overloaded operator ==
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool</returns>
        public static bool operator ==(Point left, Point right)
        {
            return left.X == right.X && left.Y == right.Y;
        }

        /// <summary>
        /// Overloaded operator !=
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns>bool</returns>
        public static bool operator !=(Point left, Point right)
        {
            return left.X != right.X || left.Y != right.Y;
        }
    }
}
