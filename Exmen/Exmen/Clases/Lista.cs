using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Exmen
{
    [Serializable()]
    public static class Lista
    {
        public static List<Usuario> u21 = new List<Usuario>();


        public static void SerializarC(List<Usuario> plistaPersona)
        {
            FileStream _fs = new FileStream(@"..\..\docs\cliente.dat", FileMode.Create);
            BinaryFormatter _formatter = new BinaryFormatter();
            _formatter.Serialize(_fs, plistaPersona);
            _fs.Close();
        }
        public static List<Usuario> DeserializarC(string pArchivo)
        {
            if (File.Exists(@"..\..\docs\" + pArchivo) == true)
            {
                FileStream _fs = new FileStream(@"..\..\docs\" + pArchivo, FileMode.Open);
                BinaryFormatter _formatter = new BinaryFormatter();
                List<Usuario> _persona = _formatter.Deserialize(_fs) as List<Usuario>;
                _fs.Close();
                return _persona;
            }
            return new List<Usuario>();
        }
    }
}
