namespace MigraPlastifluor
{
    public static class SelectClasseCusto
    {
        public static int Run(string celula)
        {
            var comp = celula.Substring(0, 2);

            if (comp == "00") return 1;
            if (comp == "01") return 2;
            if (comp == "02") return 3;
            if (comp == "06") return 4;
            if (comp == "07") return 5;
            if (comp == "10") return 6;

            return 0;
        }
    }
}
