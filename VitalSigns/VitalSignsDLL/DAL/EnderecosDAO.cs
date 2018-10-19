using System.Collections.Generic;
using VitalSignsDLL.BLL;

namespace VitalSignsDLL.DAL
{
    interface EnderecosDAO
    {
        bool Inserir(Enderecos endereco);

        List<Enderecos> Listar();

        bool Atualizar(Enderecos endereco);

        bool Excluir(string cep);


    }
}
