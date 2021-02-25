using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogue_Generator
{
    public partial class NewCharacter : Form
    {
        public NewCharacter()
        {
            InitializeComponent();
        }

        public string nombre;

        private void okButton_Click(object sender, EventArgs e)
        {
            nombre = characterInitial.Text;
            characterInitial.Text = "";
        }
    }
}
