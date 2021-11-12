using Newtonsoft.Json;
using strategy.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace strategy.Services
{
    public class ExcelService : IStrategy
    {
        public void GuardarLog(FormData formData)
        {
            string json = JsonConvert.SerializeObject(formData);
    
            string userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string downloadPath = Path.Combine(userPath, "Downloads\\log.xlsx");

            using(StreamWriter writer = new StreamWriter(downloadPath, true))
            {
                writer.WriteLine(json);
            }
        }

        public List<FormData> LeerLog()
        {
            string pathUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string readPath = Path.Combine(pathUser, "Downloads\\log.xlsx");

            List<FormData> datos = new List<FormData>();

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(readPath).ToList();

            foreach (String line in lines)
            {
                FormData dato = JsonConvert.DeserializeObject<FormData>(line);
                datos.Add(dato);
            } 

            return datos;
        }
    }
}