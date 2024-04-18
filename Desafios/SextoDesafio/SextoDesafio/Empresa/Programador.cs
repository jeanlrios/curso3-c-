using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SextoDesafio.Empresa
{
    internal class Programador : Funcionarios
    {
        public string LinguagemProgramação { get; set; }
        public string Detalhes => $"O Programador {Nome} programa na linguagem {LinguagemProgramação}, recebe um salário de R${Salario}\n";
    }
}
