
namespace Banquito
{
    partial class MenuP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuP));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_banco = new System.Windows.Forms.Label();
            this.lbl_cuenta = new System.Windows.Forms.Label();
            this.txb_cuenta = new System.Windows.Forms.TextBox();
            this.btn_deposito = new System.Windows.Forms.Button();
            this.btn_retiro = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_banco
            // 
            this.lbl_banco.AutoSize = true;
            this.lbl_banco.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_banco.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_banco.Location = new System.Drawing.Point(232, 29);
            this.lbl_banco.Name = "lbl_banco";
            this.lbl_banco.Size = new System.Drawing.Size(369, 77);
            this.lbl_banco.TabIndex = 1;
            this.lbl_banco.Text = "BANCO MARIADB";
            // 
            // lbl_cuenta
            // 
            this.lbl_cuenta.AutoSize = true;
            this.lbl_cuenta.Font = new System.Drawing.Font("Code Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.lbl_cuenta.Location = new System.Drawing.Point(493, 106);
            this.lbl_cuenta.Name = "lbl_cuenta";
            this.lbl_cuenta.Size = new System.Drawing.Size(81, 22);
            this.lbl_cuenta.TabIndex = 2;
            this.lbl_cuenta.Text = "Cuenta:";
            // 
            // txb_cuenta
            // 
            this.txb_cuenta.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_cuenta.Location = new System.Drawing.Point(580, 102);
            this.txb_cuenta.Name = "txb_cuenta";
            this.txb_cuenta.ReadOnly = true;
            this.txb_cuenta.Size = new System.Drawing.Size(100, 27);
            this.txb_cuenta.TabIndex = 3;
            // 
            // btn_deposito
            // 
            this.btn_deposito.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_deposito.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deposito.Location = new System.Drawing.Point(152, 229);
            this.btn_deposito.Name = "btn_deposito";
            this.btn_deposito.Size = new System.Drawing.Size(186, 59);
            this.btn_deposito.TabIndex = 4;
            this.btn_deposito.Text = "Deposito";
            this.btn_deposito.UseVisualStyleBackColor = true;
            // 
            // btn_retiro
            // 
            this.btn_retiro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_retiro.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retiro.Location = new System.Drawing.Point(543, 229);
            this.btn_retiro.Name = "btn_retiro";
            this.btn_retiro.Size = new System.Drawing.Size(179, 59);
            this.btn_retiro.TabIndex = 5;
            this.btn_retiro.Text = "Retiro";
            this.btn_retiro.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_salir.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(543, 339);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(179, 59);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // btn_consulta
            // 
            this.btn_consulta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_consulta.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulta.Location = new System.Drawing.Point(152, 339);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(186, 59);
            this.btn_consulta.TabIndex = 7;
            this.btn_consulta.Text = "Consulta";
            this.btn_consulta.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(452, 229);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(57, 339);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(452, 339);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(58, 59);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // MenuP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_retiro);
            this.Controls.Add(this.btn_deposito);
            this.Controls.Add(this.txb_cuenta);
            this.Controls.Add(this.lbl_cuenta);
            this.Controls.Add(this.lbl_banco);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuP";
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.MenuP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_banco;
        private System.Windows.Forms.Label lbl_cuenta;
        private System.Windows.Forms.TextBox txb_cuenta;
        private System.Windows.Forms.Button btn_deposito;
        private System.Windows.Forms.Button btn_retiro;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

