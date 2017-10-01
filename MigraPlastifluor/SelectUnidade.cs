namespace MigraPlastifluor
{
    public static class SelectUnidade
    {
        public static int Run(string celula)
        {
            var comp = celula.ToLower();

            if (comp == "cx" || comp == "caixa") return 1;
            if (comp == "pc" || comp == "pç" || comp == "peça" || comp == "peca") return 2;
            if (comp == "kg" || comp == "kilograma") return 3;
            if (comp == "m" || comp == "mt" || comp == "metro") return 4;
            if (comp == "rl" || comp == "rolo") return 5;
            if (comp == "ml" || comp == "milheiro") return 6;

            return 0;
        }
    }
}
}
}