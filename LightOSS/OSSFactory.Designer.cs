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
            this.filterValues = new System.Windows.Forms.ListBox();
            this.fvlbLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // databaseListBox
            // 
            this.databaseListBox.FormattingEnabled = true;
            this.databaseListBox.Location = new System.Drawing.Point(228, 12);
            this.databaseListBox.Name = "databaseListBox";
            this.databaseListBox.Size = new System.Drawing.Size(142, 290);
            this.databaseListBox.TabIndex = 0;
            this.databaseListBox.SelectedIndexChanged += new System.EventHandler(this.databaseListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(210, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(113, 109);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(89, 33);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ossButton
            // 
            this.ossButton.Location = new System.Drawing.Point(9, 109);
            this.ossButton.Name = "ossButton";
            this.ossButton.Size = new System.Drawing.Size(98, 33);
            this.ossButton.TabIndex = 2;
            this.ossButton.Text = "Oss!";
            this.ossButton.UseVisualStyleBackColor = true;
            this.ossButton.Click += new System.EventHandler(this.ossButton_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(46, 77);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(156, 20);
            this.pass.TabIndex = 5;
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
            this.user.Location = new System.Drawing.Point(46, 51);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(156, 20);
            this.user.TabIndex = 3;
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
            this.server.Location = new System.Drawing.Point(46, 25);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(156, 20);
            this.server.TabIndex = 2;
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
            this.collectionsListBox.FormattingEnabled = true;
            this.collectionsListBox.Location = new System.Drawing.Point(379, 12);
            this.collectionsListBox.Name = "collectionsListBox";
            this.collectionsListBox.Size = new System.Drawing.Size(142, 290);
            this.collectionsListBox.TabIndex = 2;
            // 
            // postCollection
            // 
            this.postCollection.Location = new System.Drawing.Point(527, 131);
            this.postCollection.Name = "postCollection";
            this.postCollection.Size = new System.Drawing.Size(60, 23);
            this.postCollection.TabIndex = 3;
            this.postCollection.Text = ">>";
            this.postCollection.UseVisualStyleBackColor = true;
            this.postCollection.Click += new System.EventHandler(this.postCollection_Click);
            // 
            // keyListBox
            // 
            this.keyListBox.FormattingEnabled = true;
            this.keyListBox.Location = new System.Drawing.Point(593, 12);
            this.keyListBox.Name = "keyListBox";
            this.keyListBox.Size = new System.Drawing.Size(183, 290);
            this.keyListBox.TabIndex = 4;
            // 
            // setAxisKey
            // 
            this.setAxisKey.Location = new System.Drawing.Point(782, 12);
            this.setAxisKey.Name = "setAxisKey";
            this.setAxisKey.Size = new System.Drawing.Size(110, 22);
            this.setAxisKey.TabIndex = 5;
            this.setAxisKey.Text = "Set as x-axis key";
            this.setAxisKey.UseVisualStyleBackColor = true;
            this.setAxisKey.Click += new System.EventHandler(this.setAxisKey_Click);
            // 
            // addCounter
            // 
            this.addCounter.Location = new System.Drawing.Point(782, 40);
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
            this.groupBox2.Location = new System.Drawing.Point(782, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 232);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OSS Settings";
            // 
            // removeCounter
            // 
            this.removeCounter.Location = new System.Drawing.Point(229, 85);
            this.removeCounter.Name = "removeCounter";
            this.removeCounter.Size = new System.Drawing.Size(39, 23);
            this.removeCounter.TabIndex = 9;
            this.removeCounter.Text = "-";
            this.removeCounter.UseVisualStyleBackColor = true;
            this.removeCounter.Click += new System.EventHandler(this.removeCounter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "OSSome!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // countersListBox
            // 
            this.countersListBox.FormattingEnabled = true;
            this.countersListBox.Location = new System.Drawing.Point(9, 111);
            this.countersListBox.Name = "countersListBox";
            this.countersListBox.Size = new System.Drawing.Size(259, 82);
            this.countersListBox.TabIndex = 7;
            // 
            // sCLabel
            // 
            this.sCLabel.AutoSize = true;
            this.sCLabel.Location = new System.Drawing.Point(8, 95);
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
            this.setFilterKey.Location = new System.Drawing.Point(782, 66);
            this.setFilterKey.Name = "setFilterKey";
            this.setFilterKey.Size = new System.Drawing.Size(110, 21);
            this.setFilterKey.TabIndex = 8;
            this.setFilterKey.Text = "Set as filter";
            this.setFilterKey.UseVisualStyleBackColor = true;
            this.setFilterKey.Click += new System.EventHandler(this.setFilterKey_Click);
            // 
            // filterValues
            // 
            this.filterValues.FormattingEnabled = true;
            this.filterValues.Location = new System.Drawing.Point(782, 132);
            this.filterValues.Name = "filterValues";
            this.filterValues.Size = new System.Drawing.Size(274, 108);
            this.filterValues.TabIndex = 9;
            // 
            // fvlbLabel
            // 
            this.fvlbLabel.AutoSize = true;
            this.fvlbLabel.Location = new System.Drawing.Point(782, 116);
            this.fvlbLabel.Name = "fvlbLabel";
            this.fvlbLabel.Size = new System.Drawing.Size(109, 13);
            this.fvlbLabel.TabIndex = 10;
            this.fvlbLabel.Text = "Possible Filter Values:";
            // 
            // OSSFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 506);
            this.Controls.Add(this.fvlbLabel);
            this.Controls.Add(this.filterValues);
            this.Controls.Add(this.setFilterKey);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.addCounter);
            this.Controls.Add(this.setAxisKey);
            this.Controls.Add(this.keyListBox);
            this.Controls.Add(this.postCollection);
            this.Controls.Add(this.collectionsListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.databaseListBox);
            this.Name = "OSSFactory";
            this.Text = "OSSFactory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ListBox filterValues;
        private System.Windows.Forms.Label fvlbLabel;
    }
}
