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
    public partial class Restriction : Form
    {
        public Restriction()
        {
            InitializeComponent();
        }

        private void Restriction_Load(object sender, EventArgs e)
        {

        }

        public List<string> restrictiones;

        public void CreateList(List<string> res)
        {
            restrictiones = new List<string>();
            foreach(string s in res)
            {
                RestrictionList.Items.Add(s);
            }
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            string res = restrictionBox.Text;
            restrictionBox.Text = "";
            RestrictionList.Items.Add(res);
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                RestrictionList.Items.RemoveAt(RestrictionList.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void finishButton_Click_1(object sender, EventArgs e)
        {
            foreach (Object o in RestrictionList.Items)
            {
                string s = (string)o;
                restrictiones.Add(s);
            }
        }
    }
}
