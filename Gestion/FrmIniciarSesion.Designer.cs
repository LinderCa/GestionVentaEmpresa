namespace Gestion
{
    partial class FrmIniciarSesion
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
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.ErrNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtClave
            // 
            this.TxtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.Location = new System.Drawing.Point(11, 107);
            this.TxtClave.Margin = new System.Windows.Forms.Padding(2);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(210, 21);
            this.TxtClave.TabIndex = 39;
            this.TxtClave.Validating += new System.ComponentModel.CancelEventHandler(this.TxtClave_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Clave";
            // 
            // TxtNombreDeUsuario
            // 
            this.TxtNombreDeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreDeUsuario.Location = new System.Drawing.Point(11, 42);
            this.TxtNombreDeUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombreDeUsuario.Name = "TxtNombreDeUsuario";
            this.TxtNombreDeUsuario.Size = new System.Drawing.Size(210, 21);
            this.TxtNombreDeUsuario.TabIndex = 38;
            this.TxtNombreDeUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.TxtClave_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nombre de usuario";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(146, 161);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(75, 23);
            this.BtnIngresar.TabIndex = 42;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(65, 161);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 43;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // ErrNotificador
            // 
            this.ErrNotificador.ContainerControl = this;
            // 
            // FrmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(240, 205);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombreDeUsuario);
            this.Controls.Add(this.label1);
            this.Name = "FrmIniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar sesión";
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombreDeUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ErrorProvider ErrNotificador;
    }
}