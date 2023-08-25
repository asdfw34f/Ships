using FileHelpers;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Media.Media3D;

namespace Ships.Infrastructure
{
    internal class CSVParse
    {
        internal string[] Parse(TextFieldParser textFieldParser)
        {
            string[] rows = {};
            textFieldParser.TextFieldType = FieldType.Delimited;
            textFieldParser.SetDelimiters(",");

            var fileHelperEngine = new FileHelperEngine<>();

            while (!textFieldParser.EndOfData)
            {
                rows = textFieldParser.ReadFields();
                
            }
            return rows;
        }
    }
}