using Microsoft.VisualBasic.FileIO;

namespace Ships.Infrastructure
{
    internal class CSVParse
    {
        internal void Parse(TextFieldParser textFieldParser)
        {
            textFieldParser.TextFieldType = FieldType.Delimited;
            textFieldParser.SetDelimiters(",");
            while (!textFieldParser.EndOfData)
            {
                string[] rows = textFieldParser.ReadFields();

            }
        }
    }
}