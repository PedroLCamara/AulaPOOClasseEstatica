namespace AulaPOOClassesEstaticas.classes
{
    public static class conversor
    {
        public static float cotacaoDolar = 5.22f;
        public static float dolarParaReal(float valorDolares){
            return valorDolares * cotacaoDolar;
        }
        public static float realParaDolar(float valorReais){
            return valorReais / cotacaoDolar;
        }
    }
}