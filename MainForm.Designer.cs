namespace PokemonHGSSMoveEditor
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.moveComboBx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.powerMaskTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.accuracyMaskTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ppMaskTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.typeComboBx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.effectMaskTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.effectChanceMaskTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.categoryComboBx = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.targetComboBx = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.priorityMaskTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.contestEffectMaskTxtBx = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.contestConditionComboBx = new System.Windows.Forms.ComboBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToRomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactCheckBx = new System.Windows.Forms.CheckBox();
            this.protectCheckBx = new System.Windows.Forms.CheckBox();
            this.magicCoatCheckBx = new System.Windows.Forms.CheckBox();
            this.snatchCheckBx = new System.Windows.Forms.CheckBox();
            this.mirrorMoveCheckBx = new System.Windows.Forms.CheckBox();
            this.kingsRockCheckBx = new System.Windows.Forms.CheckBox();
            this.keepHPBarCheckBx = new System.Windows.Forms.CheckBox();
            this.hideShadowCheckBx = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flagsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // moveComboBx
            // 
            this.moveComboBx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.moveComboBx.FormattingEnabled = true;
            this.moveComboBx.Location = new System.Drawing.Point(301, 63);
            this.moveComboBx.MaxDropDownItems = 10;
            this.moveComboBx.MaxLength = 20;
            this.moveComboBx.Name = "moveComboBx";
            this.moveComboBx.Size = new System.Drawing.Size(121, 21);
            this.moveComboBx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Move:";
            // 
            // powerMaskTxtBx
            // 
            this.powerMaskTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.powerMaskTxtBx.HidePromptOnLeave = true;
            this.powerMaskTxtBx.Location = new System.Drawing.Point(61, 178);
            this.powerMaskTxtBx.Mask = "900";
            this.powerMaskTxtBx.Name = "powerMaskTxtBx";
            this.powerMaskTxtBx.PromptChar = ' ';
            this.powerMaskTxtBx.Size = new System.Drawing.Size(120, 20);
            this.powerMaskTxtBx.TabIndex = 1;
            this.powerMaskTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Power:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Accuracy:";
            // 
            // accuracyMaskTxtBx
            // 
            this.accuracyMaskTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.accuracyMaskTxtBx.HidePromptOnLeave = true;
            this.accuracyMaskTxtBx.Location = new System.Drawing.Point(61, 251);
            this.accuracyMaskTxtBx.Mask = "900%";
            this.accuracyMaskTxtBx.Name = "accuracyMaskTxtBx";
            this.accuracyMaskTxtBx.PromptChar = ' ';
            this.accuracyMaskTxtBx.Size = new System.Drawing.Size(118, 20);
            this.accuracyMaskTxtBx.TabIndex = 2;
            this.accuracyMaskTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PP:";
            // 
            // ppMaskTxtBx
            // 
            this.ppMaskTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.ppMaskTxtBx.HidePromptOnLeave = true;
            this.ppMaskTxtBx.Location = new System.Drawing.Point(61, 328);
            this.ppMaskTxtBx.Mask = "90";
            this.ppMaskTxtBx.Name = "ppMaskTxtBx";
            this.ppMaskTxtBx.PromptChar = ' ';
            this.ppMaskTxtBx.Size = new System.Drawing.Size(118, 20);
            this.ppMaskTxtBx.TabIndex = 3;
            this.ppMaskTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // typeComboBx
            // 
            this.typeComboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBx.FormattingEnabled = true;
            this.typeComboBx.Location = new System.Drawing.Point(201, 177);
            this.typeComboBx.Name = "typeComboBx";
            this.typeComboBx.Size = new System.Drawing.Size(118, 21);
            this.typeComboBx.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Effect:";
            // 
            // effectMaskTxtBx
            // 
            this.effectMaskTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.effectMaskTxtBx.HidePromptOnLeave = true;
            this.effectMaskTxtBx.Location = new System.Drawing.Point(201, 251);
            this.effectMaskTxtBx.Mask = "900";
            this.effectMaskTxtBx.Name = "effectMaskTxtBx";
            this.effectMaskTxtBx.PromptChar = ' ';
            this.effectMaskTxtBx.Size = new System.Drawing.Size(118, 20);
            this.effectMaskTxtBx.TabIndex = 6;
            this.effectMaskTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Effect Chance:";
            // 
            // effectChanceMaskTxtBx
            // 
            this.effectChanceMaskTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.effectChanceMaskTxtBx.HidePromptOnLeave = true;
            this.effectChanceMaskTxtBx.Location = new System.Drawing.Point(201, 328);
            this.effectChanceMaskTxtBx.Mask = "900%";
            this.effectChanceMaskTxtBx.Name = "effectChanceMaskTxtBx";
            this.effectChanceMaskTxtBx.PromptChar = ' ';
            this.effectChanceMaskTxtBx.Size = new System.Drawing.Size(118, 20);
            this.effectChanceMaskTxtBx.TabIndex = 7;
            this.effectChanceMaskTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Category:";
            // 
            // categoryComboBx
            // 
            this.categoryComboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBx.FormattingEnabled = true;
            this.categoryComboBx.Location = new System.Drawing.Point(347, 177);
            this.categoryComboBx.MaxDropDownItems = 3;
            this.categoryComboBx.Name = "categoryComboBx";
            this.categoryComboBx.Size = new System.Drawing.Size(118, 21);
            this.categoryComboBx.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Target:";
            // 
            // targetComboBx
            // 
            this.targetComboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetComboBx.FormattingEnabled = true;
            this.targetComboBx.Location = new System.Drawing.Point(344, 327);
            this.targetComboBx.MaxDropDownItems = 9;
            this.targetComboBx.Name = "targetComboBx";
            this.targetComboBx.Size = new System.Drawing.Size(118, 21);
            this.targetComboBx.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(347, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Priority:";
            // 
            // priorityMaskTxtBx
            // 
            this.priorityMaskTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.priorityMaskTxtBx.HidePromptOnLeave = true;
            this.priorityMaskTxtBx.Location = new System.Drawing.Point(347, 251);
            this.priorityMaskTxtBx.Mask = "#9";
            this.priorityMaskTxtBx.Name = "priorityMaskTxtBx";
            this.priorityMaskTxtBx.PromptChar = ' ';
            this.priorityMaskTxtBx.Size = new System.Drawing.Size(118, 20);
            this.priorityMaskTxtBx.TabIndex = 8;
            this.priorityMaskTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(530, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Contest Effect:";
            // 
            // contestEffectMaskTxtBx
            // 
            this.contestEffectMaskTxtBx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.contestEffectMaskTxtBx.HidePromptOnLeave = true;
            this.contestEffectMaskTxtBx.Location = new System.Drawing.Point(532, 177);
            this.contestEffectMaskTxtBx.Mask = "900";
            this.contestEffectMaskTxtBx.Name = "contestEffectMaskTxtBx";
            this.contestEffectMaskTxtBx.PromptChar = ' ';
            this.contestEffectMaskTxtBx.Size = new System.Drawing.Size(118, 20);
            this.contestEffectMaskTxtBx.TabIndex = 9;
            this.contestEffectMaskTxtBx.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(530, 223);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Contest Condition:";
            // 
            // contestConditionComboBx
            // 
            this.contestConditionComboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contestConditionComboBx.FormattingEnabled = true;
            this.contestConditionComboBx.Location = new System.Drawing.Point(532, 251);
            this.contestConditionComboBx.MaxDropDownItems = 3;
            this.contestConditionComboBx.Name = "contestConditionComboBx";
            this.contestConditionComboBx.Size = new System.Drawing.Size(118, 21);
            this.contestConditionComboBx.TabIndex = 10;
            // 
            // resetButton
            // 
            this.resetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetButton.Location = new System.Drawing.Point(218, 409);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 20;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToRomToolStripMenuItem,
            this.saveAsFileToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToRomToolStripMenuItem
            // 
            this.saveToRomToolStripMenuItem.Name = "saveToRomToolStripMenuItem";
            this.saveToRomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToRomToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.saveToRomToolStripMenuItem.Text = "Save to Rom";
            this.saveToRomToolStripMenuItem.Click += new System.EventHandler(this.saveToRomToolStripMenuItem_Click);
            // 
            // saveAsFileToolStripMenuItem
            // 
            this.saveAsFileToolStripMenuItem.Name = "saveAsFileToolStripMenuItem";
            this.saveAsFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsFileToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.saveAsFileToolStripMenuItem.Text = "Save as binary file";
            this.saveAsFileToolStripMenuItem.Click += new System.EventHandler(this.saveAsFileToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMoveToolStripMenuItem,
            this.newTypeToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // newMoveToolStripMenuItem
            // 
            this.newMoveToolStripMenuItem.Name = "newMoveToolStripMenuItem";
            this.newMoveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMoveToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.newMoveToolStripMenuItem.Text = "New Move";
            this.newMoveToolStripMenuItem.Click += new System.EventHandler(this.newMoveToolStripMenuItem_Click);
            // 
            // newTypeToolStripMenuItem
            // 
            this.newTypeToolStripMenuItem.Name = "newTypeToolStripMenuItem";
            this.newTypeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newTypeToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.newTypeToolStripMenuItem.Text = "New Type";
            this.newTypeToolStripMenuItem.Click += new System.EventHandler(this.newTypeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contactCheckBx
            // 
            this.contactCheckBx.AutoSize = true;
            this.contactCheckBx.Location = new System.Drawing.Point(29, 30);
            this.contactCheckBx.Name = "contactCheckBx";
            this.contactCheckBx.Size = new System.Drawing.Size(97, 17);
            this.contactCheckBx.TabIndex = 12;
            this.contactCheckBx.Text = "Makes contact";
            this.flagsToolTip.SetToolTip(this.contactCheckBx, "Makes contact effects apply when the move is  used (ex. poison point causing pois" +
        "oning when being attacked)");
            this.contactCheckBx.UseVisualStyleBackColor = true;
            // 
            // protectCheckBx
            // 
            this.protectCheckBx.AutoSize = true;
            this.protectCheckBx.Location = new System.Drawing.Point(29, 53);
            this.protectCheckBx.Name = "protectCheckBx";
            this.protectCheckBx.Size = new System.Drawing.Size(117, 17);
            this.protectCheckBx.TabIndex = 13;
            this.protectCheckBx.Text = "Affected by Protect";
            this.flagsToolTip.SetToolTip(this.protectCheckBx, "Causes the move to have no affect on any targets that used protect/detect on the " +
        "same turn");
            this.protectCheckBx.UseVisualStyleBackColor = true;
            // 
            // magicCoatCheckBx
            // 
            this.magicCoatCheckBx.AutoSize = true;
            this.magicCoatCheckBx.Location = new System.Drawing.Point(29, 76);
            this.magicCoatCheckBx.Name = "magicCoatCheckBx";
            this.magicCoatCheckBx.Size = new System.Drawing.Size(137, 17);
            this.magicCoatCheckBx.TabIndex = 14;
            this.magicCoatCheckBx.Text = "Affected by Magic Coat";
            this.flagsToolTip.SetToolTip(this.magicCoatCheckBx, "Allows the move to be reflected by targets that use magic coat on the same turn");
            this.magicCoatCheckBx.UseVisualStyleBackColor = true;
            // 
            // snatchCheckBx
            // 
            this.snatchCheckBx.AutoSize = true;
            this.snatchCheckBx.Location = new System.Drawing.Point(29, 98);
            this.snatchCheckBx.Name = "snatchCheckBx";
            this.snatchCheckBx.Size = new System.Drawing.Size(117, 17);
            this.snatchCheckBx.TabIndex = 15;
            this.snatchCheckBx.Text = "Affected by Snatch";
            this.flagsToolTip.SetToolTip(this.snatchCheckBx, "Allows this move to be stolen by pokemon using snatch on the same turn");
            this.snatchCheckBx.UseVisualStyleBackColor = true;
            // 
            // mirrorMoveCheckBx
            // 
            this.mirrorMoveCheckBx.AutoSize = true;
            this.mirrorMoveCheckBx.Location = new System.Drawing.Point(29, 121);
            this.mirrorMoveCheckBx.Name = "mirrorMoveCheckBx";
            this.mirrorMoveCheckBx.Size = new System.Drawing.Size(139, 17);
            this.mirrorMoveCheckBx.TabIndex = 16;
            this.mirrorMoveCheckBx.Text = "Affected by Mirror Move";
            this.flagsToolTip.SetToolTip(this.mirrorMoveCheckBx, "Allows the move to be copied by pokemon using mirror move on the user");
            this.mirrorMoveCheckBx.UseVisualStyleBackColor = true;
            // 
            // kingsRockCheckBx
            // 
            this.kingsRockCheckBx.AutoSize = true;
            this.kingsRockCheckBx.Location = new System.Drawing.Point(29, 144);
            this.kingsRockCheckBx.Name = "kingsRockCheckBx";
            this.kingsRockCheckBx.Size = new System.Drawing.Size(140, 17);
            this.kingsRockCheckBx.TabIndex = 17;
            this.kingsRockCheckBx.Text = "Affected by King\'s Rock";
            this.flagsToolTip.SetToolTip(this.kingsRockCheckBx, "Applies the flinch chance of the king\'s rock if held while a pokemon uses this mo" +
        "ve");
            this.kingsRockCheckBx.UseVisualStyleBackColor = true;
            // 
            // keepHPBarCheckBx
            // 
            this.keepHPBarCheckBx.AutoSize = true;
            this.keepHPBarCheckBx.Location = new System.Drawing.Point(29, 167);
            this.keepHPBarCheckBx.Name = "keepHPBarCheckBx";
            this.keepHPBarCheckBx.Size = new System.Drawing.Size(87, 17);
            this.keepHPBarCheckBx.TabIndex = 18;
            this.keepHPBarCheckBx.Text = "Keep HP bar";
            this.flagsToolTip.SetToolTip(this.keepHPBarCheckBx, "Show the HP bar when the move animation is playing");
            this.keepHPBarCheckBx.UseVisualStyleBackColor = true;
            // 
            // hideShadowCheckBx
            // 
            this.hideShadowCheckBx.AutoSize = true;
            this.hideShadowCheckBx.Location = new System.Drawing.Point(29, 190);
            this.hideShadowCheckBx.Name = "hideShadowCheckBx";
            this.hideShadowCheckBx.Size = new System.Drawing.Size(88, 17);
            this.hideShadowCheckBx.TabIndex = 19;
            this.hideShadowCheckBx.Text = "Hide shadow";
            this.flagsToolTip.SetToolTip(this.hideShadowCheckBx, "Hide the shadow of the opposing pokemon while the move animation is playing");
            this.hideShadowCheckBx.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.contactCheckBx);
            this.groupBox1.Controls.Add(this.hideShadowCheckBx);
            this.groupBox1.Controls.Add(this.protectCheckBx);
            this.groupBox1.Controls.Add(this.keepHPBarCheckBx);
            this.groupBox1.Controls.Add(this.magicCoatCheckBx);
            this.groupBox1.Controls.Add(this.kingsRockCheckBx);
            this.groupBox1.Controls.Add(this.snatchCheckBx);
            this.groupBox1.Controls.Add(this.mirrorMoveCheckBx);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(495, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 229);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.resetButton;
            this.ClientSize = new System.Drawing.Size(734, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.contestConditionComboBx);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.contestEffectMaskTxtBx);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.priorityMaskTxtBx);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.targetComboBx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.categoryComboBx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.effectChanceMaskTxtBx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.effectMaskTxtBx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.typeComboBx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ppMaskTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accuracyMaskTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.powerMaskTxtBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moveComboBx);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Pokemon Gen 4 Move Editor";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox moveComboBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox powerMaskTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox accuracyMaskTxtBx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox ppMaskTxtBx;
        private System.Windows.Forms.ComboBox typeComboBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox effectMaskTxtBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox effectChanceMaskTxtBx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox categoryComboBx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox targetComboBx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox priorityMaskTxtBx;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox contestEffectMaskTxtBx;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox contestConditionComboBx;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMoveToolStripMenuItem;
        private System.Windows.Forms.CheckBox contactCheckBx;
        private System.Windows.Forms.CheckBox protectCheckBx;
        private System.Windows.Forms.CheckBox magicCoatCheckBx;
        private System.Windows.Forms.CheckBox snatchCheckBx;
        private System.Windows.Forms.CheckBox mirrorMoveCheckBx;
        private System.Windows.Forms.CheckBox kingsRockCheckBx;
        private System.Windows.Forms.CheckBox keepHPBarCheckBx;
        private System.Windows.Forms.CheckBox hideShadowCheckBx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip flagsToolTip;
        private System.Windows.Forms.ToolStripMenuItem saveToRomToolStripMenuItem;
    }
}

