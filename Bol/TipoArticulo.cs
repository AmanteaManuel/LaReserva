using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bol
{
   public class TipoArticulo
    {
        #region " Atributes "
        #endregion

        #region " Properties "

        public int Id { get; set; }

        public int Descripcion { get; set; }

        #endregion

        #region " Fill "
        #endregion

        #region " View "

        internal static TipoArticulo GetById(int tipoArticuloId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
