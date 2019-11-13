using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace CRUD_con_SQLite.Clases
{
    class Registros
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }
        public string Nombreguitarra { get; set; }
        public string Precio { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public override string ToString()
        {
            return $"{Nombreguitarra} - {Precio} - {Telefono} - {Direccion}";
        }


    }
}
