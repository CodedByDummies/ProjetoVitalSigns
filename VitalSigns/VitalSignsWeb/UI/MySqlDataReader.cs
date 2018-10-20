using System;
using System.Data.Common;

namespace VitalSignsWeb.UI
{
    internal class MySqlDataReader
    {
        public static explicit operator MySqlDataReader(DbDataReader v)
        {
            throw new NotImplementedException();
        }

        internal bool Read()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}