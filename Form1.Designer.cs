
namespace programa
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
            this.TextBoxMasyvas = new System.Windows.Forms.TextBox();
            this.Button_Vykdyti = new System.Windows.Forms.Button();
            this.LabelSkaiciai = new System.Windows.Forms.Label();
            this.Ivestis = new System.Windows.Forms.TextBox();
            this.ButtonPiesti = new System.Windows.Forms.Button();
            this.eglute = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TextBoxMasyvas
            // 
            this.TextBoxMasyvas.Location = new System.Drawing.Point(26, 26);
            this.TextBoxMasyvas.Name = "TextBoxMasyvas";
            this.TextBoxMasyvas.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMasyvas.TabIndex = 0;
            // 
            // Button_Vykdyti
            // 
            this.Button_Vykdyti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_Vykdyti.Location = new System.Drawing.Point(38, 62);
            this.Button_Vykdyti.Name = "Button_Vykdyti";
            this.Button_Vykdyti.Size = new System.Drawing.Size(75, 23);
            this.Button_Vykdyti.TabIndex = 1;
            this.Button_Vykdyti.Text = "Skaičiuoti";
            this.Button_Vykdyti.UseVisualStyleBackColor = true;
            this.Button_Vykdyti.Click += new System.EventHandler(this.Button_Vykdyti_Click);
            // 
            // LabelSkaiciai
            // 
            this.LabelSkaiciai.AutoSize = true;
            this.LabelSkaiciai.Location = new System.Drawing.Point(23, 103);
            this.LabelSkaiciai.Name = "LabelSkaiciai";
            this.LabelSkaiciai.Size = new System.Drawing.Size(0, 13);
            this.LabelSkaiciai.TabIndex = 2;
            // 
            // Ivestis
            // 
            this.Ivestis.Location = new System.Drawing.Point(187, 26);
            this.Ivestis.Name = "Ivestis";
            this.Ivestis.Size = new System.Drawing.Size(100, 20);
            this.Ivestis.TabIndex = 3;
            // 
            // ButtonPiesti
            // 
            this.ButtonPiesti.Location = new System.Drawing.Point(200, 62);
            this.ButtonPiesti.Name = "ButtonPiesti";
            this.ButtonPiesti.Size = new System.Drawing.Size(75, 23);
            this.ButtonPiesti.TabIndex = 4;
            this.ButtonPiesti.Text = "Nupiešti";
            this.ButtonPiesti.UseVisualStyleBackColor = true;
            this.ButtonPiesti.Click += new System.EventHandler(this.ButtonPiesti_Click);
            // 
            // eglute
            // 
            this.eglute.Location = new System.Drawing.Point(187, 103);
            this.eglute.Name = "eglute";
            this.eglute.Size = new System.Drawing.Size(100, 96);
            this.eglute.TabIndex = 5;
            this.eglute.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 410);
            this.Controls.Add(this.eglute);
            this.Controls.Add(this.ButtonPiesti);
            this.Controls.Add(this.Ivestis);
            this.Controls.Add(this.LabelSkaiciai);
            this.Controls.Add(this.Button_Vykdyti);
            this.Controls.Add(this.TextBoxMasyvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxMasyvas;
        private System.Windows.Forms.Button Button_Vykdyti;
        private System.Windows.Forms.Label LabelSkaiciai;
        private System.Windows.Forms.TextBox Ivestis;
        private System.Windows.Forms.Button ButtonPiesti;
        private System.Windows.Forms.RichTextBox eglute;
    }
}

