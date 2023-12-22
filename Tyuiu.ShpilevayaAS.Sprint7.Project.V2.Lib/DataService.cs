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
        public string GetDataFromFile(string row, int column)
        {
            string path = @"C:\Users\katri\source\repos\Tyuiu.ShpilevayaAS.Sprint7\Tyuiu.ShpilevayaAS.Sprint7.Project.V2.Lib\ListOfDepartments.csv";

            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] matrix = new string[rows, columns];
            string[] departments = new string[rows];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = Convert.ToString(line_r[c]);
                    if (c == 0)
                    {
                        departments[r] = Convert.ToString(line_r[c]);
                    }
                }
            }

            string res = "";
            for (int i = 0; i < rows; i++)
            {
                if (i == Array.IndexOf(departments, row))
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j == column)
                        {
                            res = matrix[i, j];
                        }
                    }
                }
            }
            return res;
        }
        public bool AddNewDataToFile(string path, string[] line)
        {
            bool completed = false;
            string str = "";

            for (int i = 0; i < line.Length; i++)
            {
                if (i != line.Length - 1)
                {
                    str = str + line[i] + ";";
                }
                else
                {
                    str = str + line[i];
                }
            }
            File.AppendAllText(path, str + Environment.NewLine, Encoding.GetEncoding(1251));
            completed = true;
            return completed;
        }
    }
}
