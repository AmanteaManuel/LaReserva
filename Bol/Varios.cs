using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bol
{
    public class Varios : Producto
    {
        #region " Atributes "
        #endregion

        #region " Properties "

        public int TipoArticuloId { get; set; }

        public TipoArticulo TipoArticulo
        {
            get
            {
                return Bol.TipoArticulo.GetById(TipoArticuloId);
            }
        }

        #endregion

        #region " Fill "
        #endregion

        #region " View "
        #endregion
    }
}
