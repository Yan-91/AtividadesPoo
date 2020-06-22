namespace Aula22
{
    public static class Conversor
    {
        public static float CotacaoLibras = 6.55f;

        public static float ConverterLibrasParaReal(float valor){
            return valor * CotacaoLibras;
        }
        public static float ConverterRealParaLibras(float valor){
            return valor / CotacaoLibras;
        }
    }
}