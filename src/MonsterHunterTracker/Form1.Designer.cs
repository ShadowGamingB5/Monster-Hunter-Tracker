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
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(22, 24);
        label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(121, 34);
        label1.TabIndex = 0;
        label1.Text = "Game";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ControlDarkDark;
        ClientSize = new System.Drawing.Size(1323, 882);
        Controls.Add(label1);
        Font = new System.Drawing.Font("Segoe UI", 12F);
        ForeColor = System.Drawing.SystemColors.ControlLightLight;
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        Margin = new System.Windows.Forms.Padding(4);
        MaximizeBox = false;
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;

    #endregion
}