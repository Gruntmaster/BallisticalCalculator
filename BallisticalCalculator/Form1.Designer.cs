﻿namespace BallisticalCalculator
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox2 = new GroupBox();
            outputTextBox = new TextBox();
            groupBox3 = new GroupBox();
            listBox = new ListBox();
            groupBox1 = new GroupBox();
            buttonDelete = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericMuzzleVelocity = new NumericUpDown();
            numericBallisticCoefficient = new NumericUpDown();
            numericDistanceToTarget = new NumericUpDown();
            buttonCalculateResult = new Button();
            buttonEditObject = new Button();
            buttonRefresh = new Button();
            buttonCreateNew = new Button();
            bulletAnimator = new PictureBox();
            bulletTimer = new System.Windows.Forms.Timer(components);
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericMuzzleVelocity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBallisticCoefficient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDistanceToTarget).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bulletAnimator).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(outputTextBox);
            groupBox2.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            groupBox2.Location = new Point(708, 300);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(263, 150);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Results";
            // 
            // outputTextBox
            // 
            outputTextBox.Dock = DockStyle.Fill;
            outputTextBox.Location = new Point(3, 19);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ScrollBars = ScrollBars.Vertical;
            outputTextBox.Size = new Size(257, 128);
            outputTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listBox);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            groupBox3.Location = new Point(708, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(266, 450);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Added objects";
            // 
            // listBox
            // 
            listBox.Dock = DockStyle.Fill;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(3, 19);
            listBox.Name = "listBox";
            listBox.ScrollAlwaysVisible = true;
            listBox.Size = new Size(260, 428);
            listBox.TabIndex = 0;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericMuzzleVelocity);
            groupBox1.Controls.Add(numericBallisticCoefficient);
            groupBox1.Controls.Add(numericDistanceToTarget);
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
            groupBox1.Text = "Options";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(29, 209);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(148, 33);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Delete Object";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
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
            // numericMuzzleVelocity
            // 
            numericMuzzleVelocity.Location = new Point(178, 298);
            numericMuzzleVelocity.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            numericMuzzleVelocity.Name = "numericMuzzleVelocity";
            numericMuzzleVelocity.ReadOnly = true;
            numericMuzzleVelocity.Size = new Size(82, 23);
            numericMuzzleVelocity.TabIndex = 6;
            // 
            // numericBallisticCoefficient
            // 
            numericBallisticCoefficient.Location = new Point(178, 327);
            numericBallisticCoefficient.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            numericBallisticCoefficient.Name = "numericBallisticCoefficient";
            numericBallisticCoefficient.ReadOnly = true;
            numericBallisticCoefficient.Size = new Size(82, 23);
            numericBallisticCoefficient.TabIndex = 5;
            // 
            // numericDistanceToTarget
            // 
            numericDistanceToTarget.Location = new Point(178, 356);
            numericDistanceToTarget.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            numericDistanceToTarget.Name = "numericDistanceToTarget";
            numericDistanceToTarget.ReadOnly = true;
            numericDistanceToTarget.Size = new Size(82, 23);
            numericDistanceToTarget.TabIndex = 4;
            // 
            // buttonCalculateResult
            // 
            buttonCalculateResult.Location = new Point(29, 396);
            buttonCalculateResult.Name = "buttonCalculateResult";
            buttonCalculateResult.Size = new Size(148, 33);
            buttonCalculateResult.TabIndex = 3;
            buttonCalculateResult.Text = "Calculate";
            buttonCalculateResult.UseVisualStyleBackColor = true;
            buttonCalculateResult.Click += buttonCalculateResult_Click;
            // 
            // buttonEditObject
            // 
            buttonEditObject.Location = new Point(29, 150);
            buttonEditObject.Name = "buttonEditObject";
            buttonEditObject.Size = new Size(148, 33);
            buttonEditObject.TabIndex = 2;
            buttonEditObject.Text = "Edit";
            buttonEditObject.UseVisualStyleBackColor = true;
            buttonEditObject.Click += buttonEditObject_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(29, 91);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(148, 33);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
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
            // bulletAnimator
            // 
            bulletAnimator.Image = (Image)resources.GetObject("bulletAnimator.Image");
            bulletAnimator.Location = new Point(282, 209);
            bulletAnimator.Name = "bulletAnimator";
            bulletAnimator.Size = new Size(62, 25);
            bulletAnimator.SizeMode = PictureBoxSizeMode.Zoom;
            bulletAnimator.TabIndex = 1;
            bulletAnimator.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 450);
            Controls.Add(bulletAnimator);
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
            ((System.ComponentModel.ISupportInitialize)numericMuzzleVelocity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBallisticCoefficient).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDistanceToTarget).EndInit();
            ((System.ComponentModel.ISupportInitialize)bulletAnimator).EndInit();
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
        private NumericUpDown numericMuzzleVelocity;
        private NumericUpDown numericBallisticCoefficient;
        private NumericUpDown numericDistanceToTarget;
        private Button buttonCalculateResult;
        private Button buttonEditObject;
        private Button buttonRefresh;
        private Button buttonCreateNew;
        private Button buttonDelete;
        private PictureBox bulletAnimator;
        private System.Windows.Forms.Timer bulletTimer;
    }
}
