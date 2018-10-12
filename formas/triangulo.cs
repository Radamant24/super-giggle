namespace formas{
    public class Triangulo : Forma {
        private int lado;
        private int altura;

        public Triangulo(int lado, int altura)
        {
            this.lado = lado;
            this.altura = altura;
        }
        public override int PrintArea()
        {
            return (this.lado * this.altura)/2;
        }
    }


}