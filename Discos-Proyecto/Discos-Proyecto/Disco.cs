﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discos_Proyecto
{
    internal class Disco
    {
        public string Titulo { get; set; }

        public int CantidadDeCanciones { get; set; }

        public DateTime FechaLanzamiento { get; set; }

        public string UrlImagenTapa { get; set; }
    }
}
