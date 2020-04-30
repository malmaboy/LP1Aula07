namespace ColorBallsWithProperties
{
    public class Color
    {
        public byte Red{ get; set;}
        public byte Blue { get; set;}

        public byte Green { get; set;}

        public byte Alpha { get; set;}

        public byte Grayscale
        {
          get => (byte) ((Red + Green + Blue) /3);
        }


        // We don't need constructors since we're using objects
        // with properties initialization syntax (see Main())
        // We didn't do this in Aula07, although this was
        // a requirement of Exercicio 1
    }
}