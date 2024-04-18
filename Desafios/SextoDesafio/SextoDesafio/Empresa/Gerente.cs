using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SextoDesafio.Empresa
{
    internal class Gerente : Funcionarios
    {
        public string Setor { get; set; }
        public string Detalhes => $"O Gerente {Nome} resposável pelo setor {Setor}, recebe um salário de R${Salario}\n"; 
    }
}
