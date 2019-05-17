using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace CsharpPractices
{
    class Work
    {
        public static void Mapping<T>(T entity, string sourceFile, string targetFile)
        {
            var source = string.Empty;
            using (var read = new StreamReader(sourceFile))
            {
                source = read.ReadToEnd();
            }            
            foreach(var prop in entity.GetType().GetProperties())
            {
                source = source.Replace("@" + prop.Name.ToString(), prop.GetValue(entity).ToString());
            }
            using (var write = new StreamWriter(targetFile))
            {
                write.Write(source);
            }
        }
    }
}
