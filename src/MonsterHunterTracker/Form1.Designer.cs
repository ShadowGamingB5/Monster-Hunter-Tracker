namespace MonsterHunterTracker;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        lblGameName = new System.Windows.Forms.Label();
        gbGame = new System.Windows.Forms.GroupBox();
        gbMonsterList = new System.Windows.Forms.GroupBox();
        btnDecrementCount = new System.Windows.Forms.Button();
        lblHunted = new System.Windows.Forms.Label();
        btnIncrementCount = new System.Windows.Forms.Button();
        btnClear = new System.Windows.Forms.Button();
        txtMonsterCounts = new System.Windows.Forms.TextBox();
        btnRemove = new System.Windows.Forms.Button();
        btnAddToMonsterList = new System.Windows.Forms.Button();
        lstMonsterList = new System.Windows.Forms.ListBox();
        txtMonsterListSearch = new System.Windows.Forms.TextBox();
        groupMonsterList = new System.Windows.Forms.GroupBox();
        groupBox1 = new System.Windows.Forms.GroupBox();
        rbCharacter1 = new System.Windows.Forms.RadioButton();
        rbCharacter2 = new System.Windows.Forms.RadioButton();
        rbCharacter3 = new System.Windows.Forms.RadioButton();
        rbDamaging = new System.Windows.Forms.RadioButton();
        rbDropsLow = new System.Windows.Forms.RadioButton();
        rbDropsHigh = new System.Windows.Forms.RadioButton();
        rbDropsMaster = new System.Windows.Forms.RadioButton();
        label1 = new System.Windows.Forms.Label();
        gbGame.SuspendLayout();
        gbMonsterList.SuspendLayout();
        groupMonsterList.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // lblGameName
        // 
        lblGameName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblGameName.Location = new System.Drawing.Point(3, 31);
        lblGameName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        lblGameName.Name = "lblGameName";
        lblGameName.Size = new System.Drawing.Size(271, 20);
        lblGameName.TabIndex = 0;
        lblGameName.Text = "Monster Hunter Generations Ultimate";
        // 
        // gbGame
        // 
        gbGame.Controls.Add(lblGameName);
        gbGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        gbGame.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        gbGame.Location = new System.Drawing.Point(12, 3);
        gbGame.Name = "gbGame";
        gbGame.Size = new System.Drawing.Size(281, 61);
        gbGame.TabIndex = 2;
        gbGame.TabStop = false;
        gbGame.Text = "Game";
        // 
        // gbMonsterList
        // 
        gbMonsterList.Controls.Add(label1);
        gbMonsterList.Controls.Add(rbDropsMaster);
        gbMonsterList.Controls.Add(rbDropsHigh);
        gbMonsterList.Controls.Add(rbDropsLow);
        gbMonsterList.Controls.Add(rbDamaging);
        gbMonsterList.Controls.Add(btnDecrementCount);
        gbMonsterList.Controls.Add(lblHunted);
        gbMonsterList.Controls.Add(btnIncrementCount);
        gbMonsterList.Controls.Add(btnClear);
        gbMonsterList.Controls.Add(txtMonsterCounts);
        gbMonsterList.Controls.Add(btnRemove);
        gbMonsterList.Controls.Add(btnAddToMonsterList);
        gbMonsterList.Controls.Add(lstMonsterList);
        gbMonsterList.Controls.Add(txtMonsterListSearch);
        gbMonsterList.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        gbMonsterList.Location = new System.Drawing.Point(16, 22);
        gbMonsterList.Name = "gbMonsterList";
        gbMonsterList.Size = new System.Drawing.Size(380, 347);
        gbMonsterList.TabIndex = 3;
        gbMonsterList.TabStop = false;
        gbMonsterList.Text = "Monster List";
        // 
        // btnDecrementCount
        // 
        btnDecrementCount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        btnDecrementCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnDecrementCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnDecrementCount.Location = new System.Drawing.Point(316, 101);
        btnDecrementCount.Name = "btnDecrementCount";
        btnDecrementCount.Size = new System.Drawing.Size(58, 40);
        btnDecrementCount.TabIndex = 2;
        btnDecrementCount.Text = "-";
        btnDecrementCount.UseVisualStyleBackColor = false;
        // 
        // lblHunted
        // 
        lblHunted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblHunted.Location = new System.Drawing.Point(240, 72);
        lblHunted.Name = "lblHunted";
        lblHunted.Size = new System.Drawing.Size(62, 23);
        lblHunted.TabIndex = 5;
        lblHunted.Text = "Hunted";
        // 
        // btnIncrementCount
        // 
        btnIncrementCount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        btnIncrementCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnIncrementCount.ForeColor = System.Drawing.SystemColors.ButtonFace;
        btnIncrementCount.Location = new System.Drawing.Point(240, 101);
        btnIncrementCount.Name = "btnIncrementCount";
        btnIncrementCount.Size = new System.Drawing.Size(58, 40);
        btnIncrementCount.TabIndex = 1;
        btnIncrementCount.Text = "+";
        btnIncrementCount.UseVisualStyleBackColor = false;
        // 
        // btnClear
        // 
        btnClear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnClear.Location = new System.Drawing.Point(205, 34);
        btnClear.Name = "btnClear";
        btnClear.Size = new System.Drawing.Size(29, 29);
        btnClear.TabIndex = 4;
        btnClear.Text = "X";
        btnClear.UseVisualStyleBackColor = false;
        // 
        // txtMonsterCounts
        // 
        txtMonsterCounts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtMonsterCounts.Location = new System.Drawing.Point(316, 69);
        txtMonsterCounts.MaxLength = 3;
        txtMonsterCounts.Name = "txtMonsterCounts";
        txtMonsterCounts.ReadOnly = true;
        txtMonsterCounts.Size = new System.Drawing.Size(58, 29);
        txtMonsterCounts.TabIndex = 0;
        txtMonsterCounts.Text = "999";
        txtMonsterCounts.WordWrap = false;
        // 
        // btnRemove
        // 
        btnRemove.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnRemove.Location = new System.Drawing.Point(293, 34);
        btnRemove.Name = "btnRemove";
        btnRemove.Size = new System.Drawing.Size(81, 29);
        btnRemove.TabIndex = 3;
        btnRemove.Text = "Remove";
        btnRemove.UseVisualStyleBackColor = false;
        // 
        // btnAddToMonsterList
        // 
        btnAddToMonsterList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        btnAddToMonsterList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddToMonsterList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnAddToMonsterList.Location = new System.Drawing.Point(240, 34);
        btnAddToMonsterList.Name = "btnAddToMonsterList";
        btnAddToMonsterList.Size = new System.Drawing.Size(48, 29);
        btnAddToMonsterList.TabIndex = 2;
        btnAddToMonsterList.Text = "Add";
        btnAddToMonsterList.UseVisualStyleBackColor = false;
        // 
        // lstMonsterList
        // 
        lstMonsterList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lstMonsterList.FormattingEnabled = true;
        lstMonsterList.Items.AddRange(new object[]
        {
            "Berserk Tetsucabra", "Drilltusk Tetsucabra", "Tigerstripe Zamtrios", "Great Izuchi", "Nightcloak Malfestio", "Coral Pukei-Pukei", "Scarred Yian Garuga", "Deadeye Yian Garuga", "Hellblade Glavenus", "Crystalbeard Uragaan", "Plum Daimyo Hermitaur", "Terra Shogun Ceanataur", "Guardian Ebony Odogaron", "Guardian Fulgar Anjanath", "Hallowed Jhen Mohran", "Risen Crimson Glow Valstrax", "Blood Orange Bishaten", "Pyre Rakna-Kadaki", "Chaotic Gore Magala"
        });

        lstMonsterList.Location = new System.Drawing.Point(6, 75);
        lstMonsterList.Name = "lstMonsterList";
        lstMonsterList.Size = new System.Drawing.Size(228, 256);
        lstMonsterList.TabIndex = 1;
        // 
        // txtMonsterListSearch
        // 
        txtMonsterListSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtMonsterListSearch.Location = new System.Drawing.Point(6, 34);
        txtMonsterListSearch.Name = "txtMonsterListSearch";
        txtMonsterListSearch.Size = new System.Drawing.Size(197, 29);
        txtMonsterListSearch.TabIndex = 0;
        // 
        // groupMonsterList
        // 
        groupMonsterList.Controls.Add(gbMonsterList);
        groupMonsterList.Location = new System.Drawing.Point(12, 70);
        groupMonsterList.Name = "groupMonsterList";
        groupMonsterList.Size = new System.Drawing.Size(656, 375);
        groupMonsterList.TabIndex = 5;
        groupMonsterList.TabStop = false;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(rbCharacter3);
        groupBox1.Controls.Add(rbCharacter2);
        groupBox1.Controls.Add(rbCharacter1);
        groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        groupBox1.Location = new System.Drawing.Point(295, 3);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(367, 61);
        groupBox1.TabIndex = 6;
        groupBox1.TabStop = false;
        groupBox1.Text = "Character Selection";
        // 
        // rbCharacter1
        // 
        rbCharacter1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        rbCharacter1.Location = new System.Drawing.Point(9, 27);
        rbCharacter1.Name = "rbCharacter1";
        rbCharacter1.Size = new System.Drawing.Size(104, 24);
        rbCharacter1.TabIndex = 0;
        rbCharacter1.TabStop = true;
        rbCharacter1.Text = "Character1";
        rbCharacter1.UseVisualStyleBackColor = true;
        // 
        // rbCharacter2
        // 
        rbCharacter2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        rbCharacter2.Location = new System.Drawing.Point(129, 27);
        rbCharacter2.Name = "rbCharacter2";
        rbCharacter2.Size = new System.Drawing.Size(104, 24);
        rbCharacter2.TabIndex = 1;
        rbCharacter2.TabStop = true;
        rbCharacter2.Text = "Character2";
        rbCharacter2.UseVisualStyleBackColor = true;
        // 
        // rbCharacter3
        // 
        rbCharacter3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        rbCharacter3.Location = new System.Drawing.Point(257, 27);
        rbCharacter3.Name = "rbCharacter3";
        rbCharacter3.Size = new System.Drawing.Size(104, 24);
        rbCharacter3.TabIndex = 2;
        rbCharacter3.TabStop = true;
        rbCharacter3.Text = "Character3";
        rbCharacter3.UseVisualStyleBackColor = true;
        // 
        // rbDamaging
        // 
        rbDamaging.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        rbDamaging.Location = new System.Drawing.Point(240, 179);
        rbDamaging.Name = "rbDamaging";
        rbDamaging.Size = new System.Drawing.Size(134, 29);
        rbDamaging.TabIndex = 6;
        rbDamaging.TabStop = true;
        rbDamaging.Text = "Damaging";
        rbDamaging.UseVisualStyleBackColor = true;
        // 
        // rbDropsLow
        // 
        rbDropsLow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        rbDropsLow.Location = new System.Drawing.Point(240, 214);
        rbDropsLow.Name = "rbDropsLow";
        rbDropsLow.Size = new System.Drawing.Size(134, 24);
        rbDropsLow.TabIndex = 7;
        rbDropsLow.TabStop = true;
        rbDropsLow.Text = "Drops - Low";
        rbDropsLow.UseVisualStyleBackColor = true;
        // 
        // rbDropsHigh
        // 
        rbDropsHigh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        rbDropsHigh.Location = new System.Drawing.Point(240, 244);
        rbDropsHigh.Name = "rbDropsHigh";
        rbDropsHigh.Size = new System.Drawing.Size(134, 27);
        rbDropsHigh.TabIndex = 8;
        rbDropsHigh.TabStop = true;
        rbDropsHigh.Text = "Drops - High";
        rbDropsHigh.UseVisualStyleBackColor = true;
        // 
        // rbDropsMaster
        // 
        rbDropsMaster.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        rbDropsMaster.Location = new System.Drawing.Point(240, 277);
        rbDropsMaster.Name = "rbDropsMaster";
        rbDropsMaster.Size = new System.Drawing.Size(134, 24);
        rbDropsMaster.TabIndex = 9;
        rbDropsMaster.TabStop = true;
        rbDropsMaster.Text = "Drops - Master";
        rbDropsMaster.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(240, 153);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 10;
        label1.Text = "Selection";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ControlDarkDark;
        ClientSize = new System.Drawing.Size(680, 457);
        Controls.Add(groupBox1);
        Controls.Add(groupMonsterList);
        Controls.Add(gbGame);
        Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        ForeColor = System.Drawing.SystemColors.ControlLightLight;
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        MaximizeBox = false;
        Text = "Monster Hunter Tracker";
        gbGame.ResumeLayout(false);
        gbMonsterList.ResumeLayout(false);
        gbMonsterList.PerformLayout();
        groupMonsterList.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.RadioButton rbDropsLow;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.RadioButton rbDamaging;
    private System.Windows.Forms.RadioButton rbDropsHigh;

    private System.Windows.Forms.RadioButton rbDropsMaster;

    private System.Windows.Forms.RadioButton rbCharacter3;

    private System.Windows.Forms.RadioButton rbCharacter2;

    private System.Windows.Forms.RadioButton rbCharacter1;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.Label lblHunted;

    private System.Windows.Forms.GroupBox groupMonsterList;

    private System.Windows.Forms.Button btnClear;

    private System.Windows.Forms.Button btnRemove;

    private System.Windows.Forms.Button btnAddToMonsterList;

    private System.Windows.Forms.Button btnDecrementCount;

    private System.Windows.Forms.Button btnIncrementCount;

    private System.Windows.Forms.TextBox txtMonsterCounts;

    private System.Windows.Forms.TextBox txtMonsterListSearch;
    private System.Windows.Forms.ListBox lstMonsterList;

    private System.Windows.Forms.GroupBox gbMonsterList;

    private System.Windows.Forms.GroupBox gbGame;

    private System.Windows.Forms.Label lblGameName;

    #endregion
}
