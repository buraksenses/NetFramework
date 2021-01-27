using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Udemy.SystemXMLKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlTextWriter XmlText = new XmlTextWriter(@"c:\XML\Personellerim.xml", System.Text.UTF8Encoding.UTF8);

            //XmlText.WriteComment("Xml İşlemleri");

            //XmlText.WriteStartElement("Personellerim");

            //XmlText.WriteStartElement("Personel");
            //XmlText.WriteAttributeString("ID", "1");
            //XmlText.WriteElementString("Isim", "Burak");
            //XmlText.WriteElementString("Soyisim", "Şenses");
            //XmlText.WriteElementString("EmailAdres", "buraksenses@gmail.com");
            //XmlText.WriteEndElement();
            //XmlText.WriteEndElement();
            //XmlText.Close();


            XmlReader read = XmlReader.Create("c:\\XML\\Personellerim.xml");

            while (read.Read())
            {
                Console.WriteLine($"{read.Name} - {read.Value}");
            }


        }
    }
}
