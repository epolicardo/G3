﻿namespace Primaton.Front.Formularios
{
    partial class frm_QR
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.btn_barcode = new System.Windows.Forms.Button();
            this.txt_qr = new System.Windows.Forms.TextBox();
            this.btn_qr = new System.Windows.Forms.Button();
            this.lbl_encode = new System.Windows.Forms.Label();
            this.lbl_decode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_barcode);
            this.panel1.Controls.Add(this.btn_barcode);
            this.panel1.Controls.Add(this.txt_qr);
            this.panel1.Controls.Add(this.btn_qr);
            this.panel1.Controls.Add(this.lbl_encode);
            this.panel1.Controls.Add(this.lbl_decode);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 427);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "POR FAVOR NO TOCAR HDPS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(93, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 216);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txt_barcode
            // 
            this.txt_barcode.Location = new System.Drawing.Point(179, 322);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(100, 22);
            this.txt_barcode.TabIndex = 6;
            // 
            // btn_barcode
            // 
            this.btn_barcode.Location = new System.Drawing.Point(367, 322);
            this.btn_barcode.Name = "btn_barcode";
            this.btn_barcode.Size = new System.Drawing.Size(87, 23);
            this.btn_barcode.TabIndex = 0;
            this.btn_barcode.Text = "Bar-Code";
            this.btn_barcode.UseVisualStyleBackColor = true;
            this.btn_barcode.Click += new System.EventHandler(this.Btn_barcode_Click);
            // 
            // txt_qr
            // 
            this.txt_qr.Location = new System.Drawing.Point(179, 290);
            this.txt_qr.Name = "txt_qr";
            this.txt_qr.Size = new System.Drawing.Size(100, 22);
            this.txt_qr.TabIndex = 5;
            // 
            // btn_qr
            // 
            this.btn_qr.Location = new System.Drawing.Point(367, 290);
            this.btn_qr.Name = "btn_qr";
            this.btn_qr.Size = new System.Drawing.Size(75, 23);
            this.btn_qr.TabIndex = 1;
            this.btn_qr.Text = "QR";
            this.btn_qr.UseVisualStyleBackColor = true;
            this.btn_qr.Click += new System.EventHandler(this.Btn_qr_Click);
            // 
            // lbl_encode
            // 
            this.lbl_encode.AutoSize = true;
            this.lbl_encode.Location = new System.Drawing.Point(3, 325);
            this.lbl_encode.Name = "lbl_encode";
            this.lbl_encode.Size = new System.Drawing.Size(80, 17);
            this.lbl_encode.TabIndex = 2;
            this.lbl_encode.Text = "BAR-CODE";
            // 
            // lbl_decode
            // 
            this.lbl_decode.AutoSize = true;
            this.lbl_decode.Location = new System.Drawing.Point(28, 290);
            this.lbl_decode.Name = "lbl_decode";
            this.lbl_decode.Size = new System.Drawing.Size(29, 17);
            this.lbl_decode.TabIndex = 3;
            this.lbl_decode.Text = "QR";
            // 
            // frm_QR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 443);
            this.Controls.Add(this.panel1);
            this.Name = "frm_QR";
            this.Text = "frm_QR";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Button btn_barcode;
        private System.Windows.Forms.TextBox txt_qr;
        private System.Windows.Forms.Button btn_qr;
        private System.Windows.Forms.Label lbl_encode;
        private System.Windows.Forms.Label lbl_decode;
    }
}