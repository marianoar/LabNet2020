using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errores
{
    public static class SaveLogs
    {
        static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/logs.txt");
        
        public static void Save(bool append, string message)
        {
            StreamWriter streamWriter = null;
            try
            {
                if (File.Exists(path))
                {
                    streamWriter = new StreamWriter(path, append, Encoding.UTF8);
                    streamWriter.WriteLine(message);
                }
                else
                {
                    File.Create(path);
                    streamWriter = new StreamWriter(path, append, Encoding.UTF8);
                    streamWriter.WriteLine(message);
                }

            }
            catch
            {
                throw new Exception("Ocurrio un error al grabar archivo logs");
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }
        }

        public static void Save(Exception ex, bool append)
        {
            StreamWriter streamWriter = null;
            try
            {
                if (File.Exists(path))
                {
                    streamWriter = new StreamWriter(path, append, Encoding.UTF8);
                    streamWriter.WriteLine(ex.Message);
                }
                else
                {
                    File.Create(path);
                    streamWriter = new StreamWriter(path, append, Encoding.UTF8);
                    streamWriter.WriteLine(ex.Message);
                }

            }
            catch
            {
                throw new Exception("Ocurrio un error al grabar archivo logs");
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }
        }

    }
}
