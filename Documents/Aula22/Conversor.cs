namespace Aula22
{
    public static class Conversor
    {
        public static float CotacaoDolar = 5.23f;

        public static float ConverterDolarParaReal(float valor){
            return valor * CotacaoDolar;
        }
        public static float ConverterRealParaDolar(float valor){
            return valor / CotacaoDolar;
        }
    }
}