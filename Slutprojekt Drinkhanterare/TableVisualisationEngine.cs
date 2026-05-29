using ConsoleTableExt;
using System.Diagnostics.CodeAnalysis;

namespace drinks_info
{
    public class TableVisualisationEngine
    {
        //visar data i en formaterad tabell i konsolen, centrerad med valfritt tabelnamn
        public static void ShowTable<T>(List<T> tableData, [AllowNull] string tableName) where T : class
        {
            //rensa konsolen och skriv ut en tabell med hjälp av ConsoleTableExt
            Console.Clear();

            if (tableName == null)
                tableName = "";

            Console.WriteLine("\n\n");

            //bygg och skriv tabellen centrerad
            ConsoleTableBuilder
                .From(tableData)
                .WithColumn(tableName)
                .WithFormat(ConsoleTableBuilderFormat.Alternative)
                .ExportAndWriteLine(TableAligntment.Center);
            Console.WriteLine("\n\n");
        }
    }
}
