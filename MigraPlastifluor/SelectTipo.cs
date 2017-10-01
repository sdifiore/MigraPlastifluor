namespace MigraPlastifluor
{
    public static class SelectTipo
    {
        public static int Run(string celula)
        {
            var comp = celula.Substring(0, 2).ToLower();
            if (comp == "a") return 1;
            if (comp == "b") return 2;

            return 0;
        }
    }
}
