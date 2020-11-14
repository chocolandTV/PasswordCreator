
namespace PasswortErsteller
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
            this.button1 = new System.Windows.Forms.Button();
            this.Passwortlaenge = new System.Windows.Forms.TrackBar();
            this.trackBarText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Passwortlaenge)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(363, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generieren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Passwortlaenge
            // 
            this.Passwortlaenge.LargeChange = 1;
            this.Passwortlaenge.Location = new System.Drawing.Point(204, 97);
            this.Passwortlaenge.Maximum = 4;
            this.Passwortlaenge.Name = "Passwortlaenge";
            this.Passwortlaenge.Size = new System.Drawing.Size(143, 45);
            this.Passwortlaenge.TabIndex = 1;
            this.Passwortlaenge.Scroll += new System.EventHandler(this.Passwortlaenge_Scroll);
            // 
            // trackBarText
            // 
            this.trackBarText.AutoSize = true;
            this.trackBarText.Location = new System.Drawing.Point(249, 129);
            this.trackBarText.Name = "trackBarText";
            this.trackBarText.Size = new System.Drawing.Size(13, 13);
            this.trackBarText.TabIndex = 2;
            this.trackBarText.Text = "6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zeichen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 60);
            this.label3.TabIndex = 4;
            this.label3.Text = "Passwort Manager";
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(154, 172);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(250, 20);
            this.passwordField.TabIndex = 6;
            this.passwordField.Text = "ein sicheres Passwort.";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Image = global::PasswortErsteller.Properties.Resources.copy_512;
            this.button2.Location = new System.Drawing.Point(423, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 41);
            this.button2.TabIndex = 7;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 267);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarText);
            this.Controls.Add(this.Passwortlaenge);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Passwortlaenge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar Passwortlaenge;
        private System.Windows.Forms.Label trackBarText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button button2;
    }
}

