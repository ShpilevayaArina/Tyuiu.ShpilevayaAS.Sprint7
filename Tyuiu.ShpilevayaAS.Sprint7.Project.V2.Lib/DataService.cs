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
        public string[,] LoadDataFromFile(string path)
        {
            string fileData = File.ReadAllText(path, Encoding.GetEncoding(1251));
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;
        }

        public Dictionary<string, int> GetNumberOfDepartments(string filePath)
        {
            Dictionary<string, int> elementCount = new Dictionary<string, int> { {"2019", 0}, {"2020", 0}, {"2021", 0}, {"2022", 0}, {"2023", 0} };

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] columns = line.Split(';'); 

                    if (columns.Length >= 5)
                    {
                        string year = columns[4]; 

                        if (elementCount.ContainsKey(year))
                        {
                            elementCount[year]++;
                        }
                        else
                        {
                            elementCount[year] = 1;
                        }
                    }
                }
            }
            return elementCount;

        }
    }
}
