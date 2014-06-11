using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Entidades
{
    class Ent_ValidacionesUtil
    {
        public TextBox Dpto { get; set; }
        public TextBox Piso { get; set; }
        public TextBox NroCalle { get; set; }
        public MaskedTextBox Fecha { get; set; }
        public MaskedTextBox CUIT { get; set; }
        public MaskedTextBox CUITAnt { get; set; }
        public TextBox DNI { get; set; }
        public TextBox DNIAnt { get; set; }
        public MaskedTextBox Telefono { get; set; }
        public MaskedTextBox TelefonoAnt { get; set; }
    }
}
