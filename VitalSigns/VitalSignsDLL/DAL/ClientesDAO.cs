using System.Collections.Generic;
using VitalSignsDLL.BLL;

namespace VitalSignsDLL.DAL
{
    interface ClientesDAO
    {
        bool Inserir(Clientes cliente);

        List<Clientes> Listar();

        bool Atualizar(Clientes cliente);

        bool Excluir(string cpf_cnpj);
    }
}
