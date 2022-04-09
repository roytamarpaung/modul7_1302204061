using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace modul7_1302204061
{
    class Program
    {
        static void Main (string[] args)
        {

            Console.WriteLine("Language: (en/id)");
            String pilBahasa = Console.ReadLine();

            if (pilBahasa == "en")
            {
                Console.WriteLine();

            }
            else
            {

                Console.WriteLine();
            }
        }



    }

    class PesanAwalConfig
    {
        public string en { get; set; }
        public string id { get; set; }

        public PesanAwalConfig() { }

        public PesanAwalConfig(string en, string id)
        {
            this.en = en;
            this.id = id;
        }
    }

    class confirmationConfig
    {
        public string en { get; set; }
        public string id { get; set; }

        public confirmationConfig() { }
        public confirmationConfig(string en, string id)
        {
            this.en = en;
            this.id = id;
        }

        private void confirmationconfig(string en, string id)
        {
            //membuat object konfigurasi 
            confirmationConfig config = new confirmationConfig();

        }
    }
}


