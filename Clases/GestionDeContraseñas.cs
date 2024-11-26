using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Gestor_contraseñas.Clases
{
    internal class GestionDeContraseñas
    {

        private string rutaBase = "C:\\Users\\felip\\Desktop\\Cosas\\Programacion\\C#\\Gestor contraseñas\\Base.txt";
        private readonly byte[] clave = GenerarClave("ClaveSecreta1234");
        private readonly byte[] iv = GenerarClave("VectorInicial1234");

        public void guardarContraseñas(ListBox lbx1)
        {
            if (lbx1.Items.Count == 0)
            {
                MessageBox.Show("No hay contraseñas para guardar");
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(rutaBase))
                {                  
                    foreach (var item in lbx1.Items)
                    {
                        string itemCifrado = Cifrar(item.ToString());
                        writer.WriteLine(itemCifrado);
                    }
                }

                MessageBox.Show("Items guardados en " + rutaBase);
            }
        }

        public List<string> cargarContraseñas()
        {
            List<string> items = new List<string>();

            if (File.Exists(rutaBase))
            {
                using (StreamReader reader = new StreamReader(rutaBase))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string itemDescifrado = Descifrar(line);
                        items.Add(itemDescifrado);
                    }
                }
            }
            else
            {
                MessageBox.Show("El archivo no existe.");
            }

            return items;
        }

        private string Cifrar(string textoPlano)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = clave;
                aes.IV = iv;

                ICryptoTransform cifrador = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream ms = new MemoryStream())
                using (CryptoStream cs = new CryptoStream(ms, cifrador, CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(textoPlano);
                    }

                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        private string Descifrar(string textoCifrado)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = clave;
                aes.IV = iv;

                ICryptoTransform descifrador = aes.CreateDecryptor(aes.Key, aes.IV);
                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(textoCifrado)))
                using (CryptoStream cs = new CryptoStream(ms, descifrador, CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }
        private static byte[] GenerarClave(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));
                byte[] clave16Bytes = new byte[16];
                Array.Copy(hash, clave16Bytes, 16);
                return clave16Bytes;
            }
        }
    }
}
