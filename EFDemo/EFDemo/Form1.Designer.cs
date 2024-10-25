namespace EFDemo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnObtenerTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbObtenerPorID = new System.Windows.Forms.TextBox();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txbCustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbContactName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbContactTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(776, 223);
            this.dgvCustomers.TabIndex = 0;
            // 
            // btnObtenerTodos
            // 
            this.btnObtenerTodos.Location = new System.Drawing.Point(678, 265);
            this.btnObtenerTodos.Name = "btnObtenerTodos";
            this.btnObtenerTodos.Size = new System.Drawing.Size(109, 34);
            this.btnObtenerTodos.TabIndex = 1;
            this.btnObtenerTodos.Text = "Cargar Todos";
            this.btnObtenerTodos.UseVisualStyleBackColor = true;
            this.btnObtenerTodos.Click += new System.EventHandler(this.btnObtenerTodos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "IDCustomer";
            // 
            // txbObtenerPorID
            // 
            this.txbObtenerPorID.Location = new System.Drawing.Point(104, 295);
            this.txbObtenerPorID.Name = "txbObtenerPorID";
            this.txbObtenerPorID.Size = new System.Drawing.Size(100, 22);
            this.txbObtenerPorID.TabIndex = 3;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(223, 295);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 4;
            this.btnTodos.Text = "Obtener";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(363, 397);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(91, 38);
            this.btnInsertar.TabIndex = 7;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txbCustomerID
            // 
            this.txbCustomerID.Location = new System.Drawing.Point(223, 349);
            this.txbCustomerID.Name = "txbCustomerID";
            this.txbCustomerID.Size = new System.Drawing.Size(100, 22);
            this.txbCustomerID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "CustomerID";
            // 
            // txbCompanyName
            // 
            this.txbCompanyName.Location = new System.Drawing.Point(223, 394);
            this.txbCompanyName.Name = "txbCompanyName";
            this.txbCompanyName.Size = new System.Drawing.Size(100, 22);
            this.txbCompanyName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "CompanyName";
            // 
            // txbContactName
            // 
            this.txbContactName.Location = new System.Drawing.Point(223, 439);
            this.txbContactName.Name = "txbContactName";
            this.txbContactName.Size = new System.Drawing.Size(100, 22);
            this.txbContactName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "ContactName";
            // 
            // txbContactTitle
            // 
            this.txbContactTitle.Location = new System.Drawing.Point(223, 486);
            this.txbContactTitle.Name = "txbContactTitle";
            this.txbContactTitle.Size = new System.Drawing.Size(100, 22);
            this.txbContactTitle.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "ContactTitle";
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(223, 533);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(100, 22);
            this.txbAddress.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Address";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(363, 349);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(91, 39);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(363, 447);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(91, 38);
            this.btnBorrar.TabIndex = 20;
            this.btnBorrar.Text = "Eliminar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 576);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbContactTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbContactName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbCompanyName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txbCustomerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.txbObtenerPorID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtenerTodos);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnObtenerTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbObtenerPorID;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txbCustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbContactName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbContactTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
    }
}

