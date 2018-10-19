using System.Collections.Generic;
using VitalSignsDLL.BLL;

namespace VitalSignsDLL.DAL
{
    interface CidadesDAO
    {
        bool Inserir(Cidades cidade );

        List<Cidades> Listar();

        bool Atualizar(Cidades cidade);

        bool Excluir(long idCidade);
    }
}
