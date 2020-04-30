namespace ColorBallsWithProperties
{
    public class Ball
    {
        // Instance Variables 
        private Color color;
        private float size;

        public int NumberOfThrows{get; private set;}

        // Construtors 
        public Ball(Color color, float size)
        {
            this.color = color;
            this.size = size;
            NumberOfThrows = 0;
        }


        // Operational methods
        public void Pop()
        {
            size = 0;
        }

        public void Throw()
        {
            if (size > 0)
            {
                NumberOfThrows++;
            }

        }


    }
}