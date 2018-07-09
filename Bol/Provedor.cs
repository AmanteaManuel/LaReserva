using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bol
{
    public class Provedor
    {
        #region " Atributes "

        private string _nombre;
        private string _apellido;
        private int _id;
        private double _deuda;

        #endregion

        #region " Properties "

        public double Deuda { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public int Id { get; set; }

        #endregion

        #region " Fill "
        #endregion

        #region " View "

        public static Provedor GetById(int provedorId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
