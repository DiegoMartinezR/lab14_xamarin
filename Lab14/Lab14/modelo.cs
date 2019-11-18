using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14
{
    public class modelo
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Fecha { get; set; }

    }
}
