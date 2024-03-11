namespace Quiz
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
            this.kerdes = new System.Windows.Forms.Label();
            this.valasz1 = new System.Windows.Forms.Label();
            this.valasz2 = new System.Windows.Forms.Label();
            this.valasz3 = new System.Windows.Forms.Label();
            this.ckeckAnsw = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.valasz1C = new System.Windows.Forms.RadioButton();
            this.valasz2C = new System.Windows.Forms.RadioButton();
            this.valasz3C = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // kerdes
            // 
            this.kerdes.AutoSize = true;
            this.kerdes.Location = new System.Drawing.Point(31, 46);
            this.kerdes.Name = "kerdes";
            this.kerdes.Size = new System.Drawing.Size(49, 16);
            this.kerdes.TabIndex = 0;
            this.kerdes.Text = "kérdés";
            // 
            // valasz1
            // 
            this.valasz1.AutoSize = true;
            this.valasz1.Location = new System.Drawing.Point(173, 94);
            this.valasz1.Name = "valasz1";
            this.valasz1.Size = new System.Drawing.Size(53, 16);
            this.valasz1.TabIndex = 1;
            this.valasz1.Text = "valasz1";
            // 
            // valasz2
            // 
            this.valasz2.AutoSize = true;
            this.valasz2.Location = new System.Drawing.Point(173, 141);
            this.valasz2.Name = "valasz2";
            this.valasz2.Size = new System.Drawing.Size(53, 16);
            this.valasz2.TabIndex = 2;
            this.valasz2.Text = "valasz2";
            // 
            // valasz3
            // 
            this.valasz3.AutoSize = true;
            this.valasz3.Location = new System.Drawing.Point(173, 186);
            this.valasz3.Name = "valasz3";
            this.valasz3.Size = new System.Drawing.Size(53, 16);
            this.valasz3.TabIndex = 3;
            this.valasz3.Text = "valasz3";
            // 
            // ckeckAnsw
            // 
            this.ckeckAnsw.Location = new System.Drawing.Point(67, 347);
            this.ckeckAnsw.Name = "ckeckAnsw";
            this.ckeckAnsw.Size = new System.Drawing.Size(221, 23);
            this.ckeckAnsw.TabIndex = 9;
            this.ckeckAnsw.Text = "Helyes válaszok megtekintése";
            this.ckeckAnsw.UseVisualStyleBackColor = true;
            this.ckeckAnsw.Click += new System.EventHandler(this.ckeckAnsw_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(322, 347);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(126, 23);
            this.next.TabIndex = 10;
            this.next.Text = "Következő kérdés";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click_1);
            // 
            // valasz1C
            // 
            this.valasz1C.AutoSize = true;
            this.valasz1C.Location = new System.Drawing.Point(134, 94);
            this.valasz1C.Name = "valasz1C";
            this.valasz1C.Size = new System.Drawing.Size(17, 16);
            this.valasz1C.TabIndex = 11;
            this.valasz1C.TabStop = true;
            this.valasz1C.UseVisualStyleBackColor = true;
            // 
            // valasz2C
            // 
            this.valasz2C.AutoSize = true;
            this.valasz2C.Location = new System.Drawing.Point(134, 141);
            this.valasz2C.Name = "valasz2C";
            this.valasz2C.Size = new System.Drawing.Size(17, 16);
            this.valasz2C.TabIndex = 12;
            this.valasz2C.TabStop = true;
            this.valasz2C.UseVisualStyleBackColor = true;
            // 
            // valasz3C
            // 
            this.valasz3C.AutoSize = true;
            this.valasz3C.Location = new System.Drawing.Point(134, 186);
            this.valasz3C.Name = "valasz3C";
            this.valasz3C.Size = new System.Drawing.Size(17, 16);
            this.valasz3C.TabIndex = 13;
            this.valasz3C.TabStop = true;
            this.valasz3C.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.valasz3C);
            this.Controls.Add(this.valasz2C);
            this.Controls.Add(this.valasz1C);
            this.Controls.Add(this.next);
            this.Controls.Add(this.ckeckAnsw);
            this.Controls.Add(this.valasz3);
            this.Controls.Add(this.valasz2);
            this.Controls.Add(this.valasz1);
            this.Controls.Add(this.kerdes);
            this.Name = "Form1";
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kerdes;
        private System.Windows.Forms.Label valasz1;
        private System.Windows.Forms.Label valasz2;
        private System.Windows.Forms.Label valasz3;
        private System.Windows.Forms.Button ckeckAnsw;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.RadioButton valasz1C;
        private System.Windows.Forms.RadioButton valasz2C;
        private System.Windows.Forms.RadioButton valasz3C;
    }
}

