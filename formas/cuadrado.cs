namespace formas
{
    public class Cuadrado : Forma {
        private int lado;

        public Cuadrado(int lado)
        {
            this.lado = lado;
        }
        public override int PrintArea()
        {
            return (this.lado * this.lado);
        }
    }
}