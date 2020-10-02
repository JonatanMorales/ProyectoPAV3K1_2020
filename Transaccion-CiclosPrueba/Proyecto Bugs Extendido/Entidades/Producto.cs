﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bugs_Extendido.Entidades
{
    class Producto
    {
        private int id_producto;
        private string nombre;
        private int borrado;

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Borrado { get => borrado; set => borrado = value; }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
