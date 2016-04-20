namespace Cine
{
    partial class Facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNiños = new System.Windows.Forms.ComboBox();
            this.txtAdulto = new System.Windows.Forms.ComboBox();
            this.txtMayor = new System.Windows.Forms.ComboBox();
            this.txtPago = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFactu = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(48, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "tiket de Pelicula";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(48, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Forma de Pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(602, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precios";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(530, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "niños";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(527, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Adulto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(496, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Adulto mayor";
            // 
            // txtNiños
            // 
            this.txtNiños.FormattingEnabled = true;
            this.txtNiños.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.txtNiños.Location = new System.Drawing.Point(605, 229);
            this.txtNiños.Name = "txtNiños";
            this.txtNiños.Size = new System.Drawing.Size(79, 21);
            this.txtNiños.TabIndex = 13;
            this.txtNiños.SelectedIndexChanged += new System.EventHandler(this.txtNiños_SelectedIndexChanged);
            // 
            // txtAdulto
            // 
            this.txtAdulto.FormattingEnabled = true;
            this.txtAdulto.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.txtAdulto.Location = new System.Drawing.Point(605, 285);
            this.txtAdulto.Name = "txtAdulto";
            this.txtAdulto.Size = new System.Drawing.Size(79, 21);
            this.txtAdulto.TabIndex = 14;
            // 
            // txtMayor
            // 
            this.txtMayor.FormattingEnabled = true;
            this.txtMayor.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.txtMayor.Location = new System.Drawing.Point(605, 332);
            this.txtMayor.Name = "txtMayor";
            this.txtMayor.Size = new System.Drawing.Size(79, 21);
            this.txtMayor.TabIndex = 15;
            // 
            // txtPago
            // 
            this.txtPago.FormattingEnabled = true;
            this.txtPago.Items.AddRange(new object[] {
            "tarjeta debito",
            "tarjeta credito",
            "efectivo"});
            this.txtPago.Location = new System.Drawing.Point(168, 220);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(126, 21);
            this.txtPago.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Facturar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFactu
            // 
            this.txtFactu.Location = new System.Drawing.Point(168, 34);
            this.txtFactu.Name = "txtFactu";
            this.txtFactu.Size = new System.Drawing.Size(516, 160);
            this.txtFactu.TabIndex = 19;
            this.txtFactu.Text = "";
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(701, 442);
            this.Controls.Add(this.txtFactu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.txtMayor);
            this.Controls.Add(this.txtAdulto);
            this.Controls.Add(this.txtNiños);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtNiños;
        private System.Windows.Forms.ComboBox txtAdulto;
        private System.Windows.Forms.ComboBox txtMayor;
        private System.Windows.Forms.ComboBox txtPago;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtFactu;
    }
}