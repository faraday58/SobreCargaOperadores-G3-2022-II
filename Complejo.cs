
namespace SobreCargaOperadores_G3_2022_II
{
    class Complejo
    {
        private float real;
        private float imaginaria;

        public Complejo (float real, float imaginaria)
        {
            this.real = real;
            this.imaginaria = imaginaria;
        }

        public static Complejo operator +(Complejo c1, Complejo  c2 )
        {
            return new Complejo(c1.real + c2.real, c1.imaginaria + c2.imaginaria);
        }

        public override string ToString()
        {
            //string Format: Da formato tipo WriteLine a una cadena
            return string.Format( " {0} + {1}i",real,imaginaria) ;
        }

    }
}
