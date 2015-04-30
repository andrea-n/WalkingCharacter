namespace WalkingCharacter
{
    partial class UtilityForm
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
            this.groupMerge = new System.Windows.Forms.GroupBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.groupAnimation = new System.Windows.Forms.GroupBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.groupAnimationAdd = new System.Windows.Forms.GroupBox();
            this.buttonAddFur = new System.Windows.Forms.Button();
            this.listBoxAnimation = new System.Windows.Forms.ListBox();
            this.groupBoxEditAnimation = new System.Windows.Forms.GroupBox();
            this.groupMerge.SuspendLayout();
            this.groupAnimation.SuspendLayout();
            this.groupAnimationAdd.SuspendLayout();
            this.groupBoxEditAnimation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMerge
            // 
            this.groupMerge.Controls.Add(this.buttonCreate);
            this.groupMerge.Location = new System.Drawing.Point(12, 12);
            this.groupMerge.Name = "groupMerge";
            this.groupMerge.Size = new System.Drawing.Size(230, 62);
            this.groupMerge.TabIndex = 0;
            this.groupMerge.TabStop = false;
            this.groupMerge.Text = "Merge character to the scene";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(65, 22);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // groupAnimation
            // 
            this.groupAnimation.AutoSize = true;
            this.groupAnimation.Controls.Add(this.groupBoxEditAnimation);
            this.groupAnimation.Controls.Add(this.groupAnimationAdd);
            this.groupAnimation.Controls.Add(this.listBoxAnimation);
            this.groupAnimation.Location = new System.Drawing.Point(12, 80);
            this.groupAnimation.Name = "groupAnimation";
            this.groupAnimation.Size = new System.Drawing.Size(461, 247);
            this.groupAnimation.TabIndex = 1;
            this.groupAnimation.TabStop = false;
            this.groupAnimation.Text = "Animation";
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(17, 28);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 23);
            this.buttonUp.TabIndex = 3;
            this.buttonUp.Text = "Move up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(17, 57);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(75, 23);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.Text = "Move down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(98, 28);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // groupAnimationAdd
            // 
            this.groupAnimationAdd.Controls.Add(this.buttonAddFur);
            this.groupAnimationAdd.Location = new System.Drawing.Point(246, 29);
            this.groupAnimationAdd.Name = "groupAnimationAdd";
            this.groupAnimationAdd.Size = new System.Drawing.Size(195, 96);
            this.groupAnimationAdd.TabIndex = 1;
            this.groupAnimationAdd.TabStop = false;
            this.groupAnimationAdd.Text = "Add new";
            // 
            // buttonAddFur
            // 
            this.buttonAddFur.Location = new System.Drawing.Point(17, 28);
            this.buttonAddFur.Name = "buttonAddFur";
            this.buttonAddFur.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFur.TabIndex = 2;
            this.buttonAddFur.Text = "AddFur";
            this.buttonAddFur.UseVisualStyleBackColor = true;
            this.buttonAddFur.Click += new System.EventHandler(this.buttonAddFur_Click);
            // 
            // listBoxAnimation
            // 
            this.listBoxAnimation.FormattingEnabled = true;
            this.listBoxAnimation.Location = new System.Drawing.Point(15, 29);
            this.listBoxAnimation.Name = "listBoxAnimation";
            this.listBoxAnimation.Size = new System.Drawing.Size(215, 199);
            this.listBoxAnimation.TabIndex = 0;
            this.listBoxAnimation.SelectedIndexChanged += new System.EventHandler(this.listBoxAnimation_SelectedIndexChanged);
            // 
            // groupBoxEditAnimation
            // 
            this.groupBoxEditAnimation.Controls.Add(this.buttonRemove);
            this.groupBoxEditAnimation.Controls.Add(this.buttonDown);
            this.groupBoxEditAnimation.Controls.Add(this.buttonUp);
            this.groupBoxEditAnimation.Enabled = false;
            this.groupBoxEditAnimation.Location = new System.Drawing.Point(246, 128);
            this.groupBoxEditAnimation.Name = "groupBoxEditAnimation";
            this.groupBoxEditAnimation.Size = new System.Drawing.Size(195, 98);
            this.groupBoxEditAnimation.TabIndex = 6;
            this.groupBoxEditAnimation.TabStop = false;
            // 
            // UtilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 337);
            this.Controls.Add(this.groupAnimation);
            this.Controls.Add(this.groupMerge);
            this.Name = "UtilityForm";
            this.Text = "Walking character";
            this.Load += new System.EventHandler(this.UtilityForm_Load);
            this.groupMerge.ResumeLayout(false);
            this.groupAnimation.ResumeLayout(false);
            this.groupAnimationAdd.ResumeLayout(false);
            this.groupBoxEditAnimation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMerge;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.GroupBox groupAnimation;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.GroupBox groupAnimationAdd;
        private System.Windows.Forms.Button buttonAddFur;
        private System.Windows.Forms.ListBox listBoxAnimation;
        private System.Windows.Forms.GroupBox groupBoxEditAnimation;
    }
}