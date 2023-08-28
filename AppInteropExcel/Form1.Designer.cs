namespace AppInteropExcel
{ 
    partial class Form1
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
            this.txttexto = new System.Windows.Forms.TextBox();
            this.btndocx = new System.Windows.Forms.Button();
            this.btnxls = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txttexto
            // 
            this.txttexto.Location = new System.Drawing.Point(9, 59);
            this.txttexto.Name = "txttexto";
            this.txttexto.Size = new System.Drawing.Size(336, 20);
            this.txttexto.TabIndex = 1;
            // 
            // btndocx
            // 
            this.btndocx.BackgroundImage = global::AppInteropExcel.Properties.Resources.xls;
            this.btndocx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndocx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndocx.Location = new System.Drawing.Point(199, 115);
            this.btndocx.Name = "btndocx";
            this.btndocx.Size = new System.Drawing.Size(74, 62);
            this.btndocx.TabIndex = 2;
            this.btndocx.UseVisualStyleBackColor = true;
            this.btndocx.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnxls
            // 
            this.btnxls.BackColor = System.Drawing.Color.Transparent;
            this.btnxls.BackgroundImage = global::AppInteropExcel.Properties.Resources.doc;
            this.btnxls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnxls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxls.Location = new System.Drawing.Point(80, 115);
            this.btnxls.Name = "btnxls";
            this.btnxls.Size = new System.Drawing.Size(74, 62);
            this.btnxls.TabIndex = 0;
            this.btnxls.UseVisualStyleBackColor = false;
            this.btnxls.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aplicacion Interop Word/Excel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(357, 222);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndocx);
            this.Controls.Add(this.txttexto);
            this.Controls.Add(this.btnxls);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnxls;
        private System.Windows.Forms.TextBox txttexto;
        private System.Windows.Forms.Button btndocx;
        private System.Windows.Forms.Label label1;
    }
}

