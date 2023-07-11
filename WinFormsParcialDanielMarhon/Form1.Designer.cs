namespace WinFormsParcialDanielMarhon
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
            label1 = new Label();
            label2 = new Label();
            IngresarBtn = new Button();
            LimpiarBtn = new Button();
            txtBoxAltura = new TextBox();
            txtBoxRadio = new TextBox();
            dataGridView1 = new DataGridView();
            Areadata = new DataGridViewTextBoxColumn();
            Volumendata = new DataGridViewTextBoxColumn();
            Basedata = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 28);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Valor de altura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 77);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 0;
            label2.Text = "Valor de Radio";
            // 
            // IngresarBtn
            // 
            IngresarBtn.Location = new Point(405, 28);
            IngresarBtn.Name = "IngresarBtn";
            IngresarBtn.Size = new Size(102, 69);
            IngresarBtn.TabIndex = 1;
            IngresarBtn.Text = "Ingresar";
            IngresarBtn.UseVisualStyleBackColor = true;
            IngresarBtn.Click += IngresarBtn_Click;
            // 
            // LimpiarBtn
            // 
            LimpiarBtn.Location = new Point(569, 28);
            LimpiarBtn.Name = "LimpiarBtn";
            LimpiarBtn.Size = new Size(102, 69);
            LimpiarBtn.TabIndex = 1;
            LimpiarBtn.Text = "Limpiar";
            LimpiarBtn.UseVisualStyleBackColor = true;
            LimpiarBtn.Click += LimpiarBtn_Click;
            // 
            // txtBoxAltura
            // 
            txtBoxAltura.Location = new Point(167, 29);
            txtBoxAltura.Name = "txtBoxAltura";
            txtBoxAltura.Size = new Size(163, 23);
            txtBoxAltura.TabIndex = 2;
            // 
            // txtBoxRadio
            // 
            txtBoxRadio.Location = new Point(167, 78);
            txtBoxRadio.Name = "txtBoxRadio";
            txtBoxRadio.Size = new Size(163, 23);
            txtBoxRadio.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Areadata, Volumendata, Basedata });
            dataGridView1.GridColor = SystemColors.ButtonFace;
            dataGridView1.Location = new Point(13, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(679, 350);
            dataGridView1.TabIndex = 4;
            // 
            // Areadata
            // 
            Areadata.HeaderText = "Área";
            Areadata.Name = "Areadata";
            // 
            // Volumendata
            // 
            Volumendata.HeaderText = "Volumen";
            Volumendata.Name = "Volumendata";
            // 
            // Basedata
            // 
            Basedata.HeaderText = "Base";
            Basedata.Name = "Basedata";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 482);
            Controls.Add(dataGridView1);
            Controls.Add(txtBoxRadio);
            Controls.Add(txtBoxAltura);
            Controls.Add(LimpiarBtn);
            Controls.Add(IngresarBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += CierroForms;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button IngresarBtn;
        private Button LimpiarBtn;
        private TextBox txtBoxAltura;
        private TextBox txtBoxRadio;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Areadata;
        private DataGridViewTextBoxColumn Volumendata;
        private DataGridViewTextBoxColumn Basedata;
    }
}