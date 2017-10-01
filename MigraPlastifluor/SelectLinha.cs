namespace MigraPlastifluor
{
    public static class SelectLinha
    {
        public static int Run(string celula)
        {
            var comp = celula.Substring(0, 4);

            if (comp == "1015") return 1;
            if (comp == "1021") return 2;
            if (comp == "1024") return 3;
            if (comp == "1025") return 4;
            if (comp == "2112") return 5;
            if (comp == "2113") return 6;
            if (comp == "2114") return 7;
            if (comp == "2115") return 8;
            if (comp == "5011") return 9;

            return 0;
        }
    }
}
