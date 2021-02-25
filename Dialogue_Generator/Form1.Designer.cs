
namespace Dialogue_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBanner = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EdgePanel = new System.Windows.Forms.Panel();
            this.edgeFromText = new System.Windows.Forms.TextBox();
            this.edgeToText = new System.Windows.Forms.TextBox();
            this.edgeFromLabel = new System.Windows.Forms.Label();
            this.edgeAdd = new System.Windows.Forms.Button();
            this.edgeToLabel = new System.Windows.Forms.Label();
            this.edgeKeyText = new System.Windows.Forms.TextBox();
            this.edgeKeyLabel = new System.Windows.Forms.Label();
            this.edgeTitle = new System.Windows.Forms.Label();
            this.edgeValueText = new System.Windows.Forms.TextBox();
            this.edgeValueLabel = new System.Windows.Forms.Label();
            this.EdgeList = new System.Windows.Forms.ListBox();
            this.nodePanel = new System.Windows.Forms.Panel();
            this.restrictionsButton = new System.Windows.Forms.Button();
            this.nodeAdd = new System.Windows.Forms.Button();
            this.interactionCheck = new System.Windows.Forms.CheckBox();
            this.interactionLabel = new System.Windows.Forms.Label();
            this.nodeValueLabel = new System.Windows.Forms.Label();
            this.nodeValueText = new System.Windows.Forms.TextBox();
            this.nodeKeyText = new System.Windows.Forms.TextBox();
            this.nodeKeyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NodeList = new System.Windows.Forms.ListBox();
            this.removeNodeButton = new System.Windows.Forms.Button();
            this.edgeRemoveButton = new System.Windows.Forms.Button();
            this.graphName = new System.Windows.Forms.Label();
            this.graphText = new System.Windows.Forms.TextBox();
            this.graphNameButton = new System.Windows.Forms.Button();
            this.characterName = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.panelBanner.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.EdgePanel.SuspendLayout();
            this.nodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save                 ";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load                ";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorialToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tutorialToolStripMenuItem.Text = "Tutorial";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versionToolStripMenuItem.Text = "Dialogue Creator";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // panelBanner
            // 
            this.panelBanner.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelBanner.Controls.Add(this.characterName);
            this.panelBanner.Controls.Add(this.graphNameButton);
            this.panelBanner.Controls.Add(this.graphText);
            this.panelBanner.Controls.Add(this.graphName);
            this.panelBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBanner.Location = new System.Drawing.Point(0, 24);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(712, 71);
            this.panelBanner.TabIndex = 1;
            this.panelBanner.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBanner_Paint);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.EdgePanel);
            this.MainPanel.Controls.Add(this.EdgeList);
            this.MainPanel.Controls.Add(this.nodePanel);
            this.MainPanel.Controls.Add(this.NodeList);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 95);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(712, 416);
            this.MainPanel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Edges";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nodes";
            // 
            // EdgePanel
            // 
            this.EdgePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EdgePanel.Controls.Add(this.edgeRemoveButton);
            this.EdgePanel.Controls.Add(this.edgeFromText);
            this.EdgePanel.Controls.Add(this.edgeToText);
            this.EdgePanel.Controls.Add(this.edgeFromLabel);
            this.EdgePanel.Controls.Add(this.edgeAdd);
            this.EdgePanel.Controls.Add(this.edgeToLabel);
            this.EdgePanel.Controls.Add(this.edgeKeyText);
            this.EdgePanel.Controls.Add(this.edgeKeyLabel);
            this.EdgePanel.Controls.Add(this.edgeTitle);
            this.EdgePanel.Controls.Add(this.edgeValueText);
            this.EdgePanel.Controls.Add(this.edgeValueLabel);
            this.EdgePanel.Location = new System.Drawing.Point(183, 207);
            this.EdgePanel.Name = "EdgePanel";
            this.EdgePanel.Size = new System.Drawing.Size(348, 201);
            this.EdgePanel.TabIndex = 2;
            // 
            // edgeFromText
            // 
            this.edgeFromText.Enabled = false;
            this.edgeFromText.Location = new System.Drawing.Point(48, 137);
            this.edgeFromText.Name = "edgeFromText";
            this.edgeFromText.Size = new System.Drawing.Size(100, 20);
            this.edgeFromText.TabIndex = 2;
            // 
            // edgeToText
            // 
            this.edgeToText.Location = new System.Drawing.Point(48, 165);
            this.edgeToText.Name = "edgeToText";
            this.edgeToText.Size = new System.Drawing.Size(100, 20);
            this.edgeToText.TabIndex = 2;
            // 
            // edgeFromLabel
            // 
            this.edgeFromLabel.AutoSize = true;
            this.edgeFromLabel.Location = new System.Drawing.Point(6, 140);
            this.edgeFromLabel.Name = "edgeFromLabel";
            this.edgeFromLabel.Size = new System.Drawing.Size(30, 13);
            this.edgeFromLabel.TabIndex = 1;
            this.edgeFromLabel.Text = "From";
            // 
            // edgeAdd
            // 
            this.edgeAdd.Location = new System.Drawing.Point(259, 165);
            this.edgeAdd.Name = "edgeAdd";
            this.edgeAdd.Size = new System.Drawing.Size(75, 23);
            this.edgeAdd.TabIndex = 4;
            this.edgeAdd.Text = "Add";
            this.edgeAdd.UseVisualStyleBackColor = true;
            this.edgeAdd.Click += new System.EventHandler(this.edgeAdd_Click);
            // 
            // edgeToLabel
            // 
            this.edgeToLabel.AutoSize = true;
            this.edgeToLabel.Location = new System.Drawing.Point(6, 168);
            this.edgeToLabel.Name = "edgeToLabel";
            this.edgeToLabel.Size = new System.Drawing.Size(20, 13);
            this.edgeToLabel.TabIndex = 1;
            this.edgeToLabel.Text = "To";
            // 
            // edgeKeyText
            // 
            this.edgeKeyText.Location = new System.Drawing.Point(48, 29);
            this.edgeKeyText.Name = "edgeKeyText";
            this.edgeKeyText.Size = new System.Drawing.Size(100, 20);
            this.edgeKeyText.TabIndex = 2;
            // 
            // edgeKeyLabel
            // 
            this.edgeKeyLabel.AutoSize = true;
            this.edgeKeyLabel.Location = new System.Drawing.Point(6, 32);
            this.edgeKeyLabel.Name = "edgeKeyLabel";
            this.edgeKeyLabel.Size = new System.Drawing.Size(25, 13);
            this.edgeKeyLabel.TabIndex = 1;
            this.edgeKeyLabel.Text = "Key";
            // 
            // edgeTitle
            // 
            this.edgeTitle.AutoSize = true;
            this.edgeTitle.Location = new System.Drawing.Point(7, 10);
            this.edgeTitle.Name = "edgeTitle";
            this.edgeTitle.Size = new System.Drawing.Size(32, 13);
            this.edgeTitle.TabIndex = 0;
            this.edgeTitle.Text = "Edge";
            this.edgeTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // edgeValueText
            // 
            this.edgeValueText.Location = new System.Drawing.Point(48, 64);
            this.edgeValueText.Multiline = true;
            this.edgeValueText.Name = "edgeValueText";
            this.edgeValueText.Size = new System.Drawing.Size(286, 67);
            this.edgeValueText.TabIndex = 2;
            // 
            // edgeValueLabel
            // 
            this.edgeValueLabel.AutoSize = true;
            this.edgeValueLabel.Location = new System.Drawing.Point(6, 60);
            this.edgeValueLabel.Name = "edgeValueLabel";
            this.edgeValueLabel.Size = new System.Drawing.Size(34, 13);
            this.edgeValueLabel.TabIndex = 1;
            this.edgeValueLabel.Text = "Value";
            // 
            // EdgeList
            // 
            this.EdgeList.FormattingEnabled = true;
            this.EdgeList.Location = new System.Drawing.Point(537, 40);
            this.EdgeList.Name = "EdgeList";
            this.EdgeList.Size = new System.Drawing.Size(165, 368);
            this.EdgeList.TabIndex = 2;
            this.EdgeList.SelectedIndexChanged += new System.EventHandler(this.EdgeList_SelectedIndexChanged);
            // 
            // nodePanel
            // 
            this.nodePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nodePanel.Controls.Add(this.removeNodeButton);
            this.nodePanel.Controls.Add(this.restrictionsButton);
            this.nodePanel.Controls.Add(this.nodeAdd);
            this.nodePanel.Controls.Add(this.interactionCheck);
            this.nodePanel.Controls.Add(this.interactionLabel);
            this.nodePanel.Controls.Add(this.nodeValueLabel);
            this.nodePanel.Controls.Add(this.nodeValueText);
            this.nodePanel.Controls.Add(this.nodeKeyText);
            this.nodePanel.Controls.Add(this.nodeKeyLabel);
            this.nodePanel.Controls.Add(this.label1);
            this.nodePanel.Location = new System.Drawing.Point(183, 6);
            this.nodePanel.Name = "nodePanel";
            this.nodePanel.Size = new System.Drawing.Size(348, 195);
            this.nodePanel.TabIndex = 1;
            // 
            // restrictionsButton
            // 
            this.restrictionsButton.Location = new System.Drawing.Point(48, 154);
            this.restrictionsButton.Name = "restrictionsButton";
            this.restrictionsButton.Size = new System.Drawing.Size(75, 23);
            this.restrictionsButton.TabIndex = 5;
            this.restrictionsButton.Text = "Restrictions";
            this.restrictionsButton.UseVisualStyleBackColor = true;
            this.restrictionsButton.Click += new System.EventHandler(this.restrictionsButton_Click);
            // 
            // nodeAdd
            // 
            this.nodeAdd.Location = new System.Drawing.Point(259, 154);
            this.nodeAdd.Name = "nodeAdd";
            this.nodeAdd.Size = new System.Drawing.Size(75, 23);
            this.nodeAdd.TabIndex = 4;
            this.nodeAdd.Text = "Add";
            this.nodeAdd.UseVisualStyleBackColor = true;
            this.nodeAdd.Click += new System.EventHandler(this.nodeAdd_Click);
            // 
            // interactionCheck
            // 
            this.interactionCheck.AutoSize = true;
            this.interactionCheck.Location = new System.Drawing.Point(111, 134);
            this.interactionCheck.Name = "interactionCheck";
            this.interactionCheck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.interactionCheck.Size = new System.Drawing.Size(15, 14);
            this.interactionCheck.TabIndex = 3;
            this.interactionCheck.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.interactionCheck.UseVisualStyleBackColor = true;
            this.interactionCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // interactionLabel
            // 
            this.interactionLabel.AutoSize = true;
            this.interactionLabel.Location = new System.Drawing.Point(6, 135);
            this.interactionLabel.Name = "interactionLabel";
            this.interactionLabel.Size = new System.Drawing.Size(99, 13);
            this.interactionLabel.TabIndex = 1;
            this.interactionLabel.Text = "Unique interaction?";
            // 
            // nodeValueLabel
            // 
            this.nodeValueLabel.AutoSize = true;
            this.nodeValueLabel.Location = new System.Drawing.Point(6, 57);
            this.nodeValueLabel.Name = "nodeValueLabel";
            this.nodeValueLabel.Size = new System.Drawing.Size(34, 13);
            this.nodeValueLabel.TabIndex = 1;
            this.nodeValueLabel.Text = "Value";
            // 
            // nodeValueText
            // 
            this.nodeValueText.Location = new System.Drawing.Point(48, 61);
            this.nodeValueText.Multiline = true;
            this.nodeValueText.Name = "nodeValueText";
            this.nodeValueText.Size = new System.Drawing.Size(286, 67);
            this.nodeValueText.TabIndex = 2;
            // 
            // nodeKeyText
            // 
            this.nodeKeyText.Location = new System.Drawing.Point(48, 28);
            this.nodeKeyText.Name = "nodeKeyText";
            this.nodeKeyText.Size = new System.Drawing.Size(100, 20);
            this.nodeKeyText.TabIndex = 2;
            // 
            // nodeKeyLabel
            // 
            this.nodeKeyLabel.AutoSize = true;
            this.nodeKeyLabel.Location = new System.Drawing.Point(6, 31);
            this.nodeKeyLabel.Name = "nodeKeyLabel";
            this.nodeKeyLabel.Size = new System.Drawing.Size(25, 13);
            this.nodeKeyLabel.TabIndex = 1;
            this.nodeKeyLabel.Text = "Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Node";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NodeList
            // 
            this.NodeList.FormattingEnabled = true;
            this.NodeList.Location = new System.Drawing.Point(12, 40);
            this.NodeList.Name = "NodeList";
            this.NodeList.Size = new System.Drawing.Size(165, 368);
            this.NodeList.TabIndex = 0;
            this.NodeList.SelectedIndexChanged += new System.EventHandler(this.NodeList_SelectedIndexChanged);
            // 
            // removeNodeButton
            // 
            this.removeNodeButton.Location = new System.Drawing.Point(178, 154);
            this.removeNodeButton.Name = "removeNodeButton";
            this.removeNodeButton.Size = new System.Drawing.Size(75, 23);
            this.removeNodeButton.TabIndex = 6;
            this.removeNodeButton.Text = "Remove";
            this.removeNodeButton.UseVisualStyleBackColor = true;
            this.removeNodeButton.Click += new System.EventHandler(this.removeNodeButton_Click);
            // 
            // edgeRemoveButton
            // 
            this.edgeRemoveButton.Location = new System.Drawing.Point(178, 165);
            this.edgeRemoveButton.Name = "edgeRemoveButton";
            this.edgeRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.edgeRemoveButton.TabIndex = 5;
            this.edgeRemoveButton.Text = "Remove";
            this.edgeRemoveButton.UseVisualStyleBackColor = true;
            this.edgeRemoveButton.Click += new System.EventHandler(this.edgeRemoveButton_Click);
            // 
            // graphName
            // 
            this.graphName.AutoSize = true;
            this.graphName.Location = new System.Drawing.Point(13, 4);
            this.graphName.Name = "graphName";
            this.graphName.Size = new System.Drawing.Size(87, 13);
            this.graphName.TabIndex = 0;
            this.graphName.Text = "Character Name:";
            // 
            // graphText
            // 
            this.graphText.Location = new System.Drawing.Point(16, 24);
            this.graphText.Name = "graphText";
            this.graphText.Size = new System.Drawing.Size(161, 20);
            this.graphText.TabIndex = 1;
            // 
            // graphNameButton
            // 
            this.graphNameButton.Location = new System.Drawing.Point(16, 48);
            this.graphNameButton.Name = "graphNameButton";
            this.graphNameButton.Size = new System.Drawing.Size(75, 23);
            this.graphNameButton.TabIndex = 2;
            this.graphNameButton.Text = "Change";
            this.graphNameButton.UseVisualStyleBackColor = true;
            this.graphNameButton.Click += new System.EventHandler(this.graphNameButton_Click);
            // 
            // characterName
            // 
            this.characterName.AutoSize = true;
            this.characterName.Location = new System.Drawing.Point(99, 4);
            this.characterName.Name = "characterName";
            this.characterName.Size = new System.Drawing.Size(0, 13);
            this.characterName.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(715, 419);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(712, 511);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panelBanner);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialogue Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelBanner.ResumeLayout(false);
            this.panelBanner.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.EdgePanel.ResumeLayout(false);
            this.EdgePanel.PerformLayout();
            this.nodePanel.ResumeLayout(false);
            this.nodePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelBanner;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel EdgePanel;
        private System.Windows.Forms.ListBox EdgeList;
        private System.Windows.Forms.Panel nodePanel;
        private System.Windows.Forms.Label nodeValueLabel;
        private System.Windows.Forms.TextBox nodeKeyText;
        private System.Windows.Forms.Label nodeKeyLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox NodeList;
        private System.Windows.Forms.CheckBox interactionCheck;
        private System.Windows.Forms.Label interactionLabel;
        private System.Windows.Forms.TextBox nodeValueText;
        private System.Windows.Forms.TextBox edgeToText;
        private System.Windows.Forms.Button edgeAdd;
        private System.Windows.Forms.Label edgeToLabel;
        private System.Windows.Forms.TextBox edgeKeyText;
        private System.Windows.Forms.Label edgeKeyLabel;
        private System.Windows.Forms.Label edgeTitle;
        private System.Windows.Forms.TextBox edgeValueText;
        private System.Windows.Forms.Label edgeValueLabel;
        private System.Windows.Forms.Button restrictionsButton;
        private System.Windows.Forms.Button nodeAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edgeFromText;
        private System.Windows.Forms.Label edgeFromLabel;
        private System.Windows.Forms.Button removeNodeButton;
        private System.Windows.Forms.Button edgeRemoveButton;
        private System.Windows.Forms.Button graphNameButton;
        private System.Windows.Forms.TextBox graphText;
        private System.Windows.Forms.Label graphName;
        private System.Windows.Forms.Label characterName;
        private System.Windows.Forms.ListView listView1;
    }
}

