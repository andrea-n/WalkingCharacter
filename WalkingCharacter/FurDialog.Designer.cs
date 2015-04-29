namespace WalkingCharacter
{
    partial class FurDialog
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
            this.groupAddFur = new System.Windows.Forms.GroupBox();
            this.labelName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupParametersFur = new System.Windows.Forms.GroupBox();
            this.buttonTipColor = new System.Windows.Forms.Button();
            this.buttonRootColor = new System.Windows.Forms.Button();
            this.labelTipColor = new System.Windows.Forms.Label();
            this.labelRootColor = new System.Windows.Forms.Label();
            this.numericSteps = new System.Windows.Forms.NumericUpDown();
            this.labelSteps = new System.Windows.Forms.Label();
            this.numericCutLength = new System.Windows.Forms.NumericUpDown();
            this.labelCutLength = new System.Windows.Forms.Label();
            this.groupAddFur.SuspendLayout();
            this.groupParametersFur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCutLength)).BeginInit();
            this.SuspendLayout();
            // 
            // groupAddFur
            // 
            this.groupAddFur.Controls.Add(this.labelName);
            this.groupAddFur.Controls.Add(this.button1);
            this.groupAddFur.Controls.Add(this.textBoxName);
            this.groupAddFur.Location = new System.Drawing.Point(12, 162);
            this.groupAddFur.Name = "groupAddFur";
            this.groupAddFur.Size = new System.Drawing.Size(232, 88);
            this.groupAddFur.TabIndex = 0;
            this.groupAddFur.TabStop = false;
            this.groupAddFur.Text = "Add to list";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(60, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(158, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Fur";
            // 
            // groupParametersFur
            // 
            this.groupParametersFur.Controls.Add(this.numericCutLength);
            this.groupParametersFur.Controls.Add(this.labelCutLength);
            this.groupParametersFur.Controls.Add(this.buttonTipColor);
            this.groupParametersFur.Controls.Add(this.buttonRootColor);
            this.groupParametersFur.Controls.Add(this.labelTipColor);
            this.groupParametersFur.Controls.Add(this.labelRootColor);
            this.groupParametersFur.Controls.Add(this.numericSteps);
            this.groupParametersFur.Controls.Add(this.labelSteps);
            this.groupParametersFur.Location = new System.Drawing.Point(12, 12);
            this.groupParametersFur.Name = "groupParametersFur";
            this.groupParametersFur.Size = new System.Drawing.Size(232, 144);
            this.groupParametersFur.TabIndex = 1;
            this.groupParametersFur.TabStop = false;
            this.groupParametersFur.Text = "Parameters";
            // 
            // buttonTipColor
            // 
            this.buttonTipColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(12)))), ((int)(((byte)(0)))));
            this.buttonTipColor.Location = new System.Drawing.Point(98, 68);
            this.buttonTipColor.Name = "buttonTipColor";
            this.buttonTipColor.Size = new System.Drawing.Size(100, 18);
            this.buttonTipColor.TabIndex = 5;
            this.buttonTipColor.UseVisualStyleBackColor = false;
            // 
            // buttonRootColor
            // 
            this.buttonRootColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(18)))), ((int)(((byte)(3)))));
            this.buttonRootColor.Location = new System.Drawing.Point(98, 47);
            this.buttonRootColor.Name = "buttonRootColor";
            this.buttonRootColor.Size = new System.Drawing.Size(100, 18);
            this.buttonRootColor.TabIndex = 4;
            this.buttonRootColor.UseVisualStyleBackColor = false;
            // 
            // labelTipColor
            // 
            this.labelTipColor.AutoSize = true;
            this.labelTipColor.Location = new System.Drawing.Point(19, 70);
            this.labelTipColor.Name = "labelTipColor";
            this.labelTipColor.Size = new System.Drawing.Size(51, 13);
            this.labelTipColor.TabIndex = 3;
            this.labelTipColor.Text = "Tip color:";
            // 
            // labelRootColor
            // 
            this.labelRootColor.AutoSize = true;
            this.labelRootColor.Location = new System.Drawing.Point(19, 48);
            this.labelRootColor.Name = "labelRootColor";
            this.labelRootColor.Size = new System.Drawing.Size(59, 13);
            this.labelRootColor.TabIndex = 2;
            this.labelRootColor.Text = "Root color:";
            // 
            // numericSteps
            // 
            this.numericSteps.Location = new System.Drawing.Point(98, 24);
            this.numericSteps.Name = "numericSteps";
            this.numericSteps.Size = new System.Drawing.Size(100, 20);
            this.numericSteps.TabIndex = 1;
            this.numericSteps.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(19, 26);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(37, 13);
            this.labelSteps.TabIndex = 0;
            this.labelSteps.Text = "Steps:";
            // 
            // numericCutLength
            // 
            this.numericCutLength.Location = new System.Drawing.Point(98, 92);
            this.numericCutLength.Name = "numericCutLength";
            this.numericCutLength.Size = new System.Drawing.Size(100, 20);
            this.numericCutLength.TabIndex = 7;
            this.numericCutLength.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelCutLength
            // 
            this.labelCutLength.AutoSize = true;
            this.labelCutLength.Location = new System.Drawing.Point(19, 92);
            this.labelCutLength.Name = "labelCutLength";
            this.labelCutLength.Size = new System.Drawing.Size(58, 13);
            this.labelCutLength.TabIndex = 6;
            this.labelCutLength.Text = "Cut length:";
            // 
            // FurDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 262);
            this.Controls.Add(this.groupParametersFur);
            this.Controls.Add(this.groupAddFur);
            this.Name = "FurDialog";
            this.Text = "FurDialog";
            this.groupAddFur.ResumeLayout(false);
            this.groupAddFur.PerformLayout();
            this.groupParametersFur.ResumeLayout(false);
            this.groupParametersFur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCutLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAddFur;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupParametersFur;
        private System.Windows.Forms.Button buttonTipColor;
        private System.Windows.Forms.Button buttonRootColor;
        private System.Windows.Forms.Label labelTipColor;
        private System.Windows.Forms.Label labelRootColor;
        private System.Windows.Forms.NumericUpDown numericSteps;
        private System.Windows.Forms.Label labelSteps;
        private System.Windows.Forms.NumericUpDown numericCutLength;
        private System.Windows.Forms.Label labelCutLength;
    }
}