namespace RotinaSeniorCSharp
{
    partial class Form2
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
            txt_tempo = new TextBox();
            txt_materia = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 20);
            label1.TabIndex = 0;
            label1.Text = "Quantas horas você quer estudar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(220, 20);
            label2.TabIndex = 1;
            label2.Text = "Qual materia você quer estudar:";
            // 
            // txt_tempo
            // 
            txt_tempo.Location = new Point(12, 32);
            txt_tempo.Name = "txt_tempo";
            txt_tempo.Size = new Size(125, 27);
            txt_tempo.TabIndex = 2;
            // 
            // txt_materia
            // 
            txt_materia.Location = new Point(12, 85);
            txt_materia.Name = "txt_materia";
            txt_materia.Size = new Size(125, 27);
            txt_materia.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(138, 277);
            button1.Name = "button1";
            button1.Size = new Size(102, 40);
            button1.TabIndex = 4;
            button1.Text = "Marcar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 329);
            Controls.Add(button1);
            Controls.Add(txt_materia);
            Controls.Add(txt_tempo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_tempo;
        private TextBox txt_materia;
        private Button button1;
    }
}