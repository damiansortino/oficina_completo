
namespace WinFormsApp1
{
    partial class Main
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
            this.textbox_poliza = new System.Windows.Forms.TextBox();
            this.textbox_asegurado = new System.Windows.Forms.TextBox();
            this.textbox_rama = new System.Windows.Forms.TextBox();
            this.textbox_endoso = new System.Windows.Forms.TextBox();
            this.textbox_cuota = new System.Windows.Forms.TextBox();
            this.textbox_importe = new System.Windows.Forms.TextBox();
            this.muestradatos = new System.Windows.Forms.DataGridView();
            this.btn_nuevocobro = new System.Windows.Forms.Button();
            this.panel_recibo = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textbox_vencimiento = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_barra = new System.Windows.Forms.Label();
            this.textbox_barra = new System.Windows.Forms.TextBox();
            this.label_CobranzasHoy = new System.Windows.Forms.Label();
            this.linkLabel_UserAct = new System.Windows.Forms.LinkLabel();
            this.button_IniciarSesion = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.muestradatos)).BeginInit();
            this.panel_recibo.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_poliza
            // 
            this.textbox_poliza.Location = new System.Drawing.Point(117, 65);
            this.textbox_poliza.Name = "textbox_poliza";
            this.textbox_poliza.Size = new System.Drawing.Size(139, 23);
            this.textbox_poliza.TabIndex = 0;
            // 
            // textbox_asegurado
            // 
            this.textbox_asegurado.Location = new System.Drawing.Point(117, 94);
            this.textbox_asegurado.Name = "textbox_asegurado";
            this.textbox_asegurado.Size = new System.Drawing.Size(302, 23);
            this.textbox_asegurado.TabIndex = 1;
            // 
            // textbox_rama
            // 
            this.textbox_rama.Location = new System.Drawing.Point(117, 123);
            this.textbox_rama.Name = "textbox_rama";
            this.textbox_rama.Size = new System.Drawing.Size(139, 23);
            this.textbox_rama.TabIndex = 2;
            // 
            // textbox_endoso
            // 
            this.textbox_endoso.Location = new System.Drawing.Point(117, 152);
            this.textbox_endoso.Name = "textbox_endoso";
            this.textbox_endoso.Size = new System.Drawing.Size(139, 23);
            this.textbox_endoso.TabIndex = 3;
            // 
            // textbox_cuota
            // 
            this.textbox_cuota.Location = new System.Drawing.Point(117, 181);
            this.textbox_cuota.Name = "textbox_cuota";
            this.textbox_cuota.Size = new System.Drawing.Size(139, 23);
            this.textbox_cuota.TabIndex = 4;
            // 
            // textbox_importe
            // 
            this.textbox_importe.Location = new System.Drawing.Point(117, 210);
            this.textbox_importe.Name = "textbox_importe";
            this.textbox_importe.Size = new System.Drawing.Size(139, 23);
            this.textbox_importe.TabIndex = 5;
            // 
            // muestradatos
            // 
            this.muestradatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.muestradatos.Location = new System.Drawing.Point(468, 101);
            this.muestradatos.Name = "muestradatos";
            this.muestradatos.RowTemplate.Height = 25;
            this.muestradatos.Size = new System.Drawing.Size(477, 374);
            this.muestradatos.TabIndex = 6;
            this.muestradatos.Visible = false;
            // 
            // btn_nuevocobro
            // 
            this.btn_nuevocobro.Enabled = false;
            this.btn_nuevocobro.Location = new System.Drawing.Point(12, 24);
            this.btn_nuevocobro.Name = "btn_nuevocobro";
            this.btn_nuevocobro.Size = new System.Drawing.Size(114, 23);
            this.btn_nuevocobro.TabIndex = 7;
            this.btn_nuevocobro.Text = "Nuevo Cobro";
            this.btn_nuevocobro.UseVisualStyleBackColor = true;
            this.btn_nuevocobro.Click += new System.EventHandler(this.btn_nuevocobro_Click);
            // 
            // panel_recibo
            // 
            this.panel_recibo.Controls.Add(this.label8);
            this.panel_recibo.Controls.Add(this.textbox_vencimiento);
            this.panel_recibo.Controls.Add(this.btn_cancelar);
            this.panel_recibo.Controls.Add(this.btn_aceptar);
            this.panel_recibo.Controls.Add(this.label6);
            this.panel_recibo.Controls.Add(this.label5);
            this.panel_recibo.Controls.Add(this.label4);
            this.panel_recibo.Controls.Add(this.label3);
            this.panel_recibo.Controls.Add(this.label2);
            this.panel_recibo.Controls.Add(this.label1);
            this.panel_recibo.Controls.Add(this.label_barra);
            this.panel_recibo.Controls.Add(this.textbox_barra);
            this.panel_recibo.Controls.Add(this.textbox_poliza);
            this.panel_recibo.Controls.Add(this.textbox_asegurado);
            this.panel_recibo.Controls.Add(this.textbox_rama);
            this.panel_recibo.Controls.Add(this.textbox_importe);
            this.panel_recibo.Controls.Add(this.textbox_endoso);
            this.panel_recibo.Controls.Add(this.textbox_cuota);
            this.panel_recibo.Location = new System.Drawing.Point(12, 72);
            this.panel_recibo.Name = "panel_recibo";
            this.panel_recibo.Size = new System.Drawing.Size(450, 334);
            this.panel_recibo.TabIndex = 8;
            this.panel_recibo.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Vencimiento";
            // 
            // textbox_vencimiento
            // 
            this.textbox_vencimiento.Location = new System.Drawing.Point(117, 242);
            this.textbox_vencimiento.Name = "textbox_vencimiento";
            this.textbox_vencimiento.Size = new System.Drawing.Size(139, 23);
            this.textbox_vencimiento.TabIndex = 16;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(280, 298);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(79, 23);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(177, 298);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(79, 23);
            this.btn_aceptar.TabIndex = 14;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Importe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cuota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Endoso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Asegurado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Póliza";
            // 
            // label_barra
            // 
            this.label_barra.AutoSize = true;
            this.label_barra.Location = new System.Drawing.Point(192, 9);
            this.label_barra.Name = "label_barra";
            this.label_barra.Size = new System.Drawing.Size(97, 15);
            this.label_barra.TabIndex = 7;
            this.label_barra.Text = "Código de Barras";
            // 
            // textbox_barra
            // 
            this.textbox_barra.Location = new System.Drawing.Point(17, 27);
            this.textbox_barra.Name = "textbox_barra";
            this.textbox_barra.Size = new System.Drawing.Size(372, 23);
            this.textbox_barra.TabIndex = 6;
            // 
            // label_CobranzasHoy
            // 
            this.label_CobranzasHoy.AutoSize = true;
            this.label_CobranzasHoy.Location = new System.Drawing.Point(693, 72);
            this.label_CobranzasHoy.Name = "label_CobranzasHoy";
            this.label_CobranzasHoy.Size = new System.Drawing.Size(87, 15);
            this.label_CobranzasHoy.TabIndex = 9;
            this.label_CobranzasHoy.Text = "Cobranzas Hoy";
            this.label_CobranzasHoy.Visible = false;
            // 
            // linkLabel_UserAct
            // 
            this.linkLabel_UserAct.AutoSize = true;
            this.linkLabel_UserAct.Location = new System.Drawing.Point(846, 14);
            this.linkLabel_UserAct.Name = "linkLabel_UserAct";
            this.linkLabel_UserAct.Size = new System.Drawing.Size(84, 15);
            this.linkLabel_UserAct.TabIndex = 11;
            this.linkLabel_UserAct.TabStop = true;
            this.linkLabel_UserAct.Text = "Usuario Activo";
            this.linkLabel_UserAct.Visible = false;
            // 
            // button_IniciarSesion
            // 
            this.button_IniciarSesion.Location = new System.Drawing.Point(663, 14);
            this.button_IniciarSesion.Name = "button_IniciarSesion";
            this.button_IniciarSesion.Size = new System.Drawing.Size(117, 24);
            this.button_IniciarSesion.TabIndex = 12;
            this.button_IniciarSesion.Text = "Iniciar Sesión";
            this.button_IniciarSesion.UseVisualStyleBackColor = true;
            this.button_IniciarSesion.Click += new System.EventHandler(this.button_IniciarSesion_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(808, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Hola";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 487);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_IniciarSesion);
            this.Controls.Add(this.linkLabel_UserAct);
            this.Controls.Add(this.label_CobranzasHoy);
            this.Controls.Add(this.panel_recibo);
            this.Controls.Add(this.btn_nuevocobro);
            this.Controls.Add(this.muestradatos);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Caja Diaria";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.muestradatos)).EndInit();
            this.panel_recibo.ResumeLayout(false);
            this.panel_recibo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_poliza;
        private System.Windows.Forms.TextBox textbox_asegurado;
        private System.Windows.Forms.TextBox textbox_rama;
        private System.Windows.Forms.TextBox textbox_endoso;
        private System.Windows.Forms.TextBox textbox_cuota;
        private System.Windows.Forms.TextBox textbox_importe;
        private System.Windows.Forms.DataGridView muestradatos;
        private System.Windows.Forms.Button btn_nuevocobro;
        private System.Windows.Forms.Panel panel_recibo;
        private System.Windows.Forms.TextBox textbox_barra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_barra;
        private System.Windows.Forms.Label label_CobranzasHoy;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textbox_vencimiento;
        private System.Windows.Forms.LinkLabel linkLabel_UserAct;
        private System.Windows.Forms.Button button_IniciarSesion;
        private System.Windows.Forms.Label label9;
    }
}

