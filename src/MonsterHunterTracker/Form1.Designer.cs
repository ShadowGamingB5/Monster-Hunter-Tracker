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
        gbGame.SuspendLayout();
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
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ControlDarkDark;
        ClientSize = new System.Drawing.Size(680, 457);
        Controls.Add(gbGame);
        Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        ForeColor = System.Drawing.SystemColors.ControlLightLight;
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        MaximizeBox = false;
        Text = "Monster Hunter Tracker";
        gbGame.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.GroupBox gbGame;

    private System.Windows.Forms.Label lblGameName;

    #endregion
}
