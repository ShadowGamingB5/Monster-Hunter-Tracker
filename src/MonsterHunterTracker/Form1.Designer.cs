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
        btnClear = new System.Windows.Forms.Button();
        btnRemove = new System.Windows.Forms.Button();
        btnAddToMonsterList = new System.Windows.Forms.Button();
        lstMonsterList = new System.Windows.Forms.ListBox();
        txtMonsterListSearch = new System.Windows.Forms.TextBox();
        groupBox1 = new System.Windows.Forms.GroupBox();
        btnDecrementCount = new System.Windows.Forms.Button();
        btnIncrementCount = new System.Windows.Forms.Button();
        txtMonsterCounts = new System.Windows.Forms.TextBox();
        groupMonsterList = new System.Windows.Forms.GroupBox();
        gbGame.SuspendLayout();
        gbMonsterList.SuspendLayout();
        groupBox1.SuspendLayout();
        groupMonsterList.SuspendLayout();
        SuspendLayout();
        // 
        // lblGameName
        // 
        lblGameName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblGameName.Location = new System.Drawing.Point(9, 31);
        lblGameName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        lblGameName.Name = "lblGameName";
        lblGameName.Size = new System.Drawing.Size(212, 20);
        lblGameName.TabIndex = 0;
        lblGameName.Text = "Monster Hunter Generations Ultimate";
        // 
        // gbGame
        // 
        gbGame.Controls.Add(lblGameName);
        gbGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
        gbGame.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        gbGame.Location = new System.Drawing.Point(28, 24);
        gbGame.Name = "gbGame";
        gbGame.Size = new System.Drawing.Size(234, 61);
        gbGame.TabIndex = 2;
        gbGame.TabStop = false;
        gbGame.Text = "Game";
        // 
        // gbMonsterList
        // 
        gbMonsterList.Controls.Add(btnClear);
        gbMonsterList.Controls.Add(btnRemove);
        gbMonsterList.Controls.Add(btnAddToMonsterList);
        gbMonsterList.Controls.Add(lstMonsterList);
        gbMonsterList.Controls.Add(txtMonsterListSearch);
        gbMonsterList.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        gbMonsterList.Location = new System.Drawing.Point(16, 22);
        gbMonsterList.Name = "gbMonsterList";
        gbMonsterList.Size = new System.Drawing.Size(403, 266);
        gbMonsterList.TabIndex = 3;
        gbMonsterList.TabStop = false;
        gbMonsterList.Text = "Monster List";
        // 
        // btnClear
        // 
        btnClear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnClear.Location = new System.Drawing.Point(273, 35);
        btnClear.Name = "btnClear";
        btnClear.Size = new System.Drawing.Size(29, 34);
        btnClear.TabIndex = 4;
        btnClear.Text = "X";
        btnClear.UseVisualStyleBackColor = false;
        // 
        // btnRemove
        // 
        btnRemove.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnRemove.Location = new System.Drawing.Point(316, 120);
        btnRemove.Name = "btnRemove";
        btnRemove.Size = new System.Drawing.Size(81, 34);
        btnRemove.TabIndex = 3;
        btnRemove.Text = "Remove";
        btnRemove.UseVisualStyleBackColor = false;
        // 
        // btnAddToMonsterList
        // 
        btnAddToMonsterList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        btnAddToMonsterList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnAddToMonsterList.Location = new System.Drawing.Point(315, 79);
        btnAddToMonsterList.Name = "btnAddToMonsterList";
        btnAddToMonsterList.Size = new System.Drawing.Size(82, 35);
        btnAddToMonsterList.TabIndex = 2;
        btnAddToMonsterList.Text = "Add";
        btnAddToMonsterList.UseVisualStyleBackColor = false;
        // 
        // lstMonsterList
        // 
        lstMonsterList.FormattingEnabled = true;
        lstMonsterList.Items.AddRange(new object[]
        {
            "Berserk Tetsucabra", "Drilltusk Tetsucabra", "Tigerstripe Zamtrios", "Great Izuchi", "Nightcloak Malfestio", "Coral Pukei-Pukei", "Scarred Yian Garuga", "Deadeye Yian Garuga", "Hellblade Glavenus", "Crystalbeard Uragaan", "Plum Daimyo Hermitaur", "Terra Shogun Ceanataur", "Guardian Ebony Odogaron", "Guardian Fulgar Anjanath", "Hallowed Jhen Mohran", "Risen Crimson Glow Valstrax", "Blood Orange Bishaten", "Pyre Rakna-Kadaki", "Chaotic Gore Magala"
        });

        lstMonsterList.Location = new System.Drawing.Point(6, 75);
        lstMonsterList.Name = "lstMonsterList";
        lstMonsterList.Size = new System.Drawing.Size(303, 184);
        lstMonsterList.TabIndex = 1;
        // 
        // txtMonsterListSearch
        // 
        txtMonsterListSearch.Location = new System.Drawing.Point(6, 34);
        txtMonsterListSearch.Name = "txtMonsterListSearch";
        txtMonsterListSearch.Size = new System.Drawing.Size(263, 35);
        txtMonsterListSearch.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btnDecrementCount);
        groupBox1.Controls.Add(btnIncrementCount);
        groupBox1.Controls.Add(txtMonsterCounts);
        groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        groupBox1.Location = new System.Drawing.Point(425, 32);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(200, 154);
        groupBox1.TabIndex = 4;
        groupBox1.TabStop = false;
        groupBox1.Text = "Counts";
        // 
        // btnDecrementCount
        // 
        btnDecrementCount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        btnDecrementCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnDecrementCount.Location = new System.Drawing.Point(114, 93);
        btnDecrementCount.Name = "btnDecrementCount";
        btnDecrementCount.Size = new System.Drawing.Size(80, 40);
        btnDecrementCount.TabIndex = 2;
        btnDecrementCount.Text = "-";
        btnDecrementCount.UseVisualStyleBackColor = false;
        // 
        // btnIncrementCount
        // 
        btnIncrementCount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        btnIncrementCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnIncrementCount.ForeColor = System.Drawing.SystemColors.ButtonFace;
        btnIncrementCount.Location = new System.Drawing.Point(8, 93);
        btnIncrementCount.Name = "btnIncrementCount";
        btnIncrementCount.Size = new System.Drawing.Size(80, 40);
        btnIncrementCount.TabIndex = 1;
        btnIncrementCount.Text = "+";
        btnIncrementCount.UseVisualStyleBackColor = false;
        // 
        // txtMonsterCounts
        // 
        txtMonsterCounts.Location = new System.Drawing.Point(11, 34);
        txtMonsterCounts.MaxLength = 10;
        txtMonsterCounts.Name = "txtMonsterCounts";
        txtMonsterCounts.ReadOnly = true;
        txtMonsterCounts.Size = new System.Drawing.Size(183, 35);
        txtMonsterCounts.TabIndex = 0;
        txtMonsterCounts.WordWrap = false;
        // 
        // groupMonsterList
        // 
        groupMonsterList.Controls.Add(gbMonsterList);
        groupMonsterList.Controls.Add(groupBox1);
        groupMonsterList.Location = new System.Drawing.Point(12, 91);
        groupMonsterList.Name = "groupMonsterList";
        groupMonsterList.Size = new System.Drawing.Size(656, 297);
        groupMonsterList.TabIndex = 5;
        groupMonsterList.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ControlDarkDark;
        ClientSize = new System.Drawing.Size(680, 457);
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
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupMonsterList.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.GroupBox groupMonsterList;

    private System.Windows.Forms.Button btnClear;

    private System.Windows.Forms.Button btnRemove;

    private System.Windows.Forms.Button btnAddToMonsterList;

    private System.Windows.Forms.Button btnDecrementCount;

    private System.Windows.Forms.Button btnIncrementCount;

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtMonsterCounts;

    private System.Windows.Forms.TextBox txtMonsterListSearch;
    private System.Windows.Forms.ListBox lstMonsterList;

    private System.Windows.Forms.GroupBox gbMonsterList;

    private System.Windows.Forms.GroupBox gbGame;

    private System.Windows.Forms.Label lblGameName;

    #endregion
}
