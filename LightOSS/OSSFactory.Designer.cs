namespace LightOSS
{
    partial class OSSFactory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.databaseListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.autoConnectCheckbox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.ossButton = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.collectionsListBox = new System.Windows.Forms.ListBox();
            this.postCollection = new System.Windows.Forms.Button();
            this.keyListBox = new System.Windows.Forms.ListBox();
            this.setAxisKey = new System.Windows.Forms.Button();
            this.addCounter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeCounter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.countersListBox = new System.Windows.Forms.ListBox();
            this.sCLabel = new System.Windows.Forms.Label();
            this.settingXAxisLabel = new System.Windows.Forms.Label();
            this.xAKLabel = new System.Windows.Forms.Label();
            this.settingCollLabel = new System.Windows.Forms.Label();
            this.sCollLabel = new System.Windows.Forms.Label();
            this.settingDBLabel = new System.Windows.Forms.Label();
            this.sdbLabel = new System.Windows.Forms.Label();
            this.setFilterKey = new System.Windows.Forms.Button();
            this.sourceListBox = new System.Windows.Forms.ListBox();
            this.dbAndCollectionSplitPanel = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.keyAndSourceListBox = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbAndCollectionSplitPanel)).BeginInit();
            this.dbAndCollectionSplitPanel.Panel1.SuspendLayout();
            this.dbAndCollectionSplitPanel.Panel2.SuspendLayout();
            this.dbAndCollectionSplitPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyAndSourceListBox)).BeginInit();
            this.keyAndSourceListBox.Panel1.SuspendLayout();
            this.keyAndSourceListBox.Panel2.SuspendLayout();
            this.keyAndSourceListBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // databaseListBox
            // 
            this.databaseListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseListBox.FormattingEnabled = true;
            this.databaseListBox.Location = new System.Drawing.Point(3, 16);
            this.databaseListBox.Name = "databaseListBox";
            this.databaseListBox.Size = new System.Drawing.Size(257, 222);
            this.databaseListBox.TabIndex = 0;
            this.databaseListBox.SelectedIndexChanged += new System.EventHandler(this.databaseListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.autoConnectCheckbox);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.ossButton);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.user);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.server);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // autoConnectCheckbox
            // 
            this.autoConnectCheckbox.AutoSize = true;
            this.autoConnectCheckbox.Checked = global::LightOSS.Settings.Default.AutoConnect;
            this.autoConnectCheckbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::LightOSS.Settings.Default, "AutoConnect", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.autoConnectCheckbox.Location = new System.Drawing.Point(46, 105);
            this.autoConnectCheckbox.Name = "autoConnectCheckbox";
            this.autoConnectCheckbox.Size = new System.Drawing.Size(131, 17);
            this.autoConnectCheckbox.TabIndex = 8;
            this.autoConnectCheckbox.Text = "Connect Automatically";
            this.autoConnectCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(113, 138);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(89, 33);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ossButton
            // 
            this.ossButton.Location = new System.Drawing.Point(9, 138);
            this.ossButton.Name = "ossButton";
            this.ossButton.Size = new System.Drawing.Size(98, 33);
            this.ossButton.TabIndex = 2;
            this.ossButton.Text = "Oss!";
            this.ossButton.UseVisualStyleBackColor = true;
            this.ossButton.Click += new System.EventHandler(this.ossButton_Click);
            // 
            // pass
            // 
            this.pass.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LightOSS.Settings.Default, "Pass", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pass.Location = new System.Drawing.Point(46, 77);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(156, 20);
            this.pass.TabIndex = 5;
            this.pass.Text = global::LightOSS.Settings.Default.Pass;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pass";
            // 
            // user
            // 
            this.user.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LightOSS.Settings.Default, "User", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.user.Location = new System.Drawing.Point(46, 51);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(156, 20);
            this.user.TabIndex = 3;
            this.user.Text = global::LightOSS.Settings.Default.User;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User";
            // 
            // server
            // 
            this.server.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::LightOSS.Settings.Default, "Server", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.server.Location = new System.Drawing.Point(46, 25);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(156, 20);
            this.server.TabIndex = 2;
            this.server.Text = global::LightOSS.Settings.Default.Server;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server";
            // 
            // collectionsListBox
            // 
            this.collectionsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collectionsListBox.FormattingEnabled = true;
            this.collectionsListBox.Location = new System.Drawing.Point(3, 16);
            this.collectionsListBox.Name = "collectionsListBox";
            this.collectionsListBox.Size = new System.Drawing.Size(257, 218);
            this.collectionsListBox.TabIndex = 2;
            // 
            // postCollection
            // 
            this.postCollection.Location = new System.Drawing.Point(497, 187);
            this.postCollection.Name = "postCollection";
            this.postCollection.Size = new System.Drawing.Size(60, 23);
            this.postCollection.TabIndex = 3;
            this.postCollection.Text = ">>";
            this.postCollection.UseVisualStyleBackColor = true;
            this.postCollection.Click += new System.EventHandler(this.postCollection_Click);
            // 
            // keyListBox
            // 
            this.keyListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyListBox.FormattingEnabled = true;
            this.keyListBox.Location = new System.Drawing.Point(3, 16);
            this.keyListBox.Name = "keyListBox";
            this.keyListBox.Size = new System.Drawing.Size(404, 223);
            this.keyListBox.TabIndex = 4;
            // 
            // setAxisKey
            // 
            this.setAxisKey.Location = new System.Drawing.Point(979, 12);
            this.setAxisKey.Name = "setAxisKey";
            this.setAxisKey.Size = new System.Drawing.Size(110, 22);
            this.setAxisKey.TabIndex = 5;
            this.setAxisKey.Text = "Set as x-axis key";
            this.setAxisKey.UseVisualStyleBackColor = true;
            this.setAxisKey.Click += new System.EventHandler(this.setAxisKey_Click);
            // 
            // addCounter
            // 
            this.addCounter.Location = new System.Drawing.Point(979, 40);
            this.addCounter.Name = "addCounter";
            this.addCounter.Size = new System.Drawing.Size(110, 22);
            this.addCounter.TabIndex = 6;
            this.addCounter.Text = "Add to counters";
            this.addCounter.UseVisualStyleBackColor = true;
            this.addCounter.Click += new System.EventHandler(this.addCounter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removeCounter);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.countersListBox);
            this.groupBox2.Controls.Add(this.sCLabel);
            this.groupBox2.Controls.Add(this.settingXAxisLabel);
            this.groupBox2.Controls.Add(this.xAKLabel);
            this.groupBox2.Controls.Add(this.settingCollLabel);
            this.groupBox2.Controls.Add(this.sCollLabel);
            this.groupBox2.Controls.Add(this.settingDBLabel);
            this.groupBox2.Controls.Add(this.sdbLabel);
            this.groupBox2.Location = new System.Drawing.Point(979, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 401);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OSS Settings";
            // 
            // removeCounter
            // 
            this.removeCounter.Location = new System.Drawing.Point(140, 110);
            this.removeCounter.Name = "removeCounter";
            this.removeCounter.Size = new System.Drawing.Size(128, 24);
            this.removeCounter.TabIndex = 9;
            this.removeCounter.Text = "Remove from counters";
            this.removeCounter.UseVisualStyleBackColor = true;
            this.removeCounter.Click += new System.EventHandler(this.removeCounter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "OSSome!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // countersListBox
            // 
            this.countersListBox.FormattingEnabled = true;
            this.countersListBox.Location = new System.Drawing.Point(9, 137);
            this.countersListBox.Name = "countersListBox";
            this.countersListBox.Size = new System.Drawing.Size(259, 225);
            this.countersListBox.TabIndex = 7;
            // 
            // sCLabel
            // 
            this.sCLabel.AutoSize = true;
            this.sCLabel.Location = new System.Drawing.Point(8, 121);
            this.sCLabel.Name = "sCLabel";
            this.sCLabel.Size = new System.Drawing.Size(58, 13);
            this.sCLabel.TabIndex = 6;
            this.sCLabel.Text = "Counter(s):";
            // 
            // settingXAxisLabel
            // 
            this.settingXAxisLabel.AutoSize = true;
            this.settingXAxisLabel.Location = new System.Drawing.Point(72, 67);
            this.settingXAxisLabel.Name = "settingXAxisLabel";
            this.settingXAxisLabel.Size = new System.Drawing.Size(66, 13);
            this.settingXAxisLabel.TabIndex = 5;
            this.settingXAxisLabel.Text = "Select a key";
            // 
            // xAKLabel
            // 
            this.xAKLabel.AutoSize = true;
            this.xAKLabel.Location = new System.Drawing.Point(6, 67);
            this.xAKLabel.Name = "xAKLabel";
            this.xAKLabel.Size = new System.Drawing.Size(60, 13);
            this.xAKLabel.TabIndex = 4;
            this.xAKLabel.Text = "X-Axis Key:";
            // 
            // settingCollLabel
            // 
            this.settingCollLabel.AutoSize = true;
            this.settingCollLabel.Location = new System.Drawing.Point(72, 47);
            this.settingCollLabel.Name = "settingCollLabel";
            this.settingCollLabel.Size = new System.Drawing.Size(94, 13);
            this.settingCollLabel.TabIndex = 3;
            this.settingCollLabel.Text = "Select a collection";
            // 
            // sCollLabel
            // 
            this.sCollLabel.AutoSize = true;
            this.sCollLabel.Location = new System.Drawing.Point(6, 47);
            this.sCollLabel.Name = "sCollLabel";
            this.sCollLabel.Size = new System.Drawing.Size(56, 13);
            this.sCollLabel.TabIndex = 2;
            this.sCollLabel.Text = "Collection:";
            // 
            // settingDBLabel
            // 
            this.settingDBLabel.AutoSize = true;
            this.settingDBLabel.Location = new System.Drawing.Point(72, 24);
            this.settingDBLabel.Name = "settingDBLabel";
            this.settingDBLabel.Size = new System.Drawing.Size(93, 13);
            this.settingDBLabel.TabIndex = 1;
            this.settingDBLabel.Text = "Select a database";
            // 
            // sdbLabel
            // 
            this.sdbLabel.AutoSize = true;
            this.sdbLabel.Location = new System.Drawing.Point(6, 24);
            this.sdbLabel.Name = "sdbLabel";
            this.sdbLabel.Size = new System.Drawing.Size(56, 13);
            this.sdbLabel.TabIndex = 0;
            this.sdbLabel.Text = "Database:";
            // 
            // setFilterKey
            // 
            this.setFilterKey.Location = new System.Drawing.Point(979, 66);
            this.setFilterKey.Name = "setFilterKey";
            this.setFilterKey.Size = new System.Drawing.Size(110, 21);
            this.setFilterKey.TabIndex = 8;
            this.setFilterKey.Text = "Set as source key";
            this.setFilterKey.UseVisualStyleBackColor = true;
            this.setFilterKey.Click += new System.EventHandler(this.setFilterKey_Click);
            // 
            // sourceListBox
            // 
            this.sourceListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceListBox.FormattingEnabled = true;
            this.sourceListBox.HorizontalScrollbar = true;
            this.sourceListBox.Location = new System.Drawing.Point(3, 16);
            this.sourceListBox.Name = "sourceListBox";
            this.sourceListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.sourceListBox.Size = new System.Drawing.Size(404, 220);
            this.sourceListBox.Sorted = true;
            this.sourceListBox.TabIndex = 9;
            // 
            // dbAndCollectionSplitPanel
            // 
            this.dbAndCollectionSplitPanel.Location = new System.Drawing.Point(228, 12);
            this.dbAndCollectionSplitPanel.Name = "dbAndCollectionSplitPanel";
            this.dbAndCollectionSplitPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // dbAndCollectionSplitPanel.Panel1
            // 
            this.dbAndCollectionSplitPanel.Panel1.Controls.Add(this.groupBox3);
            // 
            // dbAndCollectionSplitPanel.Panel2
            // 
            this.dbAndCollectionSplitPanel.Panel2.Controls.Add(this.groupBox4);
            this.dbAndCollectionSplitPanel.Size = new System.Drawing.Size(263, 482);
            this.dbAndCollectionSplitPanel.SplitterDistance = 241;
            this.dbAndCollectionSplitPanel.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.databaseListBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 241);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Databases";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.collectionsListBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 237);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Collections";
            // 
            // keyAndSourceListBox
            // 
            this.keyAndSourceListBox.Location = new System.Drawing.Point(563, 9);
            this.keyAndSourceListBox.Name = "keyAndSourceListBox";
            this.keyAndSourceListBox.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // keyAndSourceListBox.Panel1
            // 
            this.keyAndSourceListBox.Panel1.Controls.Add(this.groupBox5);
            // 
            // keyAndSourceListBox.Panel2
            // 
            this.keyAndSourceListBox.Panel2.Controls.Add(this.groupBox6);
            this.keyAndSourceListBox.Size = new System.Drawing.Size(410, 485);
            this.keyAndSourceListBox.SplitterDistance = 242;
            this.keyAndSourceListBox.TabIndex = 11;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.keyListBox);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(410, 242);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Keys";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.sourceListBox);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(410, 239);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sources";
            // 
            // OSSFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 506);
            this.Controls.Add(this.keyAndSourceListBox);
            this.Controls.Add(this.dbAndCollectionSplitPanel);
            this.Controls.Add(this.setFilterKey);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.addCounter);
            this.Controls.Add(this.setAxisKey);
            this.Controls.Add(this.postCollection);
            this.Controls.Add(this.groupBox1);
            this.Name = "OSSFactory";
            this.ShowIcon = false;
            this.Text = "OSSFactory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.dbAndCollectionSplitPanel.Panel1.ResumeLayout(false);
            this.dbAndCollectionSplitPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbAndCollectionSplitPanel)).EndInit();
            this.dbAndCollectionSplitPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.keyAndSourceListBox.Panel1.ResumeLayout(false);
            this.keyAndSourceListBox.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.keyAndSourceListBox)).EndInit();
            this.keyAndSourceListBox.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox databaseListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ossButton;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox collectionsListBox;
        private System.Windows.Forms.Button postCollection;
        private System.Windows.Forms.ListBox keyListBox;
        private System.Windows.Forms.Button setAxisKey;
        private System.Windows.Forms.Button addCounter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox countersListBox;
        private System.Windows.Forms.Label sCLabel;
        private System.Windows.Forms.Label settingXAxisLabel;
        private System.Windows.Forms.Label xAKLabel;
        private System.Windows.Forms.Label settingCollLabel;
        private System.Windows.Forms.Label sCollLabel;
        private System.Windows.Forms.Label settingDBLabel;
        private System.Windows.Forms.Label sdbLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button removeCounter;
        private System.Windows.Forms.Button setFilterKey;
        private System.Windows.Forms.ListBox sourceListBox;
        private System.Windows.Forms.CheckBox autoConnectCheckbox;
        private System.Windows.Forms.SplitContainer dbAndCollectionSplitPanel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.SplitContainer keyAndSourceListBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}
