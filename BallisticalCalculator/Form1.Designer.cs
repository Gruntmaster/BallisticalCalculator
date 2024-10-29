namespace BallisticalCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            outputTextBox = new TextBox();
            groupBox3 = new GroupBox();
            listBox = new ListBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            buttonCalculateResult = new Button();
            buttonEditObject = new Button();
            buttonRefresh = new Button();
            buttonCreateNew = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(outputTextBox);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            groupBox2.Location = new Point(266, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 450);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Wyniki";
            // 
            // outputTextBox
            // 
            outputTextBox.Dock = DockStyle.Fill;
            outputTextBox.Location = new Point(3, 19);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ScrollBars = ScrollBars.Vertical;
            outputTextBox.Size = new Size(328, 428);
            outputTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listBox);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            groupBox3.Location = new Point(600, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 450);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dodane objekty";
            // 
            // listBox
            // 
            listBox.Dock = DockStyle.Fill;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(3, 19);
            listBox.Name = "listBox";
            listBox.ScrollAlwaysVisible = true;
            listBox.Size = new Size(194, 428);
            listBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDown3);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(buttonCalculateResult);
            groupBox1.Controls.Add(buttonEditObject);
            groupBox1.Controls.Add(buttonRefresh);
            groupBox1.Controls.Add(buttonCreateNew);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 450);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opcje";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 358);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 9;
            label3.Text = "Distance to Target";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 329);
            label2.Name = "label2";
            label2.Size = new Size(161, 15);
            label2.TabIndex = 8;
            label2.Text = "Ballistic Coefficient:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 300);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 7;
            label1.Text = "Muzzle Velocity:";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(178, 298);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(82, 23);
            numericUpDown3.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(178, 327);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(82, 23);
            numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(178, 356);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(82, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // buttonCalculateResult
            // 
            buttonCalculateResult.Location = new Point(29, 396);
            buttonCalculateResult.Name = "buttonCalculateResult";
            buttonCalculateResult.Size = new Size(148, 33);
            buttonCalculateResult.TabIndex = 3;
            buttonCalculateResult.Text = "Calculate";
            buttonCalculateResult.UseVisualStyleBackColor = true;
            // 
            // buttonEditObject
            // 
            buttonEditObject.Location = new Point(29, 150);
            buttonEditObject.Name = "buttonEditObject";
            buttonEditObject.Size = new Size(148, 33);
            buttonEditObject.TabIndex = 2;
            buttonEditObject.Text = "Edit";
            buttonEditObject.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(29, 91);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(148, 33);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonCreateNew
            // 
            buttonCreateNew.Location = new Point(29, 32);
            buttonCreateNew.Name = "buttonCreateNew";
            buttonCreateNew.Size = new Size(148, 33);
            buttonCreateNew.TabIndex = 0;
            buttonCreateNew.Text = "Create new Object";
            buttonCreateNew.UseVisualStyleBackColor = true;
            buttonCreateNew.Click += buttonCreateNew_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox outputTextBox;
        private GroupBox groupBox3;
        private ListBox listBox;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Button buttonCalculateResult;
        private Button buttonEditObject;
        private Button buttonRefresh;
        private Button buttonCreateNew;
    }
}
