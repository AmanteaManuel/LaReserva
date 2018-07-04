using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bol
{
    public class Producto
    {
        #region " Atributes "

        private int _id;
        private int _stock;
        private double _costo;
        private double _valor;
        private string _descripcion;


        #endregion

        #region " Properties "

        public int Id { get; set; }

        /// <summary>
        /// Stock del Producto
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// Costo real del producto (costo de lista)
        /// </summary>
        public double Costo { get; set; }


        /// <summary>
        /// Costo al cliente del producto
        /// </summary>
        public double Valor { get; set; }

        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string Descripcion { get; set; }

        #endregion

        #region " Fill "
        #endregion

        #region " View "
        #endregion

    }
}
