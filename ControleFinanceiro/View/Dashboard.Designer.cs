namespace ControleFinanceiro
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbox_resumo = new System.Windows.Forms.TextBox();
            this.tbox_rendas = new System.Windows.Forms.TextBox();
            this.rb_resumo = new System.Windows.Forms.RadioButton();
            this.rb_rendas = new System.Windows.Forms.RadioButton();
            this.rb_despesas = new System.Windows.Forms.RadioButton();
            this.tbox_despesas = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.financeiroDataSet1 = new ControleFinanceiro.View.financeiroDataSet1();
            this.registrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrosTableAdapter = new ControleFinanceiro.View.financeiroDataSet1TableAdapters.RegistrosTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeiroDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_adicionar);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-1, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 327);
            this.panel1.TabIndex = 13;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.Location = new System.Drawing.Point(145, 265);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(475, 40);
            this.btn_adicionar.TabIndex = 21;
            this.btn_adicionar.Text = "Adicionar Entrada";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbox_resumo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbox_rendas, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.rb_resumo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rb_rendas, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.rb_despesas, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbox_despesas, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.64865F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.35135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(136, 247);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbox_resumo
            // 
            this.tbox_resumo.Location = new System.Drawing.Point(3, 43);
            this.tbox_resumo.Name = "tbox_resumo";
            this.tbox_resumo.Size = new System.Drawing.Size(100, 20);
            this.tbox_resumo.TabIndex = 18;
            // 
            // tbox_rendas
            // 
            this.tbox_rendas.Location = new System.Drawing.Point(3, 211);
            this.tbox_rendas.Name = "tbox_rendas";
            this.tbox_rendas.Size = new System.Drawing.Size(100, 20);
            this.tbox_rendas.TabIndex = 17;
            // 
            // rb_resumo
            // 
            this.rb_resumo.AutoSize = true;
            this.rb_resumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_resumo.Location = new System.Drawing.Point(3, 3);
            this.rb_resumo.Name = "rb_resumo";
            this.rb_resumo.Size = new System.Drawing.Size(83, 20);
            this.rb_resumo.TabIndex = 19;
            this.rb_resumo.TabStop = true;
            this.rb_resumo.Text = "Resumo";
            this.rb_resumo.UseVisualStyleBackColor = true;
            // 
            // rb_rendas
            // 
            this.rb_rendas.AutoSize = true;
            this.rb_rendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_rendas.Location = new System.Drawing.Point(3, 174);
            this.rb_rendas.Name = "rb_rendas";
            this.rb_rendas.Size = new System.Drawing.Size(102, 20);
            this.rb_rendas.TabIndex = 16;
            this.rb_rendas.TabStop = true;
            this.rb_rendas.Text = "Rendas (+)";
            this.rb_rendas.UseVisualStyleBackColor = true;
            // 
            // rb_despesas
            // 
            this.rb_despesas.AutoSize = true;
            this.rb_despesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_despesas.Location = new System.Drawing.Point(3, 85);
            this.rb_despesas.Name = "rb_despesas";
            this.rb_despesas.Size = new System.Drawing.Size(116, 20);
            this.rb_despesas.TabIndex = 15;
            this.rb_despesas.TabStop = true;
            this.rb_despesas.Text = "Despesas (-)";
            this.rb_despesas.UseVisualStyleBackColor = true;
            // 
            // tbox_despesas
            // 
            this.tbox_despesas.Location = new System.Drawing.Point(3, 129);
            this.tbox_despesas.Name = "tbox_despesas";
            this.tbox_despesas.Size = new System.Drawing.Size(100, 20);
            this.tbox_despesas.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.registrosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(145, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(475, 244);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // financeiroDataSet1
            // 
            this.financeiroDataSet1.DataSetName = "financeiroDataSet1";
            this.financeiroDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrosBindingSource
            // 
            this.registrosBindingSource.DataMember = "Registros";
            this.registrosBindingSource.DataSource = this.financeiroDataSet1;
            // 
            // registrosTableAdapter
            // 
            this.registrosTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "#";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 367);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeiroDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbox_resumo;
        private System.Windows.Forms.RadioButton rb_resumo;
        private System.Windows.Forms.RadioButton rb_rendas;
        private System.Windows.Forms.RadioButton rb_despesas;
        private System.Windows.Forms.TextBox tbox_despesas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox tbox_rendas;
        private View.financeiroDataSet1 financeiroDataSet1;
        private System.Windows.Forms.BindingSource registrosBindingSource;
        private View.financeiroDataSet1TableAdapters.RegistrosTableAdapter registrosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
    }
}