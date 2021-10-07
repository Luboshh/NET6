using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Dataset.Model;

namespace Dataset
{
    public class Data
    {
        public static List<Client> LoadFromXML(string file = @"dataset.xml")
        {
            return Serialization.DeSerialize<List<Client>>(file);
        }
    }

    public static class XmlTools
    {
        public static string ToXmlString<T>(this T input)
        {
            using (var writer = new StringWriter())
            {
                input.ToXml(writer);
                return writer.ToString();
            }
        }
        public static void ToXml<T>(this T objectToSerialize, Stream stream)
        {
            new XmlSerializer(typeof(T)).Serialize(stream, objectToSerialize);
        }

        public static void ToXml<T>(this T objectToSerialize, StringWriter writer)
        {
            new XmlSerializer(typeof(T)).Serialize(writer, objectToSerialize);
        }
    }

    public class Serialization
    {
        public static bool Serialize<T>(T input, string outputFile)
        {
            try
            {
                // Serialization
                XmlSerializer s = new XmlSerializer(typeof(T));
                using (TextWriter w = new StreamWriter(outputFile))
                {
                    s.Serialize(w, input);
                }

                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        public static T DeSerialize<T>(string inputFile)
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            T newClass;
            using (TextReader r = new StreamReader(inputFile))
            {
                newClass = (T)s.Deserialize(r);
            }
            return newClass;
        }

        public static T DeSerializeString<T>(string inputContent)
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            T newClass;
            using (TextReader r = new StringReader(inputContent))
            {
                newClass = (T)s.Deserialize(r);
            }

            return newClass;
        }
    }
}