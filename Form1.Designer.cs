namespace Proyecto
{
    partial class Base_de_datos_SQLite
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
            label3 = new Label();
            NombreTXTB = new TextBox();
            IDTXTBX = new TextBox();
            InsertarBTN = new Button();
            ActualizarBTN = new Button();
            EliminarBTN = new Button();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(247, 9);
            label1.Name = "label1";
            label1.Size = new Size(266, 30);
            label1.TabIndex = 0;
            label1.Text = "Base de datos en SQLite";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 89);
            label2.Name = "label2";
            label2.Size = new Size(69, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(27, 23);
            label3.TabIndex = 2;
            label3.Text = "ID";
            // 
            // NombreTXTB
            // 
            NombreTXTB.Location = new Point(83, 89);
            NombreTXTB.Name = "NombreTXTB";
            NombreTXTB.Size = new Size(136, 23);
            NombreTXTB.TabIndex = 3;
            // 
            // IDTXTBX
            // 
            IDTXTBX.Location = new Point(50, 156);
            IDTXTBX.Name = "IDTXTBX";
            IDTXTBX.Size = new Size(169, 23);
            IDTXTBX.TabIndex = 4;
            // 
            // InsertarBTN
            // 
            InsertarBTN.Font = new Font("Sitka Text", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InsertarBTN.Location = new Point(27, 214);
            InsertarBTN.Name = "InsertarBTN";
            InsertarBTN.Size = new Size(181, 47);
            InsertarBTN.TabIndex = 5;
            InsertarBTN.Text = "Insertar";
            InsertarBTN.UseVisualStyleBackColor = true;
            // 
            // ActualizarBTN
            // 
            ActualizarBTN.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ActualizarBTN.Location = new Point(27, 285);
            ActualizarBTN.Name = "ActualizarBTN";
            ActualizarBTN.Size = new Size(181, 47);
            ActualizarBTN.TabIndex = 6;
            ActualizarBTN.Text = "Actualizar";
            ActualizarBTN.UseVisualStyleBackColor = true;
            // 
            // EliminarBTN
            // 
            EliminarBTN.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EliminarBTN.Location = new Point(27, 351);
            EliminarBTN.Name = "EliminarBTN";
            EliminarBTN.Size = new Size(181, 43);
            EliminarBTN.TabIndex = 7;
            EliminarBTN.Text = "Eliminar";
            EliminarBTN.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, ID });
            dataGridView1.Location = new Point(236, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(552, 363);
            dataGridView1.TabIndex = 8;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Base_de_datos_SQLite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(EliminarBTN);
            Controls.Add(ActualizarBTN);
            Controls.Add(InsertarBTN);
            Controls.Add(IDTXTBX);
            Controls.Add(NombreTXTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Base_de_datos_SQLite";
            Text = "Base de datos SQLite";
            Load += Base_de_datos_SQLite_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NombreTXTB;
        private TextBox IDTXTBX;
        private Button InsertarBTN;
        private Button ActualizarBTN;
        private Button EliminarBTN;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn ID;
    }
}
