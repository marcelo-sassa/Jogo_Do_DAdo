namespace JogoDoDado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblresjg1 = new System.Windows.Forms.Label();
            this.lblresjg2 = new System.Windows.Forms.Label();
            this.btnjg1 = new System.Windows.Forms.Button();
            this.btnjg2 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogador 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jogador 2:";
            // 
            // lblresjg1
            // 
            this.lblresjg1.AutoSize = true;
            this.lblresjg1.Location = new System.Drawing.Point(49, 61);
            this.lblresjg1.Name = "lblresjg1";
            this.lblresjg1.Size = new System.Drawing.Size(0, 13);
            this.lblresjg1.TabIndex = 2;
            // 
            // lblresjg2
            // 
            this.lblresjg2.AutoSize = true;
            this.lblresjg2.Location = new System.Drawing.Point(178, 61);
            this.lblresjg2.Name = "lblresjg2";
            this.lblresjg2.Size = new System.Drawing.Size(0, 13);
            this.lblresjg2.TabIndex = 3;
            // 
            // btnjg1
            // 
            this.btnjg1.Location = new System.Drawing.Point(12, 87);
            this.btnjg1.Name = "btnjg1";
            this.btnjg1.Size = new System.Drawing.Size(57, 23);
            this.btnjg1.TabIndex = 4;
            this.btnjg1.Text = "Jogar";
            this.btnjg1.UseVisualStyleBackColor = true;
            this.btnjg1.Click += new System.EventHandler(this.btnjg1_Click);
            // 
            // btnjg2
            // 
            this.btnjg2.Location = new System.Drawing.Point(141, 87);
            this.btnjg2.Name = "btnjg2";
            this.btnjg2.Size = new System.Drawing.Size(57, 23);
            this.btnjg2.TabIndex = 5;
            this.btnjg2.Text = "Jogar";
            this.btnjg2.UseVisualStyleBackColor = true;
            this.btnjg2.Click += new System.EventHandler(this.btnjg2_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(25, 122);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(66, 160);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(74, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(0, 13);
            this.lblHeader.TabIndex = 10;
            this.lblHeader.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 186);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnjg2);
            this.Controls.Add(this.btnjg1);
            this.Controls.Add(this.lblresjg2);
            this.Controls.Add(this.lblresjg1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblresjg1;
        private System.Windows.Forms.Label lblresjg2;
        private System.Windows.Forms.Button btnjg1;
        private System.Windows.Forms.Button btnjg2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHeader;
    }
}

