using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SextoDesafio.Empresa
{
    internal class Analista : Funcionarios
    {
        public string AreaDeAtuação { get; set; }
        public string Detalhes => $"O Analista de {AreaDeAtuação} {Nome} é responsavel por manter o setor, recebe um salário de R${Salario}\n";
    }
}
