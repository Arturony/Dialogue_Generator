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
    public partial class Restrictions : Form
    {
        public Restrictions()
        {
            InitializeComponent();
        }

        public List<string> restrictions;

        public void CreateList(List<string> res)
        {
            restrictions = res;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string res = restrictionBox.Text;
            restrictionBox.Text = "";
            RestrictionList.Items.Add(res);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {      
            try
            {
                RestrictionList.Items.RemoveAt(RestrictionList.SelectedIndex);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            foreach(Object o in RestrictionList.Items)
            {
                string s = (string) o;
                restrictions.Add(s);
            }
        }
    }
}
