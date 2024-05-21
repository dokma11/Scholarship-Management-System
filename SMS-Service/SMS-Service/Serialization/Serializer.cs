using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SMS_Service.Serialization
{
    class Serializer<T> where T : ISerializable, new()
    {
        private const char DELIMITER = '|';

        public void ToCSV(string fileName, List<T> objects)
        {
            StringBuilder csv = new StringBuilder();

            foreach (T obj in objects)
            {
                string line = string.Join(DELIMITER.ToString(), obj.ToCSV());
                csv.AppendLine(line);
            }

            File.WriteAllText(fileName, csv.ToString());

        }

        public List<T> FromCSV(string fileName)
        {
            List<T> objects = new List<T>();

            if (!File.Exists(fileName))
            {
                FileStream fs = File.Create(fileName);
                fs.Close();
            }

            foreach (string line in File.ReadLines(fileName))
            {
                string[] csvValues = line.Split(DELIMITER);
                T obj = new T();
                obj.FromCSV(csvValues);
                objects.Add(obj);
            }

            return objects;
        }
    }
}