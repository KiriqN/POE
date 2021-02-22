namespace Gade_6112
{
    partial class Form1
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
            this.Up = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.attack = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Pinfo = new System.Windows.Forms.Label();
            this.Battleinfo = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.field = new System.Windows.Forms.Label();
            this.PlayerStats = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Buy = new System.Windows.Forms.Button();
            this.EnemyStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(79, 106);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(75, 23);
            this.Up.TabIndex = 1;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(79, 188);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(75, 23);
            this.Down.TabIndex = 2;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.button1_Click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(150, 152);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(75, 23);
            this.right.TabIndex = 3;
            this.right.Text = "Right";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(12, 152);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(75, 23);
            this.left.TabIndex = 4;
            this.left.Text = "Left";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // attack
            // 
            this.attack.Location = new System.Drawing.Point(675, 152);
            this.attack.Name = "attack";
            this.attack.Size = new System.Drawing.Size(75, 23);
            this.attack.TabIndex = 5;
            this.attack.Text = "Attack";
            this.attack.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(653, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // Pinfo
            // 
            this.Pinfo.AutoSize = true;
            this.Pinfo.Location = new System.Drawing.Point(86, 303);
            this.Pinfo.Name = "Pinfo";
            this.Pinfo.Size = new System.Drawing.Size(57, 13);
            this.Pinfo.TabIndex = 8;
            this.Pinfo.Text = "Player Info";
            this.Pinfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Battleinfo
            // 
            this.Battleinfo.AutoSize = true;
            this.Battleinfo.Location = new System.Drawing.Point(684, 303);
            this.Battleinfo.Name = "Battleinfo";
            this.Battleinfo.Size = new System.Drawing.Size(55, 13);
            this.Battleinfo.TabIndex = 10;
            this.Battleinfo.Text = "Battle Info";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(296, 388);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 11;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(465, 388);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 12;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Attacking Controls";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // field
            // 
            this.field.Location = new System.Drawing.Point(354, 96);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(177, 177);
            this.field.TabIndex = 14;
            this.field.Text = "Map";
            this.field.Click += new System.EventHandler(this.field_Click);
            // 
            // PlayerStats
            // 
            this.PlayerStats.Location = new System.Drawing.Point(79, 330);
            this.PlayerStats.Name = "PlayerStats";
            this.PlayerStats.Size = new System.Drawing.Size(117, 69);
            this.PlayerStats.TabIndex = 15;
            this.PlayerStats.Text = "PlayerStats";
            this.PlayerStats.Click += new System.EventHandler(this.PlayerStats_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(653, 222);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(694, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Shop";
            // 
            // Buy
            // 
            this.Buy.Location = new System.Drawing.Point(675, 263);
            this.Buy.Name = "Buy";
            this.Buy.Size = new System.Drawing.Size(75, 23);
            this.Buy.TabIndex = 18;
            this.Buy.Text = "Buy";
            this.Buy.UseVisualStyleBackColor = true;
            // 
            // EnemyStats
            // 
            this.EnemyStats.AutoSize = true;
            this.EnemyStats.Location = new System.Drawing.Point(684, 330);
            this.EnemyStats.Name = "EnemyStats";
            this.EnemyStats.Size = new System.Drawing.Size(66, 13);
            this.EnemyStats.TabIndex = 19;
            this.EnemyStats.Text = "Enemy Stats";
            this.EnemyStats.Click += new System.EventHandler(this.EnemyStats_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.EnemyStats);
            this.Controls.Add(this.Buy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.PlayerStats);
            this.Controls.Add(this.field);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Battleinfo);
            this.Controls.Add(this.Pinfo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.attack);
            this.Controls.Add(this.left);
            this.Controls.Add(this.right);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Up);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button attack;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Pinfo;
        private System.Windows.Forms.Label Battleinfo;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label field;
        private System.Windows.Forms.Label PlayerStats;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Buy;
        private System.Windows.Forms.Label EnemyStats;
    }
}

