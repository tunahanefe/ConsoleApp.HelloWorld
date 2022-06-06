using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.HelloWorld
{
    class Model
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        
        public string IsimYazdir()
        {
            return $"Hoşgeldiniz, {this.Adi} {this.Soyadi}.";
        }
    }
}
