﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Mensajes
{
    class Exitos
    {
        public static void ExitoAlGuardaLosDatos()
        {
            MessageBox.Show("Datos guardados exitosamente", "Guardar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ExitoAlBorrarLosDatos()
        {
            MessageBox.Show("El usuario se ha dado de baja", "Baja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        }
    }

