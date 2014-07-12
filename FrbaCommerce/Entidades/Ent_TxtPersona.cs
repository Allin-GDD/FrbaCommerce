using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Entidades
{
    class Ent_TxtPersona
    {
        public TextBox Dpto { get; set; }
        public TextBox Piso { get; set; }
        public TextBox NroCalle { get; set; }
        public Int16 TipoDoc { get; set; }
        public Int16 TipoDocAnt { get; set; }
        public MaskedTextBox Fecha { get; set; }
        public MaskedTextBox CUIT { get; set; }
        public MaskedTextBox CUITAnt { get; set; }
        public MaskedTextBox DNI { get; set; }
        public MaskedTextBox DNIAnt { get; set; }
        public MaskedTextBox Telefono { get; set; }
        public MaskedTextBox TelefonoAnt { get; set; }
        public TextBox Mail { get; set; }
    }
}
