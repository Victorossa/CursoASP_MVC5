using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   public class FileHelper
    {
        //creamos un Metodo Publico que nos devuelva una lista 
        public List<object> GetFileSystemObjects(string path)
        {
            var di = new DirectoryInfo(path);
            var listaInfo = di.EnumerateDirectories
            
        }
    }
}
