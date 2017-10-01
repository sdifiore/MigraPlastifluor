namespace MigraPlastifluor
{
    public static class SelectCategoria
    {
        public static int Run(string celula)
        {
            var comp = celula.Substring(0, 2);

            if (comp == "20") return 1;
            if (comp == "50") return 2;
            if (comp == "51") return 3;
            if (comp == "52") return 4;
            if (comp == "60") return 5;
            if (comp == "61") return 6;
            if (comp == "71") return 7;
            if (comp == "82") return 8;
            if (comp == "91") return 9;

            return 0;
        }
    }
}
