using MateoProgreso2.Interfaces;
using MateoProgreso2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;


namespace MateoProgreso2.Repositories
{
   
    public class RecargaRepository : IRecarga
    {
        
        public string _fileName = Path.Combine(FileSystem.AppDataDirectory, "MateoSotomayor.txt");

       
        public bool CrearRecarga(Recarga recarga)
        {
            try
            {
                var recargas = DevuelveListRecarga();

                recargas.Add(recarga);

                var json = JsonSerializer.Serialize(recargas);

                File.WriteAllText(_fileName, json);

                return true; 
            }
            catch
            {
                return false; 
            }
        }

       
        public List<Recarga> DevuelveListRecarga()
        {
            try
            {
                
                if (File.Exists(_fileName))
                {
                    
                    var json = File.ReadAllText(_fileName);

                   
                    return JsonSerializer.Deserialize<List<Recarga>>(json) ?? new List<Recarga>();
                }

               
                return new List<Recarga>();
            }
            catch
            {
                return new List<Recarga>();  
            }
        }

       
        public Recarga DevuelveRecarg(int Id)
        {
            var recargas = DevuelveListRecarga();  

            return recargas.FirstOrDefault(r => r.Id == Id);
        }
    }
}
