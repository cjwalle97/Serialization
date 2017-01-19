using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{

    static class DataManagement<T>
    {
        public static void serialization(string fileName, T data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextWriter writter = new StreamWriter(@"..\..\SavedFiles\" + fileName + ".xml");
            serializer.Serialize(writter, data);
            writter.Close();
        }
        public static T Deserialize(string fileName)
        {
            T data;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextReader reader = new StreamReader(@"..\..\SavedFile\" + fileName + ".xml");
            data = (T)serializer.Deserialize(reader);
            return data;
        }
    }
}
