namespace RefOutRegexTryparse
{
    internal class RefOut
    {
        public static void ChangeVar(out int a,out int b)
        {
            a = 20;
            b = 30;
            var tam = a;
            a = b;
            b = tam;
        }
    }
}
