﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bol
{
    public class Bebida : Producto
    {
        #region " Atributes "
        #endregion

        #region " Properties "

        public int TipoBebidaId { get; set; }

        public TipoBebida TipoBebida
        {
            get
            {
                return Bol.TipoBebida.GetById(TipoBebidaId);
            }
        }

        #endregion


        #region " Fill "
        #endregion

        #region " View "
        #endregion
    }
}
