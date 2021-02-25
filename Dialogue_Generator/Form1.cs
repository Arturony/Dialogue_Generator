using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Dialogue_Generator
{
    public partial class DialogueGenerator : Form
    {
        private Graph graph;

        public DialogueGenerator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();   
            saveFileDialog1.Title = "Save Dialogue File";
            saveFileDialog1.DefaultExt = "json";
            saveFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 0;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //valid path. save file
                File.WriteAllText(saveFileDialog1.FileName, JsonConvert.SerializeObject(graph));
            }
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NodeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Remove previous information
            EdgeList.Items.Clear();

            string s = (String)NodeList.Items[NodeList.SelectedIndex];

            Node n = graph.GetNode(s);

            nodeKeyText.Text = n.key;
            nodeValueText.Text = n.value;
            interactionCheck.Checked = n.reviwable;

            edgeFromText.Text = n.key;

            foreach(Edge edge in n.getAllEdges())
            {
                EdgeList.Items.Add(edge.key);
            }
        }

        private void EdgeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string se = (string)EdgeList.Items[EdgeList.SelectedIndex];

            string sn = (String)NodeList.Items[NodeList.SelectedIndex];

            Edge edge = graph.GetNode(sn).getNode(se);

            edgeKeyText.Text = edge.key;
            edgeValueText.Text = edge.value;
            edgeFromText.Text = edge.from;
            edgeToText.Text = edge.to;

        }

        private void nodeAdd_Click(object sender, EventArgs e)
        {
            string key = nodeKeyText.Text;

            string value = nodeValueText.Text;

            bool check = interactionCheck.Checked;

            Node n = new Node(key, value, check);

           try
            {
                graph.AddNode(n);

                ResetNode();

                NodeList.Items.Add(n.key);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void edgeAdd_Click(object sender, EventArgs e)
        {
            string key = edgeKeyText.Text;

            string value = edgeValueText.Text;

            string from = edgeFromText.Text;

            string to = edgeToText.Text;

            Edge edge = new Edge(key, value, from, to);

            try
            {
                graph.GetNode(from).AddEdge(edge);

                ResetEdge();

                //refresh selected node edges
                EdgeList.Items.Clear();

                string s = (String)NodeList.Items[NodeList.SelectedIndex];

                Node n = graph.GetNode(s);

                foreach (Edge ed in n.getAllEdges())
                {
                    EdgeList.Items.Add(ed.key);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

        private void ResetNode()
        {
            nodeKeyText.Text = "";
            nodeValueText.Text = "";
            interactionCheck.Checked = false;
        }

        private void ResetEdge()
        {
            edgeKeyText.Text = "";
            edgeValueText.Text = "";
            edgeFromText.Text = "";
            edgeToText.Text = "";
        }

        private void restrictionsButton_Click(object sender, EventArgs e)
        {

        }

        private void removeNodeButton_Click(object sender, EventArgs e)
        {
            string key = nodeKeyText.Text;

            try
            {
                graph.RemoveNode(key);

                ResetNode();

                NodeList.Items.Clear();

                foreach (Node n in graph.getAllNodes())
                {
                    NodeList.Items.Add(n.key);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void edgeRemoveButton_Click(object sender, EventArgs e)
        {
            string key = edgeKeyText.Text;

            try
            {
                graph.GetNode(edgeFromText.Text).RemoveEdge(key);

                ResetEdge();

                EdgeList.Items.Clear();

                string s = (String)NodeList.Items[NodeList.SelectedIndex];

                Node n = graph.GetNode(s);

                foreach (Edge ed in n.getAllEdges())
                {
                    EdgeList.Items.Add(ed.key);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    string text = sr.ReadToEnd();
                    sr.Close();

                    graph = JsonConvert.DeserializeObject<Graph>(text);

                    NodeList.Items.Clear();

                    NodeList.Items.Clear();

                    characterName.Text = graph.name;

                    foreach (Node n in graph.getAllNodes())
                    {
                        NodeList.Items.Add(n.key);
                    }

                    if(NodeList.Items.Count > 0)
                    {
                        NodeList.SelectedIndex = 0;

                        EdgeList.Items.Clear();

                        string s = (String)NodeList.Items[NodeList.SelectedIndex];

                        Node n = graph.GetNode(s);

                        foreach (Edge ed in n.getAllEdges())
                        {
                            EdgeList.Items.Add(ed.key);
                        }
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void graphNameButton_Click(object sender, EventArgs e)
        {
            string name = graphText.Text;

            graph.name = name;

            characterName.Text = name;

            graphText.Text = "";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            NewCharacter character = new NewCharacter();
            DialogResult dialogResult = character.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                characterName.Text = character.nombre;
                graph = new Graph("");
                NodeList.Items.Clear();
                EdgeList.Items.Clear();
                ResetNode();
                ResetEdge();
                graphText.Text = "";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelBanner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
              
        }
    }
}
