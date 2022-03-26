namespace Examen_2_JorgeLagos
{
    partial class FrmPedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.IdProductoTextBox = new System.Windows.Forms.TextBox();
            this.NombreProductoTextBox = new System.Windows.Forms.TextBox();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.IsvTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalPagarTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PedidosDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Producto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "SubTotal";
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.Location = new System.Drawing.Point(390, 70);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.NombreClienteTextBox.TabIndex = 6;
            // 
            // IdProductoTextBox
            // 
            this.IdProductoTextBox.Location = new System.Drawing.Point(94, 107);
            this.IdProductoTextBox.Name = "IdProductoTextBox";
            this.IdProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdProductoTextBox.TabIndex = 7;
            // 
            // NombreProductoTextBox
            // 
            this.NombreProductoTextBox.Location = new System.Drawing.Point(305, 111);
            this.NombreProductoTextBox.Name = "NombreProductoTextBox";
            this.NombreProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.NombreProductoTextBox.TabIndex = 8;
            this.NombreProductoTextBox.TextChanged += new System.EventHandler(this.NombreProductoTextBox_TextChanged);
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(502, 107);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.CantidadTextBox.TabIndex = 9;
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(94, 172);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubTotalTextBox.TabIndex = 10;
            // 
            // IsvTextBox
            // 
            this.IsvTextBox.Location = new System.Drawing.Point(305, 172);
            this.IsvTextBox.Name = "IsvTextBox";
            this.IsvTextBox.Size = new System.Drawing.Size(100, 20);
            this.IsvTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Isv";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TotalPagarTextBox
            // 
            this.TotalPagarTextBox.Location = new System.Drawing.Point(502, 176);
            this.TotalPagarTextBox.Name = "TotalPagarTextBox";
            this.TotalPagarTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalPagarTextBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total a Pagar";
            // 
            // PedidosDataGridView
            // 
            this.PedidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PedidosDataGridView.Location = new System.Drawing.Point(-2, 264);
            this.PedidosDataGridView.Name = "PedidosDataGridView";
            this.PedidosDataGridView.Size = new System.Drawing.Size(807, 189);
            this.PedidosDataGridView.TabIndex = 15;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PedidosDataGridView);
            this.Controls.Add(this.TotalPagarTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IsvTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.CantidadTextBox);
            this.Controls.Add(this.NombreProductoTextBox);
            this.Controls.Add(this.IdProductoTextBox);
            this.Controls.Add(this.NombreClienteTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPedido";
            this.Text = "FrmPedido";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NombreClienteTextBox;
        private System.Windows.Forms.TextBox IdProductoTextBox;
        private System.Windows.Forms.TextBox NombreProductoTextBox;
        private System.Windows.Forms.TextBox CantidadTextBox;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.TextBox IsvTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TotalPagarTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView PedidosDataGridView;
    }
}