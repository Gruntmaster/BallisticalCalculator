namespace BallisticalCalculator
{
    partial class NewObjectForm
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
            textBoxNewObjectWindow = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            buttonNewObjectFormSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // textBoxNewObjectWindow
            // 
            textBoxNewObjectWindow.Location = new Point(166, 30);
            textBoxNewObjectWindow.Name = "textBoxNewObjectWindow";
            textBoxNewObjectWindow.Size = new Size(163, 23);
            textBoxNewObjectWindow.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(224, 59);
            numericUpDown1.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(105, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(224, 97);
            numericUpDown2.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(105, 23);
            numericUpDown2.TabIndex = 2;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(224, 135);
            numericUpDown3.Maximum = new decimal(new int[] { -1530494977, 232830, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(105, 23);
            numericUpDown3.TabIndex = 3;
            // 
            // buttonNewObjectFormSave
            // 
            buttonNewObjectFormSave.Location = new Point(154, 175);
            buttonNewObjectFormSave.Name = "buttonNewObjectFormSave";
            buttonNewObjectFormSave.Size = new Size(124, 45);
            buttonNewObjectFormSave.TabIndex = 4;
            buttonNewObjectFormSave.Text = "Save";
            buttonNewObjectFormSave.UseVisualStyleBackColor = true;
            buttonNewObjectFormSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 61);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 5;
            label1.Text = "Distance to Target";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 99);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 6;
            label2.Text = "Ballistic Coefficient";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 137);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 7;
            label3.Text = "Muzzle Velocity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 33);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 8;
            label4.Text = "Name";
            // 
            // NewObjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 232);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonNewObjectFormSave);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBoxNewObjectWindow);
            Name = "NewObjectForm";
            Text = "NewObjectForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNewObjectWindow;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Button buttonNewObjectFormSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}