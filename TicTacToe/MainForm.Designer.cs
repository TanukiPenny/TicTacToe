namespace TicTacToe;

partial class MainForm
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
        TitleLabel = new Label();
        button_1_0 = new Button();
        button_1_1 = new Button();
        button_1_2 = new Button();
        button_2_2 = new Button();
        button_2_1 = new Button();
        button_2_0 = new Button();
        button_0_2 = new Button();
        button_0_1 = new Button();
        button_0_0 = new Button();
        TurnLabel = new Label();
        SuspendLayout();
        // 
        // TitleLabel
        // 
        TitleLabel.Anchor = AnchorStyles.None;
        TitleLabel.Font = new Font("Calibri", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
        TitleLabel.Location = new Point(52, -3);
        TitleLabel.Margin = new Padding(0);
        TitleLabel.Name = "TitleLabel";
        TitleLabel.Size = new Size(130, 31);
        TitleLabel.TabIndex = 1;
        TitleLabel.Text = "TicTacToe";
        // 
        // button_1_0
        // 
        button_1_0.Anchor = AnchorStyles.None;
        button_1_0.Font = new Font("MS Reference Sans Serif", 26.25F, FontStyle.Bold);
        button_1_0.Location = new Point(92, 46);
        button_1_0.Name = "button_1_0";
        button_1_0.Size = new Size(50, 50);
        button_1_0.TabIndex = 0;
        button_1_0.Text = "_";
        button_1_0.Click += button_1_0_Click;
        // 
        // button_1_1
        // 
        button_1_1.Anchor = AnchorStyles.None;
        button_1_1.Font = new Font("MS Reference Sans Serif", 26.25F, FontStyle.Bold);
        button_1_1.Location = new Point(92, 101);
        button_1_1.Name = "button_1_1";
        button_1_1.Size = new Size(50, 50);
        button_1_1.TabIndex = 2;
        button_1_1.Text = "_";
        button_1_1.Click += button_1_1_Click;
        // 
        // button_1_2
        // 
        button_1_2.Anchor = AnchorStyles.None;
        button_1_2.Font = new Font("MS Reference Sans Serif", 26.25F, FontStyle.Bold);
        button_1_2.Location = new Point(92, 156);
        button_1_2.Name = "button_1_2";
        button_1_2.Size = new Size(50, 50);
        button_1_2.TabIndex = 3;
        button_1_2.Text = "_";
        button_1_2.Click += button_1_2_Click;
        // 
        // button_2_2
        // 
        button_2_2.Anchor = AnchorStyles.None;
        button_2_2.Font = new Font("MS Reference Sans Serif", 26.25F, FontStyle.Bold);
        button_2_2.Location = new Point(147, 156);
        button_2_2.Name = "button_2_2";
        button_2_2.Size = new Size(50, 50);
        button_2_2.TabIndex = 6;
        button_2_2.Text = "_";
        button_2_2.Click += button_2_2_Click;
        // 
        // button_2_1
        // 
        button_2_1.Anchor = AnchorStyles.None;
        button_2_1.Font = new Font("MS Reference Sans Serif", 26.25F, FontStyle.Bold);
        button_2_1.Location = new Point(147, 101);
        button_2_1.Name = "button_2_1";
        button_2_1.Size = new Size(50, 50);
        button_2_1.TabIndex = 5;
        button_2_1.Text = "_";
        button_2_1.Click += button_2_1_Click;
        // 
        // button_2_0
        // 
        button_2_0.Anchor = AnchorStyles.None;
        button_2_0.Font = new Font("MS Reference Sans Serif", 26.25F, FontStyle.Bold);
        button_2_0.Location = new Point(147, 46);
        button_2_0.Name = "button_2_0";
        button_2_0.Size = new Size(50, 50);
        button_2_0.TabIndex = 4;
        button_2_0.Text = "_";
        button_2_0.Click += button_2_0_Click;
        // 
        // button_0_2
        // 
        button_0_2.Anchor = AnchorStyles.None;
        button_0_2.Font = new Font("MS Reference Sans Serif", 26.25F, FontStyle.Bold);
        button_0_2.Location = new Point(37, 156);
        button_0_2.Name = "button_0_2";
        button_0_2.Size = new Size(50, 50);
        button_0_2.TabIndex = 9;
        button_0_2.Text = "_";
        button_0_2.Click += button_0_2_Click;
        // 
        // button_0_1
        // 
        button_0_1.Anchor = AnchorStyles.None;
        button_0_1.Font = new Font("MS Reference Sans Serif", 26.25F, FontStyle.Bold);
        button_0_1.Location = new Point(37, 101);
        button_0_1.Name = "button_0_1";
        button_0_1.Size = new Size(50, 50);
        button_0_1.TabIndex = 8;
        button_0_1.Text = "_";
        button_0_1.Click += button_0_1_Click;
        // 
        // button_0_0
        // 
        button_0_0.Anchor = AnchorStyles.None;
        button_0_0.Font = new Font("MS Reference Sans Serif", 26.25F, FontStyle.Bold);
        button_0_0.Location = new Point(37, 46);
        button_0_0.Name = "button_0_0";
        button_0_0.Size = new Size(50, 50);
        button_0_0.TabIndex = 7;
        button_0_0.Text = "_";
        button_0_0.Click += button_0_0_Click;
        // 
        // TurnLabel
        // 
        TurnLabel.Anchor = AnchorStyles.None;
        TurnLabel.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TurnLabel.Location = new Point(67, 28);
        TurnLabel.Name = "TurnLabel";
        TurnLabel.Size = new Size(100, 15);
        TurnLabel.TabIndex = 10;
        TurnLabel.Text = "Turn: X";
        TurnLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(234, 211);
        Controls.Add(TurnLabel);
        Controls.Add(button_0_2);
        Controls.Add(button_0_1);
        Controls.Add(button_0_0);
        Controls.Add(button_2_2);
        Controls.Add(button_2_1);
        Controls.Add(button_2_0);
        Controls.Add(button_1_2);
        Controls.Add(button_1_1);
        Controls.Add(button_1_0);
        Controls.Add(TitleLabel);
        MaximumSize = new Size(250, 250);
        MinimumSize = new Size(250, 250);
        Name = "MainForm";
        Text = "TicTacToe";
        ResumeLayout(false);
    }

    #endregion

    private Label TitleLabel;
    private Button button_1_0;
    private Button button_1_1;
    private Button button_1_2;
    private Button button_2_2;
    private Button button_2_1;
    private Button button_2_0;
    private Button button_0_2;
    private Button button_0_1;
    private Button button_0_0;
    private Label TurnLabel;
}