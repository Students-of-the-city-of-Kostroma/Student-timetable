using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestOfTimetableOfClasses
{
    class writeXmltofile
    {
        private void WriteXmlToFile(DataSet thisDataSet)///Метод предоставляет способ записи либо данных, либо схемы DataSet из в XML- WriteXmlSchema документ,
            ///в то время как метод записывает только схему. WriteXml Чтобы записать данные и схему, используйте одну из перегрузок, включающих mode параметр, 
            ///и задайте для WriteSchemaнего значение.
        {
            if (thisDataSet == null) { return; }

            /// Create a file name to write to.
            string filename = "XmlDoc.xml";

            /// Create the FileStream to write with.
            System.IO.FileStream stream = new System.IO.FileStream
                (filename, System.IO.FileMode.Create);

            /// Write to the file with the WriteXml method.
            thisDataSet.WriteXml(stream);
        }
    }
    class ReadWriteXMLDocumentWithFileStream ///Метод предоставляет способ записи либо данных, либо схемы DataSet из в XML- WriteXmlSchema документ, 
        ///в то время как метод записывает только схему. WriteXml Чтобы записать данные и схему, задайте mode для WriteSchemaпараметра значение.
    {
        private void DemonstrateReadWriteXMLDocumentWithFileStream()
        {
            /// Create a DataSet with one table and two columns.
            DataSet originalDataSet = new DataSet("dataSet");
            DataTable table = new DataTable("table");
            DataColumn idColumn = new DataColumn("id",
                Type.GetType("System.Int32"));
            idColumn.AutoIncrement = true;

            DataColumn itemColumn = new DataColumn("item");
            table.Columns.Add(idColumn);
            table.Columns.Add(itemColumn);
            originalDataSet.Tables.Add(table);
            /// Add ten rows.

            DataRow newRow;
            for (int i = 0; i < 10; i++)
            {
                newRow = table.NewRow();
                newRow["item"] = "item " + i;
                table.Rows.Add(newRow);
            }
            originalDataSet.AcceptChanges();

            /// Print out values of each table in the DataSet  
            /// using the function defined below.
            PrintValues(originalDataSet, "Original DataSet");

            /// Write the schema and data to XML file with FileStream.
            string xmlFilename = "XmlDocument.xml";
            System.IO.FileStream streamWrite = new System.IO.FileStream
                (xmlFilename, System.IO.FileMode.Create);

            /// Use WriteXml to write the XML document.
            originalDataSet.WriteXml(streamWrite);

            /// Close the FileStream.
            streamWrite.Close();

            /// Dispose of the original DataSet.
            originalDataSet.Dispose();
            /// Create a new DataSet.
            DataSet newDataSet = new DataSet("New DataSet");

            /// Read the XML document back in. 
            /// Create new FileStream to read schema with.
            System.IO.FileStream streamRead = new System.IO.FileStream
                (xmlFilename, System.IO.FileMode.Open);
            newDataSet.ReadXml(streamRead);

            /// Print out values of each table in the DataSet 
            /// using the function defined below.
            PrintValues(newDataSet, "New DataSet");
        }

        private void PrintValues(DataSet dataSet, string label)
        {
            Console.WriteLine("\n" + label);
            foreach (DataTable table in dataSet.Tables)
            {
                Console.WriteLine("TableName: " + table.TableName);
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        Console.Write("\table " + row[column]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
