using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_contraseñas.Clases
{
    internal class ConfiguracionProteccion
    {
        public IConfiguration configuration()
        {
            string rutaJson = "C:\\Users\\felip\\Desktop\\Cosas\\Programacion\\C#\\Gestor contraseñas\\appsettings.json";
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(rutaJson, optional: false, reloadOnChange: true)
                .Build();
            return configuration;
        }
        
    }
}
