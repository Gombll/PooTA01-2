namespace PooTA01_2
{
    partial class RegistroProducto
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
            label4 = new Label();
            textBoxCodigo = new TextBox();
            textBoxProducto = new TextBox();
            textBoxCantidad = new TextBox();
            textBoxDescripcion = new TextBox();
            buttonRegistrar = new Button();
            buttonActualizar = new Button();
            buttonBorrar = new Button();
            dataGridViewDatos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            textBoxBusqueda = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(208, 23);
            label1.TabIndex = 0;
            label1.Text = "Codigo de Producto: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 70);
            label2.Name = "label2";
            label2.Size = new Size(183, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre Producto: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(111, 112);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 2;
            label3.Text = "Cantidad: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(91, 155);
            label4.Name = "label4";
            label4.Size = new Size(129, 23);
            label4.TabIndex = 3;
            label4.Text = "Descripcion: ";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(226, 34);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(253, 23);
            textBoxCodigo.TabIndex = 4;
            // 
            // textBoxProducto
            // 
            textBoxProducto.Location = new Point(226, 70);
            textBoxProducto.Name = "textBoxProducto";
            textBoxProducto.Size = new Size(253, 23);
            textBoxProducto.TabIndex = 5;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(226, 112);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(253, 23);
            textBoxCantidad.TabIndex = 6;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(226, 155);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(253, 23);
            textBoxDescripcion.TabIndex = 7;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.Location = new Point(61, 252);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(89, 27);
            buttonRegistrar.TabIndex = 8;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = true;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Location = new Point(190, 252);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(89, 27);
            buttonActualizar.TabIndex = 9;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Location = new Point(329, 252);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(89, 27);
            buttonBorrar.TabIndex = 10;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // dataGridViewDatos
            // 
            dataGridViewDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDatos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Cantidad, Descripcion });
            dataGridViewDatos.Location = new Point(23, 303);
            dataGridViewDatos.Name = "dataGridViewDatos";
            dataGridViewDatos.Size = new Size(444, 174);
            dataGridViewDatos.TabIndex = 11;
            dataGridViewDatos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // textBoxBusqueda
            // 
            textBoxBusqueda.Location = new Point(122, 210);
            textBoxBusqueda.Name = "textBoxBusqueda";
            textBoxBusqueda.Size = new Size(253, 23);
            textBoxBusqueda.TabIndex = 12;
            textBoxBusqueda.Text = "Busqueda";
            textBoxBusqueda.TextChanged += textBoxBusqueda_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 488);
            Controls.Add(textBoxBusqueda);
            Controls.Add(dataGridViewDatos);
            Controls.Add(buttonBorrar);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonRegistrar);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxCantidad);
            Controls.Add(textBoxProducto);
            Controls.Add(textBoxCodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Registro de Inventario";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxCodigo;
        private TextBox textBoxProducto;
        private TextBox textBoxCantidad;
        private TextBox textBoxDescripcion;
        private Button buttonRegistrar;
        private Button buttonActualizar;
        private Button buttonBorrar;
        private DataGridView dataGridViewDatos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Descripcion;
        private TextBox textBoxBusqueda;
    }
}
