namespace Rev
{
    partial class MonGarage
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            radioVoiture = new RadioButton();
            radioMoto = new RadioButton();
            listBox1 = new ListBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            Ajouter = new Button();
            button1 = new Button();
            button2 = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.LightCoral;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(380, 0);
            label1.Name = "label1";
            label1.Size = new Size(423, 52);
            label1.TabIndex = 2;
            label1.Text = "Mon Garage";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(404, 134);
            label2.Name = "label2";
            label2.Size = new Size(159, 30);
            label2.TabIndex = 1;
            label2.Text = "Immatriculation";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(404, 207);
            label3.Name = "label3";
            label3.Size = new Size(73, 30);
            label3.TabIndex = 1;
            label3.Text = "Annee";
            label3.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(404, 283);
            label4.Name = "label4";
            label4.Size = new Size(56, 30);
            label4.TabIndex = 1;
            label4.Text = "Type";
            label4.Click += label2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Controls.Add(radioVoiture);
            flowLayoutPanel1.Controls.Add(radioMoto);
            flowLayoutPanel1.Location = new Point(2, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(372, 49);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // radioVoiture
            // 
            radioVoiture.Anchor = AnchorStyles.Top;
            radioVoiture.ForeColor = SystemColors.ButtonHighlight;
            radioVoiture.Location = new Point(3, 3);
            radioVoiture.Name = "radioVoiture";
            radioVoiture.Size = new Size(104, 24);
            radioVoiture.TabIndex = 3;
            radioVoiture.TabStop = true;
            radioVoiture.Text = "Voiture";
            radioVoiture.UseVisualStyleBackColor = true;
            radioVoiture.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioMoto
            // 
            radioMoto.AutoSize = true;
            radioMoto.ForeColor = SystemColors.ButtonHighlight;
            radioMoto.Location = new Point(113, 3);
            radioMoto.Name = "radioMoto";
            radioMoto.Size = new Size(54, 19);
            radioMoto.TabIndex = 4;
            radioMoto.TabStop = true;
            radioMoto.Text = "Moto";
            radioMoto.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(2, 54);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(372, 334);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel2.Controls.Add(Ajouter);
            flowLayoutPanel2.Controls.Add(button1);
            flowLayoutPanel2.Location = new Point(5, 394);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(372, 49);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // Ajouter
            // 
            Ajouter.Location = new Point(3, 3);
            Ajouter.Name = "Ajouter";
            Ajouter.Size = new Size(86, 29);
            Ajouter.TabIndex = 0;
            Ajouter.Text = "Ajouter";
            Ajouter.UseVisualStyleBackColor = true;
            Ajouter.Click += Ajouter_Click;
            // 
            // button1
            // 
            button1.Location = new Point(95, 3);
            button1.Name = "button1";
            button1.Size = new Size(86, 29);
            button1.TabIndex = 1;
            button1.Text = "Supprimer";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(696, 406);
            button2.Name = "button2";
            button2.Size = new Size(86, 29);
            button2.TabIndex = 2;
            button2.Text = "Détails";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MonGarage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MonGarage";
            Text = "MonGarage";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton radioVoiture;
        private RadioButton radioMoto;
        private ListBox listBox1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button Ajouter;
        private Button button1;
        private Button button2;
    }
}