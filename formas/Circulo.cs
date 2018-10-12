namespace formas
{
    public class Circulo : Forma {
        private int radio;

        public Circulo(int radio)
        {
            this.radio = radio;
        }
        public override int PrintArea()
        {
            return (this.radio * 3);
        }
    }
}