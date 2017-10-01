using System;
using Excel = Microsoft.Office.Interop.Excel;

namespace MigraPlastifluor
{
    public class ExcelDb
    {
        public void Produto()
        {
            var db = new Context();

            for (int i = 2; i < 4; i++)
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook workbook = xlApp.Workbooks.Open(Files.Produtos);
                Excel._Worksheet worksheet = workbook.Sheets[i];
                Excel.Range range = worksheet.UsedRange;

                try
                {
                    for (int j = 2; j <= range.Rows.Count; j++)
                    {

                        var data = new Produto
                        {
                            Apelido = range.Cells[i, 1] != null && range.Cells[i, 1].Value2 != null ? range.Cells[i, 1].Value2.ToString() : "0000000000",
                            Descricao = range.Cells[i, 2] != null && range.Cells[i, 2].Value2 != null ? range.Cells[i, 2].Value2.ToString() : "--",
                            UnidadeId = range.Cells[i, 3] != null && range.Cells[i, 3].Value2 != null ? SelectUnidade.Run(range.Cells[i, 3].Value2.ToString()) : 0,
                            TipoId = range.Cells[i, 4] != null && range.Cells[i, 4].Value2 != null ? SelectTipo.Run(range.Cells[i, 4].Value2.ToString()) : 0,
                            ClasseCustoId = range.Cells[i, 5] != null && range.Cells[i, 5].Value2 != null ? SelectClasseCusto.Run(range.Cells[i, 5].Value2.ToString()) : 0,
                            CategoriaId = range.Cells[i, 6] != null && range.Cells[i, 6].Value2 != null ? SelectCategoria.Run(range.Cells[i, 6].Value2.ToString()) : 0,
                            FamiliaId = range.Cells[i, 7] != null && range.Cells[i, 7].Value2 != null ? SelectFamilia.Run(range.Cells[i, 7].Value2.ToString()) : 0,
                            LinhaId = range.Cells[i, 8] != null && range.Cells[i, 8].Value2 != null ? SelectLinha.Run(range.Cells[i, 8].Value2.ToString()) : 0
                        };

                        db.Produtos.Add(data);
                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    xlApp.Quit();
                    workbook = null;
                    worksheet = null;
                    xlApp = null;
                } 
            }
        }
    }
}

// to be continued if needed