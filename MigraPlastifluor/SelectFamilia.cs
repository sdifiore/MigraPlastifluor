namespace MigraPlastifluor
{
    public static class SelectFamilia
    {
        public static int Run(string celula)
        {
            var comp = celula.Substring(0, 3);

            if (comp == "201") return 1;
            if (comp == "501") return 2;
            if (comp == "502") return 2;
            if (comp == "503") return 4;
            if (comp == "511") return 5;
            if (comp == "512") return 6;
            if (comp == "601") return 7;
            if (comp == "602") return 8;
            if (comp == "606") return 9;
            if (comp == "607") return 10;
            if (comp == "610") return 11;
            if (comp == "611") return 12;
            if (comp == "613") return 13;

            return 0;
        }
    }
}
