using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.ShpilevayaAS.Sprint7.Project.V2.Lib
{
    public class DataService
    {
        public string ReadCsv(string path, int rows, int columns)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int row = lines.Length;
            int column = lines[0].Split(';').Length;

            string[,] matrix = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = Convert.ToString(line_r[c]);
                }
            }

            string res = "";
            for (int i = 0; i < rows; i++)
            {
                if (i == rows)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j == columns)
                        {
                            res = matrix[i, j];
                        }
                    }
                }
            }
            return res;
        }
    }
}
