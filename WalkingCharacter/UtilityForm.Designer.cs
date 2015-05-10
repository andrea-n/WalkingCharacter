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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.groupAnimation = new System.Windows.Forms.GroupBox();
            this.groupBoxEditAnimation = new System.Windows.Forms.GroupBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.groupAnimationAdd = new System.Windows.Forms.GroupBox();
            this.buttonAddFur = new System.Windows.Forms.Button();
            this.listBoxAnimation = new System.Windows.Forms.ListBox();
            this.groupCreateAnimation = new System.Windows.Forms.GroupBox();
            this.buttonCreateKeys = new System.Windows.Forms.Button();
            this.groupMerge.SuspendLayout();
            this.groupAnimation.SuspendLayout();
            this.groupBoxEditAnimation.SuspendLayout();
            this.groupAnimationAdd.SuspendLayout();
            this.groupCreateAnimation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMerge
            // 
            this.groupMerge.Controls.Add(this.buttonLoad);
            this.groupMerge.Controls.Add(this.buttonSave);
            this.groupMerge.Controls.Add(this.buttonReset);
            this.groupMerge.Controls.Add(this.buttonCreate);
            this.groupMerge.Location = new System.Drawing.Point(12, 12);
            this.groupMerge.Name = "groupMerge";
            this.groupMerge.Size = new System.Drawing.Size(461, 62);
            this.groupMerge.TabIndex = 0;
            this.groupMerge.TabStop = false;
            this.groupMerge.Text = "Merge character to the scene";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(344, 22);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(246, 22);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(155, 22);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
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
            // groupBoxEditAnimation
            // 
            this.groupBoxEditAnimation.Controls.Add(this.buttonEdit);
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
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(98, 28);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(98, 57);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
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
            this.buttonAddFur.Text = "Add fur";
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
            // groupCreateAnimation
            // 
            this.groupCreateAnimation.Controls.Add(this.buttonCreateKeys);
            this.groupCreateAnimation.Location = new System.Drawing.Point(12, 333);
            this.groupCreateAnimation.Name = "groupCreateAnimation";
            this.groupCreateAnimation.Size = new System.Drawing.Size(461, 66);
            this.groupCreateAnimation.TabIndex = 2;
            this.groupCreateAnimation.TabStop = false;
            this.groupCreateAnimation.Text = "Create animation keys";
            // 
            // buttonCreateKeys
            // 
            this.buttonCreateKeys.Enabled = false;
            this.buttonCreateKeys.Location = new System.Drawing.Point(46, 24);
            this.buttonCreateKeys.Name = "buttonCreateKeys";
            this.buttonCreateKeys.Size = new System.Drawing.Size(114, 23);
            this.buttonCreateKeys.TabIndex = 0;
            this.buttonCreateKeys.Text = "Create animation";
            this.buttonCreateKeys.UseVisualStyleBackColor = true;
            this.buttonCreateKeys.Click += new System.EventHandler(this.buttonCreateKeys_Click);
            // 
            // UtilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 410);
            this.Controls.Add(this.groupCreateAnimation);
            this.Controls.Add(this.groupAnimation);
            this.Controls.Add(this.groupMerge);
            this.Name = "UtilityForm";
            this.Text = "Walking character";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UtilityForm_FormClosed);
            this.Load += new System.EventHandler(this.UtilityForm_Load);
            this.groupMerge.ResumeLayout(false);
            this.groupAnimation.ResumeLayout(false);
            this.groupBoxEditAnimation.ResumeLayout(false);
            this.groupAnimationAdd.ResumeLayout(false);
            this.groupCreateAnimation.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.GroupBox groupCreateAnimation;
        private System.Windows.Forms.Button buttonCreateKeys;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
    }
}