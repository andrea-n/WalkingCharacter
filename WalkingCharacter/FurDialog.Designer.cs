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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupParametersFur = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarTransitionSpeed = new System.Windows.Forms.TrackBar();
            this.labelTransitionSpeed = new System.Windows.Forms.Label();
            this.numericRootThick = new System.Windows.Forms.NumericUpDown();
            this.labelRootThick = new System.Windows.Forms.Label();
            this.numericRandomScale = new System.Windows.Forms.NumericUpDown();
            this.labelRandomScale = new System.Windows.Forms.Label();
            this.numericSegments = new System.Windows.Forms.NumericUpDown();
            this.labelSegments = new System.Windows.Forms.Label();
            this.numericScale = new System.Windows.Forms.NumericUpDown();
            this.labelScale = new System.Windows.Forms.Label();
            this.numericSteps = new System.Windows.Forms.NumericUpDown();
            this.labelSteps = new System.Windows.Forms.Label();
            this.buttonTipColor = new System.Windows.Forms.Button();
            this.buttonRootColor = new System.Windows.Forms.Button();
            this.labelTipColor = new System.Windows.Forms.Label();
            this.labelRootColor = new System.Windows.Forms.Label();
            this.groupMaterial = new System.Windows.Forms.GroupBox();
            this.numericGlossiness = new System.Windows.Forms.NumericUpDown();
            this.buttonMutantColor = new System.Windows.Forms.Button();
            this.numericValueVariation = new System.Windows.Forms.NumericUpDown();
            this.labelMutantColor = new System.Windows.Forms.Label();
            this.labelGlossiness = new System.Windows.Forms.Label();
            this.numericSpecular = new System.Windows.Forms.NumericUpDown();
            this.labelValueVariation = new System.Windows.Forms.Label();
            this.labelHueVariation = new System.Windows.Forms.Label();
            this.labelSpecular = new System.Windows.Forms.Label();
            this.labelMutant = new System.Windows.Forms.Label();
            this.numericHueVariation = new System.Windows.Forms.NumericUpDown();
            this.numericMutant = new System.Windows.Forms.NumericUpDown();
            this.groupEffects = new System.Windows.Forms.GroupBox();
            this.numericKink = new System.Windows.Forms.NumericUpDown();
            this.numericFlyAway = new System.Windows.Forms.NumericUpDown();
            this.labelKink = new System.Windows.Forms.Label();
            this.labelFlyAway = new System.Windows.Forms.Label();
            this.numericClump = new System.Windows.Forms.NumericUpDown();
            this.labelClump = new System.Windows.Forms.Label();
            this.groupAddFur.SuspendLayout();
            this.groupParametersFur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransitionSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRootThick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRandomScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSegments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSteps)).BeginInit();
            this.groupMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGlossiness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValueVariation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpecular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHueVariation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMutant)).BeginInit();
            this.groupEffects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericKink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFlyAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericClump)).BeginInit();
            this.SuspendLayout();
            // 
            // groupAddFur
            // 
            this.groupAddFur.Controls.Add(this.buttonCancel);
            this.groupAddFur.Controls.Add(this.labelName);
            this.groupAddFur.Controls.Add(this.buttonAdd);
            this.groupAddFur.Controls.Add(this.textBoxName);
            this.groupAddFur.Location = new System.Drawing.Point(258, 256);
            this.groupAddFur.Name = "groupAddFur";
            this.groupAddFur.Size = new System.Drawing.Size(209, 88);
            this.groupAddFur.TabIndex = 0;
            this.groupAddFur.TabStop = false;
            this.groupAddFur.Text = "Add to animation";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(19, 49);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdd.Location = new System.Drawing.Point(119, 49);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(60, 23);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(134, 20);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Fur";
            // 
            // groupParametersFur
            // 
            this.groupParametersFur.Controls.Add(this.label2);
            this.groupParametersFur.Controls.Add(this.label1);
            this.groupParametersFur.Controls.Add(this.trackBarTransitionSpeed);
            this.groupParametersFur.Controls.Add(this.labelTransitionSpeed);
            this.groupParametersFur.Controls.Add(this.numericRootThick);
            this.groupParametersFur.Controls.Add(this.labelRootThick);
            this.groupParametersFur.Controls.Add(this.numericRandomScale);
            this.groupParametersFur.Controls.Add(this.labelRandomScale);
            this.groupParametersFur.Controls.Add(this.numericSegments);
            this.groupParametersFur.Controls.Add(this.labelSegments);
            this.groupParametersFur.Controls.Add(this.numericScale);
            this.groupParametersFur.Controls.Add(this.labelScale);
            this.groupParametersFur.Controls.Add(this.numericSteps);
            this.groupParametersFur.Controls.Add(this.labelSteps);
            this.groupParametersFur.Location = new System.Drawing.Point(12, 12);
            this.groupParametersFur.Name = "groupParametersFur";
            this.groupParametersFur.Size = new System.Drawing.Size(232, 214);
            this.groupParametersFur.TabIndex = 1;
            this.groupParametersFur.TabStop = false;
            this.groupParametersFur.Text = "Parameters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(192, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fast";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(119, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "Slow";
            // 
            // trackBarTransitionSpeed
            // 
            this.trackBarTransitionSpeed.Location = new System.Drawing.Point(114, 50);
            this.trackBarTransitionSpeed.Name = "trackBarTransitionSpeed";
            this.trackBarTransitionSpeed.Size = new System.Drawing.Size(112, 45);
            this.trackBarTransitionSpeed.TabIndex = 13;
            this.trackBarTransitionSpeed.Tag = "";
            // 
            // labelTransitionSpeed
            // 
            this.labelTransitionSpeed.AutoSize = true;
            this.labelTransitionSpeed.Location = new System.Drawing.Point(19, 53);
            this.labelTransitionSpeed.Name = "labelTransitionSpeed";
            this.labelTransitionSpeed.Size = new System.Drawing.Size(91, 13);
            this.labelTransitionSpeed.TabIndex = 12;
            this.labelTransitionSpeed.Text = "Transition to next:";
            // 
            // numericRootThick
            // 
            this.numericRootThick.Location = new System.Drawing.Point(122, 178);
            this.numericRootThick.Name = "numericRootThick";
            this.numericRootThick.Size = new System.Drawing.Size(96, 20);
            this.numericRootThick.TabIndex = 9;
            this.numericRootThick.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // labelRootThick
            // 
            this.labelRootThick.AutoSize = true;
            this.labelRootThick.Location = new System.Drawing.Point(19, 180);
            this.labelRootThick.Name = "labelRootThick";
            this.labelRootThick.Size = new System.Drawing.Size(81, 13);
            this.labelRootThick.TabIndex = 8;
            this.labelRootThick.Text = "Root thickness:";
            // 
            // numericRandomScale
            // 
            this.numericRandomScale.Location = new System.Drawing.Point(122, 152);
            this.numericRandomScale.Name = "numericRandomScale";
            this.numericRandomScale.Size = new System.Drawing.Size(96, 20);
            this.numericRandomScale.TabIndex = 11;
            this.numericRandomScale.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // labelRandomScale
            // 
            this.labelRandomScale.AutoSize = true;
            this.labelRandomScale.Location = new System.Drawing.Point(19, 154);
            this.labelRandomScale.Name = "labelRandomScale";
            this.labelRandomScale.Size = new System.Drawing.Size(78, 13);
            this.labelRandomScale.TabIndex = 10;
            this.labelRandomScale.Text = "Random scale:";
            // 
            // numericSegments
            // 
            this.numericSegments.Location = new System.Drawing.Point(122, 124);
            this.numericSegments.Name = "numericSegments";
            this.numericSegments.Size = new System.Drawing.Size(96, 20);
            this.numericSegments.TabIndex = 9;
            this.numericSegments.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelSegments
            // 
            this.labelSegments.AutoSize = true;
            this.labelSegments.Location = new System.Drawing.Point(19, 126);
            this.labelSegments.Name = "labelSegments";
            this.labelSegments.Size = new System.Drawing.Size(57, 13);
            this.labelSegments.TabIndex = 8;
            this.labelSegments.Text = "Segments:";
            // 
            // numericScale
            // 
            this.numericScale.Location = new System.Drawing.Point(122, 98);
            this.numericScale.Name = "numericScale";
            this.numericScale.Size = new System.Drawing.Size(96, 20);
            this.numericScale.TabIndex = 7;
            this.numericScale.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(19, 100);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(37, 13);
            this.labelScale.TabIndex = 6;
            this.labelScale.Text = "Scale:";
            // 
            // numericSteps
            // 
            this.numericSteps.Location = new System.Drawing.Point(122, 24);
            this.numericSteps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSteps.Name = "numericSteps";
            this.numericSteps.Size = new System.Drawing.Size(96, 20);
            this.numericSteps.TabIndex = 1;
            this.numericSteps.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(19, 29);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(84, 13);
            this.labelSteps.TabIndex = 0;
            this.labelSteps.Text = "Character steps:";
            // 
            // buttonTipColor
            // 
            this.buttonTipColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(12)))), ((int)(((byte)(0)))));
            this.buttonTipColor.Location = new System.Drawing.Point(107, 50);
            this.buttonTipColor.Name = "buttonTipColor";
            this.buttonTipColor.Size = new System.Drawing.Size(87, 18);
            this.buttonTipColor.TabIndex = 5;
            this.buttonTipColor.UseVisualStyleBackColor = false;
            this.buttonTipColor.Click += new System.EventHandler(this.buttonTipColor_Click);
            // 
            // buttonRootColor
            // 
            this.buttonRootColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(18)))), ((int)(((byte)(3)))));
            this.buttonRootColor.Location = new System.Drawing.Point(107, 26);
            this.buttonRootColor.Name = "buttonRootColor";
            this.buttonRootColor.Size = new System.Drawing.Size(87, 18);
            this.buttonRootColor.TabIndex = 4;
            this.buttonRootColor.UseVisualStyleBackColor = false;
            this.buttonRootColor.Click += new System.EventHandler(this.buttonRootColor_Click);
            // 
            // labelTipColor
            // 
            this.labelTipColor.AutoSize = true;
            this.labelTipColor.Location = new System.Drawing.Point(15, 53);
            this.labelTipColor.Name = "labelTipColor";
            this.labelTipColor.Size = new System.Drawing.Size(51, 13);
            this.labelTipColor.TabIndex = 3;
            this.labelTipColor.Text = "Tip color:";
            // 
            // labelRootColor
            // 
            this.labelRootColor.AutoSize = true;
            this.labelRootColor.Location = new System.Drawing.Point(16, 29);
            this.labelRootColor.Name = "labelRootColor";
            this.labelRootColor.Size = new System.Drawing.Size(59, 13);
            this.labelRootColor.TabIndex = 2;
            this.labelRootColor.Text = "Root color:";
            // 
            // groupMaterial
            // 
            this.groupMaterial.Controls.Add(this.numericGlossiness);
            this.groupMaterial.Controls.Add(this.buttonMutantColor);
            this.groupMaterial.Controls.Add(this.numericValueVariation);
            this.groupMaterial.Controls.Add(this.labelMutantColor);
            this.groupMaterial.Controls.Add(this.labelGlossiness);
            this.groupMaterial.Controls.Add(this.buttonRootColor);
            this.groupMaterial.Controls.Add(this.labelRootColor);
            this.groupMaterial.Controls.Add(this.numericSpecular);
            this.groupMaterial.Controls.Add(this.buttonTipColor);
            this.groupMaterial.Controls.Add(this.labelValueVariation);
            this.groupMaterial.Controls.Add(this.labelTipColor);
            this.groupMaterial.Controls.Add(this.labelHueVariation);
            this.groupMaterial.Controls.Add(this.labelSpecular);
            this.groupMaterial.Controls.Add(this.labelMutant);
            this.groupMaterial.Controls.Add(this.numericHueVariation);
            this.groupMaterial.Controls.Add(this.numericMutant);
            this.groupMaterial.Location = new System.Drawing.Point(258, 12);
            this.groupMaterial.Name = "groupMaterial";
            this.groupMaterial.Size = new System.Drawing.Size(209, 236);
            this.groupMaterial.TabIndex = 8;
            this.groupMaterial.TabStop = false;
            this.groupMaterial.Text = "Material";
            // 
            // numericGlossiness
            // 
            this.numericGlossiness.Location = new System.Drawing.Point(107, 202);
            this.numericGlossiness.Name = "numericGlossiness";
            this.numericGlossiness.Size = new System.Drawing.Size(87, 20);
            this.numericGlossiness.TabIndex = 17;
            this.numericGlossiness.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            // 
            // buttonMutantColor
            // 
            this.buttonMutantColor.BackColor = System.Drawing.Color.White;
            this.buttonMutantColor.Location = new System.Drawing.Point(107, 74);
            this.buttonMutantColor.Name = "buttonMutantColor";
            this.buttonMutantColor.Size = new System.Drawing.Size(87, 18);
            this.buttonMutantColor.TabIndex = 7;
            this.buttonMutantColor.UseVisualStyleBackColor = false;
            this.buttonMutantColor.Click += new System.EventHandler(this.buttonMutantColor_Click);
            // 
            // numericValueVariation
            // 
            this.numericValueVariation.Location = new System.Drawing.Point(107, 124);
            this.numericValueVariation.Name = "numericValueVariation";
            this.numericValueVariation.Size = new System.Drawing.Size(87, 20);
            this.numericValueVariation.TabIndex = 21;
            this.numericValueVariation.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // labelMutantColor
            // 
            this.labelMutantColor.AutoSize = true;
            this.labelMutantColor.Location = new System.Drawing.Point(15, 77);
            this.labelMutantColor.Name = "labelMutantColor";
            this.labelMutantColor.Size = new System.Drawing.Size(69, 13);
            this.labelMutantColor.TabIndex = 6;
            this.labelMutantColor.Text = "Mutant color:";
            // 
            // labelGlossiness
            // 
            this.labelGlossiness.AutoSize = true;
            this.labelGlossiness.Location = new System.Drawing.Point(16, 204);
            this.labelGlossiness.Name = "labelGlossiness";
            this.labelGlossiness.Size = new System.Drawing.Size(60, 13);
            this.labelGlossiness.TabIndex = 16;
            this.labelGlossiness.Text = "Glossiness:";
            // 
            // numericSpecular
            // 
            this.numericSpecular.Location = new System.Drawing.Point(107, 176);
            this.numericSpecular.Name = "numericSpecular";
            this.numericSpecular.Size = new System.Drawing.Size(87, 20);
            this.numericSpecular.TabIndex = 15;
            this.numericSpecular.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // labelValueVariation
            // 
            this.labelValueVariation.AutoSize = true;
            this.labelValueVariation.Location = new System.Drawing.Point(16, 126);
            this.labelValueVariation.Name = "labelValueVariation";
            this.labelValueVariation.Size = new System.Drawing.Size(80, 13);
            this.labelValueVariation.TabIndex = 20;
            this.labelValueVariation.Text = "Value variation:";
            // 
            // labelHueVariation
            // 
            this.labelHueVariation.AutoSize = true;
            this.labelHueVariation.Location = new System.Drawing.Point(15, 100);
            this.labelHueVariation.Name = "labelHueVariation";
            this.labelHueVariation.Size = new System.Drawing.Size(70, 13);
            this.labelHueVariation.TabIndex = 18;
            this.labelHueVariation.Text = "Hue variation";
            // 
            // labelSpecular
            // 
            this.labelSpecular.AutoSize = true;
            this.labelSpecular.Location = new System.Drawing.Point(16, 178);
            this.labelSpecular.Name = "labelSpecular";
            this.labelSpecular.Size = new System.Drawing.Size(52, 13);
            this.labelSpecular.TabIndex = 14;
            this.labelSpecular.Text = "Specular:";
            // 
            // labelMutant
            // 
            this.labelMutant.AutoSize = true;
            this.labelMutant.Location = new System.Drawing.Point(15, 152);
            this.labelMutant.Name = "labelMutant";
            this.labelMutant.Size = new System.Drawing.Size(43, 13);
            this.labelMutant.TabIndex = 12;
            this.labelMutant.Text = "Mutant:";
            // 
            // numericHueVariation
            // 
            this.numericHueVariation.Location = new System.Drawing.Point(107, 98);
            this.numericHueVariation.Name = "numericHueVariation";
            this.numericHueVariation.Size = new System.Drawing.Size(87, 20);
            this.numericHueVariation.TabIndex = 19;
            this.numericHueVariation.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericMutant
            // 
            this.numericMutant.Location = new System.Drawing.Point(107, 150);
            this.numericMutant.Name = "numericMutant";
            this.numericMutant.Size = new System.Drawing.Size(87, 20);
            this.numericMutant.TabIndex = 13;
            // 
            // groupEffects
            // 
            this.groupEffects.Controls.Add(this.numericKink);
            this.groupEffects.Controls.Add(this.numericFlyAway);
            this.groupEffects.Controls.Add(this.labelKink);
            this.groupEffects.Controls.Add(this.labelFlyAway);
            this.groupEffects.Controls.Add(this.numericClump);
            this.groupEffects.Controls.Add(this.labelClump);
            this.groupEffects.Location = new System.Drawing.Point(12, 232);
            this.groupEffects.Name = "groupEffects";
            this.groupEffects.Size = new System.Drawing.Size(232, 112);
            this.groupEffects.TabIndex = 9;
            this.groupEffects.TabStop = false;
            // 
            // numericKink
            // 
            this.numericKink.Location = new System.Drawing.Point(122, 75);
            this.numericKink.Name = "numericKink";
            this.numericKink.Size = new System.Drawing.Size(96, 20);
            this.numericKink.TabIndex = 14;
            // 
            // numericFlyAway
            // 
            this.numericFlyAway.Location = new System.Drawing.Point(122, 21);
            this.numericFlyAway.Name = "numericFlyAway";
            this.numericFlyAway.Size = new System.Drawing.Size(96, 20);
            this.numericFlyAway.TabIndex = 15;
            // 
            // labelKink
            // 
            this.labelKink.AutoSize = true;
            this.labelKink.Location = new System.Drawing.Point(19, 77);
            this.labelKink.Name = "labelKink";
            this.labelKink.Size = new System.Drawing.Size(31, 13);
            this.labelKink.TabIndex = 12;
            this.labelKink.Text = "Kink:";
            // 
            // labelFlyAway
            // 
            this.labelFlyAway.AutoSize = true;
            this.labelFlyAway.Location = new System.Drawing.Point(19, 23);
            this.labelFlyAway.Name = "labelFlyAway";
            this.labelFlyAway.Size = new System.Drawing.Size(89, 13);
            this.labelFlyAway.TabIndex = 13;
            this.labelFlyAway.Text = "Flyaway strength:";
            // 
            // numericClump
            // 
            this.numericClump.Location = new System.Drawing.Point(122, 49);
            this.numericClump.Name = "numericClump";
            this.numericClump.Size = new System.Drawing.Size(96, 20);
            this.numericClump.TabIndex = 17;
            // 
            // labelClump
            // 
            this.labelClump.AutoSize = true;
            this.labelClump.Location = new System.Drawing.Point(19, 51);
            this.labelClump.Name = "labelClump";
            this.labelClump.Size = new System.Drawing.Size(80, 13);
            this.labelClump.TabIndex = 16;
            this.labelClump.Text = "Clump strength:";
            // 
            // FurDialog
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(481, 358);
            this.Controls.Add(this.groupEffects);
            this.Controls.Add(this.groupMaterial);
            this.Controls.Add(this.groupParametersFur);
            this.Controls.Add(this.groupAddFur);
            this.Name = "FurDialog";
            this.Text = "Hair and Fur modifier";
            this.groupAddFur.ResumeLayout(false);
            this.groupAddFur.PerformLayout();
            this.groupParametersFur.ResumeLayout(false);
            this.groupParametersFur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTransitionSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRootThick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRandomScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSegments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSteps)).EndInit();
            this.groupMaterial.ResumeLayout(false);
            this.groupMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGlossiness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValueVariation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpecular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHueVariation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMutant)).EndInit();
            this.groupEffects.ResumeLayout(false);
            this.groupEffects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericKink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFlyAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericClump)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAddFur;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupParametersFur;
        private System.Windows.Forms.Button buttonTipColor;
        private System.Windows.Forms.Button buttonRootColor;
        private System.Windows.Forms.Label labelTipColor;
        private System.Windows.Forms.Label labelRootColor;
        private System.Windows.Forms.NumericUpDown numericSteps;
        private System.Windows.Forms.Label labelSteps;
        private System.Windows.Forms.NumericUpDown numericScale;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupMaterial;
        private System.Windows.Forms.Button buttonMutantColor;
        private System.Windows.Forms.Label labelMutantColor;
        private System.Windows.Forms.NumericUpDown numericRootThick;
        private System.Windows.Forms.Label labelRootThick;
        private System.Windows.Forms.NumericUpDown numericRandomScale;
        private System.Windows.Forms.Label labelRandomScale;
        private System.Windows.Forms.NumericUpDown numericSegments;
        private System.Windows.Forms.Label labelSegments;
        private System.Windows.Forms.NumericUpDown numericGlossiness;
        private System.Windows.Forms.Label labelGlossiness;
        private System.Windows.Forms.NumericUpDown numericSpecular;
        private System.Windows.Forms.Label labelSpecular;
        private System.Windows.Forms.NumericUpDown numericMutant;
        private System.Windows.Forms.Label labelMutant;
        private System.Windows.Forms.GroupBox groupEffects;
        private System.Windows.Forms.NumericUpDown numericKink;
        private System.Windows.Forms.NumericUpDown numericFlyAway;
        private System.Windows.Forms.Label labelKink;
        private System.Windows.Forms.Label labelFlyAway;
        private System.Windows.Forms.NumericUpDown numericClump;
        private System.Windows.Forms.Label labelClump;
        private System.Windows.Forms.NumericUpDown numericValueVariation;
        private System.Windows.Forms.Label labelValueVariation;
        private System.Windows.Forms.Label labelHueVariation;
        private System.Windows.Forms.NumericUpDown numericHueVariation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarTransitionSpeed;
        private System.Windows.Forms.Label labelTransitionSpeed;
        private System.Windows.Forms.Label label2;
    }
}