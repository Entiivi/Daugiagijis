namespace DaugiagijisMatrix
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
            this.comboBoxRowsA = new System.Windows.Forms.ComboBox();
            this.comboBoxRowsB = new System.Windows.Forms.ComboBox();
            this.comboBoxColsA = new System.Windows.Forms.ComboBox();
            this.comboBoxColsB = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridViewA = new System.Windows.Forms.DataGridView();
            this.dataGridViewB = new System.Windows.Forms.DataGridView();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.dataGridViewC = new System.Windows.Forms.DataGridView();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.Dauginti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewC)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxRowsA
            // 
            this.comboBoxRowsA.FormattingEnabled = true;
            this.comboBoxRowsA.Location = new System.Drawing.Point(33, 52);
            this.comboBoxRowsA.Name = "comboBoxRowsA";
            this.comboBoxRowsA.Size = new System.Drawing.Size(131, 21);
            this.comboBoxRowsA.TabIndex = 0;
            this.comboBoxRowsA.SelectedIndexChanged += new System.EventHandler(this.comboBoxRowsA_SelectedIndexChanged);
            // 
            // comboBoxRowsB
            // 
            this.comboBoxRowsB.FormattingEnabled = true;
            this.comboBoxRowsB.Location = new System.Drawing.Point(33, 122);
            this.comboBoxRowsB.Name = "comboBoxRowsB";
            this.comboBoxRowsB.Size = new System.Drawing.Size(131, 21);
            this.comboBoxRowsB.TabIndex = 1;
            this.comboBoxRowsB.SelectedIndexChanged += new System.EventHandler(this.comboBoxRowsB_SelectedIndexChanged);
            // 
            // comboBoxColsA
            // 
            this.comboBoxColsA.FormattingEnabled = true;
            this.comboBoxColsA.Location = new System.Drawing.Point(205, 52);
            this.comboBoxColsA.Name = "comboBoxColsA";
            this.comboBoxColsA.Size = new System.Drawing.Size(137, 21);
            this.comboBoxColsA.TabIndex = 2;
            this.comboBoxColsA.SelectedIndexChanged += new System.EventHandler(this.comboBoxColsA_SelectedIndexChanged);
            // 
            // comboBoxColsB
            // 
            this.comboBoxColsB.FormattingEnabled = true;
            this.comboBoxColsB.Location = new System.Drawing.Point(205, 122);
            this.comboBoxColsB.Name = "comboBoxColsB";
            this.comboBoxColsB.Size = new System.Drawing.Size(137, 21);
            this.comboBoxColsB.TabIndex = 3;
            this.comboBoxColsB.SelectedIndexChanged += new System.EventHandler(this.comboBoxColsB_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Matricos A eilučių skaičius";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Matricos B eilučių skaičius";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(205, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Matricos B stulpelių skaičius";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(205, 26);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(137, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Matricos A stulpelių skaičius";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(371, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(387, 46);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "Norint atlikti matricų daugybą, pirmoji matrica turi turėti tiek pat stulpelių, k" +
    "iek antroji matrica turi eilučių.";
            // 
            // dataGridViewA
            // 
            this.dataGridViewA.AllowUserToAddRows = false;
            this.dataGridViewA.AllowUserToDeleteRows = false;
            this.dataGridViewA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewA.Location = new System.Drawing.Point(47, 254);
            this.dataGridViewA.Name = "dataGridViewA";
            this.dataGridViewA.Size = new System.Drawing.Size(193, 161);
            this.dataGridViewA.TabIndex = 9;
            // 
            // dataGridViewB
            // 
            this.dataGridViewB.AllowUserToAddRows = false;
            this.dataGridViewB.AllowUserToDeleteRows = false;
            this.dataGridViewB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewB.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewB.Location = new System.Drawing.Point(305, 254);
            this.dataGridViewB.Name = "dataGridViewB";
            this.dataGridViewB.Size = new System.Drawing.Size(189, 161);
            this.dataGridViewB.TabIndex = 10;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(117, 171);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(47, 77);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "A";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(371, 171);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(47, 77);
            this.richTextBox3.TabIndex = 12;
            this.richTextBox3.Text = "B";
            // 
            // dataGridViewC
            // 
            this.dataGridViewC.AllowUserToAddRows = false;
            this.dataGridViewC.AllowUserToDeleteRows = false;
            this.dataGridViewC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewC.Location = new System.Drawing.Point(569, 254);
            this.dataGridViewC.Name = "dataGridViewC";
            this.dataGridViewC.ReadOnly = true;
            this.dataGridViewC.Size = new System.Drawing.Size(189, 161);
            this.dataGridViewC.TabIndex = 13;
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.Location = new System.Drawing.Point(261, 321);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(38, 48);
            this.richTextBox4.TabIndex = 14;
            this.richTextBox4.Text = "X";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.Location = new System.Drawing.Point(509, 297);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.Size = new System.Drawing.Size(47, 77);
            this.richTextBox5.TabIndex = 15;
            this.richTextBox5.Text = "=";
            // 
            // Dauginti
            // 
            this.Dauginti.BackColor = System.Drawing.Color.PaleGreen;
            this.Dauginti.FlatAppearance.BorderSize = 0;
            this.Dauginti.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dauginti.Location = new System.Drawing.Point(215, 444);
            this.Dauginti.Name = "Dauginti";
            this.Dauginti.Size = new System.Drawing.Size(127, 45);
            this.Dauginti.TabIndex = 16;
            this.Dauginti.Text = "Skaičiuoti";
            this.Dauginti.UseVisualStyleBackColor = false;
            this.Dauginti.Click += new System.EventHandler(this.Dauginti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1055, 531);
            this.Controls.Add(this.Dauginti);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.dataGridViewC);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.dataGridViewB);
            this.Controls.Add(this.dataGridViewA);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxColsB);
            this.Controls.Add(this.comboBoxColsA);
            this.Controls.Add(this.comboBoxRowsB);
            this.Controls.Add(this.comboBoxRowsA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        public System.Windows.Forms.ComboBox comboBoxRowsA;
        public System.Windows.Forms.ComboBox comboBoxRowsB;
        public System.Windows.Forms.ComboBox comboBoxColsA;
        public System.Windows.Forms.ComboBox comboBoxColsB;
        public System.Windows.Forms.DataGridView dataGridViewA;
        public System.Windows.Forms.DataGridView dataGridViewB;
        public System.Windows.Forms.DataGridView dataGridViewC;
        private System.Windows.Forms.Button Dauginti;
    }
}

