namespace ICatalogo
{
    partial class FormPrincipal
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelEpisodio = new System.Windows.Forms.Label();
            this.labelTemporada = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.cboBox = new System.Windows.Forms.ComboBox();
            this.txtBox = new System.Windows.Forms.RichTextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnMore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Constantia", 32F);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(28, 23);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(170, 66);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Titulo";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.ForeColor = System.Drawing.Color.White;
            this.labelCategoria.Location = new System.Drawing.Point(38, 360);
            this.labelCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(100, 26);
            this.labelCategoria.TabIndex = 3;
            this.labelCategoria.Text = "Categoria";
            // 
            // labelEpisodio
            // 
            this.labelEpisodio.AutoSize = true;
            this.labelEpisodio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEpisodio.ForeColor = System.Drawing.Color.White;
            this.labelEpisodio.Location = new System.Drawing.Point(472, 360);
            this.labelEpisodio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEpisodio.Name = "labelEpisodio";
            this.labelEpisodio.Size = new System.Drawing.Size(90, 22);
            this.labelEpisodio.TabIndex = 4;
            this.labelEpisodio.Text = "Episodios";
            // 
            // labelTemporada
            // 
            this.labelTemporada.AutoSize = true;
            this.labelTemporada.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemporada.ForeColor = System.Drawing.Color.White;
            this.labelTemporada.Location = new System.Drawing.Point(326, 360);
            this.labelTemporada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTemporada.Name = "labelTemporada";
            this.labelTemporada.Size = new System.Drawing.Size(99, 22);
            this.labelTemporada.TabIndex = 5;
            this.labelTemporada.Text = "Temporada";
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Black;
            this.btnAnterior.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(41, 414);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(84, 50);
            this.btnAnterior.TabIndex = 7;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Black;
            this.btnSiguiente.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(475, 414);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(87, 50);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // cboBox
            // 
            this.cboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.cboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBox.ForeColor = System.Drawing.Color.White;
            this.cboBox.FormattingEnabled = true;
            this.cboBox.Items.AddRange(new object[] {
            "Peliculas",
            "Series"});
            this.cboBox.Location = new System.Drawing.Point(184, 414);
            this.cboBox.Name = "cboBox";
            this.cboBox.Size = new System.Drawing.Size(220, 33);
            this.cboBox.TabIndex = 11;
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(44)))), ((int)(((byte)(63)))));
            this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.ForeColor = System.Drawing.Color.White;
            this.txtBox.Location = new System.Drawing.Point(41, 119);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(521, 228);
            this.txtBox.TabIndex = 12;
            this.txtBox.Text = "";
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(591, 78);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(467, 319);
            this.picBox.TabIndex = 13;
            this.picBox.TabStop = false;
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.Black;
            this.btnMore.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMore.ForeColor = System.Drawing.Color.White;
            this.btnMore.Location = new System.Drawing.Point(959, 432);
            this.btnMore.Margin = new System.Windows.Forms.Padding(4);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(99, 32);
            this.btnMore.TabIndex = 15;
            this.btnMore.Text = "Añadir";
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1093, 501);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.cboBox);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.labelTemporada);
            this.Controls.Add(this.labelEpisodio);
            this.Controls.Add(this.labelCategoria);
            this.Controls.Add(this.labelTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPrincipal";
            this.Text = "Catalogo";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelEpisodio;
        private System.Windows.Forms.Label labelTemporada;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.ComboBox cboBox;
        private System.Windows.Forms.RichTextBox txtBox;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnMore;
    }
}

