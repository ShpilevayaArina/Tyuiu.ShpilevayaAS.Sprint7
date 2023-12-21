﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.ShpilevayaAS.Sprint7.Project.V2.Lib
{
    public class DataService
    {
        public string[,] GetDataFromFile(string path)
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
