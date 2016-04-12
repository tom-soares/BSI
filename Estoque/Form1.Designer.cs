namespace Estoque
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textCadaLocal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textCadaQtd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCadaDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textLocal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRepor = new System.Windows.Forms.Button();
            this.buttonRetirar = new System.Windows.Forms.Button();
            this.textRepor = new System.Windows.Forms.TextBox();
            this.textRetirar = new System.Windows.Forms.TextBox();
            this.textQtdm = new System.Windows.Forms.TextBox();
            this.textQtd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(338, 310);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textCadaLocal);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.buttonSalvar);
            this.tabPage1.Controls.Add(this.textCadaQtd);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textCadaDesc);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(330, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textCadaLocal
            // 
            this.textCadaLocal.Location = new System.Drawing.Point(29, 171);
            this.textCadaLocal.Name = "textCadaLocal";
            this.textCadaLocal.Size = new System.Drawing.Size(100, 20);
            this.textCadaLocal.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Localização";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(201, 208);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(100, 39);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // textCadaQtd
            // 
            this.textCadaQtd.Location = new System.Drawing.Point(29, 103);
            this.textCadaQtd.Name = "textCadaQtd";
            this.textCadaQtd.Size = new System.Drawing.Size(100, 20);
            this.textCadaQtd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade Mínima";
            // 
            // textCadaDesc
            // 
            this.textCadaDesc.Location = new System.Drawing.Point(26, 38);
            this.textCadaDesc.Name = "textCadaDesc";
            this.textCadaDesc.Size = new System.Drawing.Size(235, 20);
            this.textCadaDesc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textLocal);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.buttonRepor);
            this.tabPage2.Controls.Add(this.buttonRetirar);
            this.tabPage2.Controls.Add(this.textRepor);
            this.tabPage2.Controls.Add(this.textRetirar);
            this.tabPage2.Controls.Add(this.textQtdm);
            this.tabPage2.Controls.Add(this.textQtd);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.buttonBuscar);
            this.tabPage2.Controls.Add(this.textDesc);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(330, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar/Alterar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textLocal
            // 
            this.textLocal.Enabled = false;
            this.textLocal.Location = new System.Drawing.Point(36, 108);
            this.textLocal.Name = "textLocal";
            this.textLocal.Size = new System.Drawing.Size(100, 20);
            this.textLocal.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Localização";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // buttonRepor
            // 
            this.buttonRepor.Location = new System.Drawing.Point(194, 232);
            this.buttonRepor.Name = "buttonRepor";
            this.buttonRepor.Size = new System.Drawing.Size(100, 23);
            this.buttonRepor.TabIndex = 11;
            this.buttonRepor.Text = "Repor";
            this.buttonRepor.UseVisualStyleBackColor = true;
            this.buttonRepor.Click += new System.EventHandler(this.buttonRepor_Click);
            // 
            // buttonRetirar
            // 
            this.buttonRetirar.Location = new System.Drawing.Point(36, 232);
            this.buttonRetirar.Name = "buttonRetirar";
            this.buttonRetirar.Size = new System.Drawing.Size(100, 23);
            this.buttonRetirar.TabIndex = 10;
            this.buttonRetirar.Text = "Retirar";
            this.buttonRetirar.UseVisualStyleBackColor = true;
            this.buttonRetirar.Click += new System.EventHandler(this.buttonRetirar_Click);
            // 
            // textRepor
            // 
            this.textRepor.Location = new System.Drawing.Point(213, 206);
            this.textRepor.Name = "textRepor";
            this.textRepor.Size = new System.Drawing.Size(69, 20);
            this.textRepor.TabIndex = 9;
            // 
            // textRetirar
            // 
            this.textRetirar.Location = new System.Drawing.Point(53, 206);
            this.textRetirar.Name = "textRetirar";
            this.textRetirar.Size = new System.Drawing.Size(69, 20);
            this.textRetirar.TabIndex = 8;
            // 
            // textQtdm
            // 
            this.textQtdm.Enabled = false;
            this.textQtdm.Location = new System.Drawing.Point(197, 161);
            this.textQtdm.Name = "textQtdm";
            this.textQtdm.Size = new System.Drawing.Size(100, 20);
            this.textQtdm.TabIndex = 7;
            // 
            // textQtd
            // 
            this.textQtd.Enabled = false;
            this.textQtd.Location = new System.Drawing.Point(34, 161);
            this.textQtd.Name = "textQtd";
            this.textQtd.Size = new System.Drawing.Size(100, 20);
            this.textQtd.TabIndex = 6;
            this.textQtd.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantidade Mínima";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade em Estoque";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(222, 67);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // textDesc
            // 
            this.textDesc.Location = new System.Drawing.Point(31, 41);
            this.textDesc.Name = "textDesc";
            this.textDesc.Size = new System.Drawing.Size(266, 20);
            this.textDesc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descrição";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(330, 284);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(324, 278);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 310);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.TextBox textCadaQtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCadaDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textQtdm;
        private System.Windows.Forms.TextBox textQtd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textRetirar;
        private System.Windows.Forms.Button buttonRepor;
        private System.Windows.Forms.Button buttonRetirar;
        private System.Windows.Forms.TextBox textRepor;
        private System.Windows.Forms.TextBox textCadaLocal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textLocal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

