
namespace VideojatekForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderByAscending = new System.Windows.Forms.RadioButton();
            this.orderByDescending = new System.Windows.Forms.RadioButton();
            this.jatekokTabla = new System.Windows.Forms.ListBox();
            this.deleteAll = new System.Windows.Forms.Button();
            this.legdragabbJatek = new System.Windows.Forms.ListBox();
            this.addGame = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // orderByAscending
            // 
            this.orderByAscending.AutoSize = true;
            this.orderByAscending.Location = new System.Drawing.Point(1189, 12);
            this.orderByAscending.Name = "orderByAscending";
            this.orderByAscending.Size = new System.Drawing.Size(204, 29);
            this.orderByAscending.TabIndex = 1;
            this.orderByAscending.TabStop = true;
            this.orderByAscending.Text = "Rendezés növekvőbe";
            this.orderByAscending.UseVisualStyleBackColor = true;
            this.orderByAscending.CheckedChanged += new System.EventHandler(this.orderByAscending_CheckedChanged);
            // 
            // orderByDescending
            // 
            this.orderByDescending.AutoSize = true;
            this.orderByDescending.Location = new System.Drawing.Point(1189, 75);
            this.orderByDescending.Name = "orderByDescending";
            this.orderByDescending.Size = new System.Drawing.Size(211, 29);
            this.orderByDescending.TabIndex = 2;
            this.orderByDescending.TabStop = true;
            this.orderByDescending.Text = "Rendezés csökkenőbe";
            this.orderByDescending.UseVisualStyleBackColor = true;
            this.orderByDescending.CheckedChanged += new System.EventHandler(this.orderByDescending_CheckedChanged);
            // 
            // jatekokTabla
            // 
            this.jatekokTabla.FormattingEnabled = true;
            this.jatekokTabla.ItemHeight = 25;
            this.jatekokTabla.Location = new System.Drawing.Point(12, 87);
            this.jatekokTabla.Name = "jatekokTabla";
            this.jatekokTabla.Size = new System.Drawing.Size(1144, 454);
            this.jatekokTabla.TabIndex = 3;
            // 
            // deleteAll
            // 
            this.deleteAll.Location = new System.Drawing.Point(1189, 507);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(112, 34);
            this.deleteAll.TabIndex = 4;
            this.deleteAll.Text = "Törlés";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // legdragabbJatek
            // 
            this.legdragabbJatek.FormattingEnabled = true;
            this.legdragabbJatek.ItemHeight = 25;
            this.legdragabbJatek.Location = new System.Drawing.Point(12, 12);
            this.legdragabbJatek.Name = "legdragabbJatek";
            this.legdragabbJatek.Size = new System.Drawing.Size(1144, 54);
            this.legdragabbJatek.TabIndex = 5;
            // 
            // addGame
            // 
            this.addGame.Location = new System.Drawing.Point(1189, 453);
            this.addGame.Name = "addGame";
            this.addGame.Size = new System.Drawing.Size(196, 34);
            this.addGame.TabIndex = 6;
            this.addGame.Text = "Játék hozzáadása";
            this.addGame.UseVisualStyleBackColor = true;
            this.addGame.Click += new System.EventHandler(this.addGame_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MINDEN JÁTÉK",
            "AKCIÓ",
            "HORROR"});
            this.comboBox1.Location = new System.Drawing.Point(1189, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 33);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 576);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.addGame);
            this.Controls.Add(this.legdragabbJatek);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.jatekokTabla);
            this.Controls.Add(this.orderByDescending);
            this.Controls.Add(this.orderByAscending);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton orderByAscending;
        private System.Windows.Forms.RadioButton orderByDescending;
        private System.Windows.Forms.ListBox jatekokTabla;
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.ListBox legdragabbJatek;
        private System.Windows.Forms.Button addGame;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

