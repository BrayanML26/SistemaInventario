using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventario
{
    class DatosReporte
    {

    }

    public class DatosUsu
    {
        public int CodUsuario { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public Boolean Status { get; set; }

    }

    public class DatosCli
    {
        public int codcli { get; set; }
        public string nomcli { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public Boolean status { get; set; }

    }

    public class DatosSup
    {
        public int codsup { get; set; }
        public string nomsup { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public Boolean status { get; set; }
    }

    public class DatosProd
    {
        public int codpro { get; set; }
        public string nompro { get; set; }
        public double preven { get; set; }
        public double precom { get; set; }
        public double exipro { get; set; }
        public double punreo { get; set; }
        public Boolean status { get; set; }
        public int coddep { get; set; }
    }

    public class DatosUnid
    {
        public int coduni { get; set; }
        public string desuni { get; set; }
        public Boolean status { get; set; }
    }

    public class DatosDep
    {
        public int coddep { get; set; }
        public string desdep { get; set; }
        public Boolean status { get; set; }
    }

    public class DatosVentas
    {
        public int numfac { get; set; }
        public DateTime fecfac { get; set; }
        public int codcli { get; set; }
        public Boolean status { get; set; }
        public string nomcli { get; set; }
        public string email { get; set; }
        public double canven { get; set; }
        public double preven { get; set; }
        public double importe { get; set; }
        public int codpro { get; set; }
        public string nompro { get; set; }
        
    }

    public class DatosCompras
    {
        public int numfac { get; set; }
        public DateTime fecfac { get; set; }
        public int codsup { get; set; }
        public Boolean status { get; set; }
        public string nomsup { get; set; }
        public string email { get; set; }
        public double cancom { get; set; }
        public double precom { get; set; }
        public double importe { get; set; }
        public int codpro { get; set; }
        public string nompro { get; set; }

    }

}
