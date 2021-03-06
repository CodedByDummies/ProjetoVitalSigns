﻿using System.Data.Common;
using System.Data;

namespace VitalSignsDLL.DAL
{
    public interface IConexao
    {
        ConnectionState AbrirConexao();

        ConnectionState FecharConexao();

        int ExecutarSemConsulta(string cmd);

        DbDataReader ExecutarConsulta(string cmd);
    }
}
