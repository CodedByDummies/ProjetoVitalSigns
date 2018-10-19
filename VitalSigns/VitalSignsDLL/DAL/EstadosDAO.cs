using System.Collections.Generic;
using System.Data.Common;
using VitalSignsDLL.BLL;

namespace VitalSignsDLL.DAL
{
    interface EstadosDAO
    {
        bool Inserir(Estados estado);
        List<Estados> Listar();

        bool Atualizar(Estados estado);

        bool Excluir(long idEstado);
    }
}
