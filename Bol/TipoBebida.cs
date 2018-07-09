using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bol
{
    public class TipoBebida
    {

        #region " Properties "

        public int Id { get; set; }

        public int Descripcion { get; set; }

        #endregion

        #region " View "

        internal static TipoBebida GetById(int tipoBebidaId)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
