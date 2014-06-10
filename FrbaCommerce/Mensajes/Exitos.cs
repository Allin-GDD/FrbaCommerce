﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Mensajes
{
    class Exitos
    {

        public static void ExitosAlActualizarLosDatos()
        {
            MessageBox.Show("Los datos han sido modificados satisfactoriamente. El sistema se reiniciará", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void ExitoAlGuardaLosDatos()
        {
            MessageBox.Show("Datos guardados exitosamente", "Guardado de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ExitoAlBorrarLosDatos()
        {
            MessageBox.Show("Se ha dado de baja correctamente", "Baja de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        }
    }

