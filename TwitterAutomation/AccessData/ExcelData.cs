using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using ExcelDataReader;

namespace TwitterAutomation.AccessData
{
    public static class ExcelData
    {
        private static DataTable excelTable(string filename)
        {
            FileStream stream = File.Open(filename, FileMode.Open, FileAccess.Read);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);



            DataSet resultSet = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });
            DataTableCollection table = resultSet.Tables;
            DataTable resultTable = table["Sheet1"];
            return resultTable;
        }

        public class DataCollection
        {
            public int RowNumber { get; set; }
            public string ColName { get; set; }
            public string ColValue { get; set; }

        }

        static List<DataCollection> dataCol = new List<DataCollection>();
        public static void PopulateInCollection(string filename)
        {
            DataTable table = excelTable(filename);
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    DataCollection dtTable = new DataCollection()
                    {
                        RowNumber = row,
                        ColName = table.Columns[col].ColumnName,
                        ColValue = table.Rows[row - 1][col].ToString()

                    };
                    dataCol.Add(dtTable);
                }
            }
        }

        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                string data = (from colData in dataCol where colData.ColName == columnName && colData.RowNumber == rowNumber select colData.ColValue).SingleOrDefault();
                return data.ToString();



            }
            catch (Exception e)
            {
                return (e.Message);
            }
        }
    }
}

