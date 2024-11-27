namespace Rev
{
    partial class NouveauMoto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textAnnee = new TextBox();
            textImm = new TextBox();
            textCylindre = new TextBox();
            textVitesse = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 30);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Annee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 76);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 0;
            label2.Text = "Immatriculation";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 118);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 0;
            label3.Text = "Cylindre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 160);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 0;
            label4.Text = "Vitesse Max";
            // 
            // textAnnee
            // 
            textAnnee.Location = new Point(155, 22);
            textAnnee.Name = "textAnnee";
            textAnnee.Size = new Size(204, 23);
            textAnnee.TabIndex = 1;
            textAnnee.TextChanged += textBox1_TextChanged;
            // 
            // textImm
            // 
            textImm.Location = new Point(155, 68);
            textImm.Name = "textImm";
            textImm.Size = new Size(204, 23);
            textImm.TabIndex = 1;
            textImm.TextChanged += textBox2_TextChanged;
            // 
            // textCylindre
            // 
            textCylindre.Location = new Point(155, 109);
            textCylindre.Name = "textCylindre";
            textCylindre.Size = new Size(204, 23);
            textCylindre.TabIndex = 1;
            // 
            // textVitesse
            // 
            textVitesse.Location = new Point(155, 154);
            textVitesse.Name = "textVitesse";
            textVitesse.Size = new Size(204, 23);
            textVitesse.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(337, 233);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NouveauMoto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 282);
            Controls.Add(button1);
            Controls.Add(textVitesse);
            Controls.Add(textCylindre);
            Controls.Add(textImm);
            Controls.Add(textAnnee);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NouveauMoto";
            Text = "NouveauMoto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textAnnee;
        private TextBox textImm;
        private TextBox textCylindre;
        private TextBox textVitesse;
        private Button button1;
    }
}