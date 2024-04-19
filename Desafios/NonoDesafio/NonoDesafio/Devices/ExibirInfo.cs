using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonoDesafio.Devices
{
    internal class ExibirInfo
    {
        public string NomeDevice { get; set; }
        public string Processador { get; set; }
        public string Ram { get; set; }
        public string Armazenamento { get; set;}
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Dispositivo: {NomeDevice}\nProcessador: {Processador}\nRAM: {Ram}\nArmazenamento: {Armazenamento}\n");
        }
    }
}
