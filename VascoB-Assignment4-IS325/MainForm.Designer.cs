namespace WinFormsAssignment3;

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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        imglstCards = new ImageList(components);
        picCard1 = new PictureBox();
        btnDeal = new Button();
        picCard5 = new PictureBox();
        picCard4 = new PictureBox();
        picCard3 = new PictureBox();
        picCard2 = new PictureBox();
        chkboxKeep1 = new CheckBox();
        chkboxKeep2 = new CheckBox();
        chkboxKeep3 = new CheckBox();
        chkboxKeep4 = new CheckBox();
        chkboxKeep5 = new CheckBox();
        btnSaveHand = new Button();
        btnLoadHand = new Button();
        ofdLoad = new OpenFileDialog();
        sfdSave = new SaveFileDialog();
        btnShowDeck = new Button();
        ((System.ComponentModel.ISupportInitialize)picCard1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picCard5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picCard4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picCard3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picCard2).BeginInit();
        SuspendLayout();
        // 
        // imglstCards
        // 
        imglstCards.ColorDepth = ColorDepth.Depth32Bit;
        imglstCards.ImageStream = (ImageListStreamer)resources.GetObject("imglstCards.ImageStream");
        imglstCards.TransparentColor = Color.Transparent;
        imglstCards.Images.SetKeyName(0, "Kofclubs.png");
        imglstCards.Images.SetKeyName(1, "Aofclubs.png");
        imglstCards.Images.SetKeyName(2, "2ofclubs.png");
        imglstCards.Images.SetKeyName(3, "3ofclubs.png");
        imglstCards.Images.SetKeyName(4, "4ofclubs.png");
        imglstCards.Images.SetKeyName(5, "5ofclubs.png");
        imglstCards.Images.SetKeyName(6, "6ofclubs.png");
        imglstCards.Images.SetKeyName(7, "7ofclubs.png");
        imglstCards.Images.SetKeyName(8, "8ofclubs.png");
        imglstCards.Images.SetKeyName(9, "9ofclubs.png");
        imglstCards.Images.SetKeyName(10, "10ofclubs.png");
        imglstCards.Images.SetKeyName(11, "Jofclubs.png");
        imglstCards.Images.SetKeyName(12, "Qofclubs.png");
        imglstCards.Images.SetKeyName(13, "Kofdiamonds.png");
        imglstCards.Images.SetKeyName(14, "Aofdiamonds.png");
        imglstCards.Images.SetKeyName(15, "2ofdiamonds.png");
        imglstCards.Images.SetKeyName(16, "3ofdiamonds.png");
        imglstCards.Images.SetKeyName(17, "4ofdiamonds.png");
        imglstCards.Images.SetKeyName(18, "5ofdiamonds.png");
        imglstCards.Images.SetKeyName(19, "6ofdiamonds.png");
        imglstCards.Images.SetKeyName(20, "7ofdiamonds.png");
        imglstCards.Images.SetKeyName(21, "8ofdiamonds.png");
        imglstCards.Images.SetKeyName(22, "9ofdiamonds.png");
        imglstCards.Images.SetKeyName(23, "10ofdiamonds.png");
        imglstCards.Images.SetKeyName(24, "Jofdiamonds.png");
        imglstCards.Images.SetKeyName(25, "Qofdiamonds.png");
        imglstCards.Images.SetKeyName(26, "Kofhearts.png");
        imglstCards.Images.SetKeyName(27, "Aofhearts.png");
        imglstCards.Images.SetKeyName(28, "2ofhearts.png");
        imglstCards.Images.SetKeyName(29, "3ofhearts.png");
        imglstCards.Images.SetKeyName(30, "4ofhearts.png");
        imglstCards.Images.SetKeyName(31, "5ofhearts.png");
        imglstCards.Images.SetKeyName(32, "6ofhearts.png");
        imglstCards.Images.SetKeyName(33, "7ofhearts.png");
        imglstCards.Images.SetKeyName(34, "8ofhearts.png");
        imglstCards.Images.SetKeyName(35, "9ofhearts.png");
        imglstCards.Images.SetKeyName(36, "10ofhearts.png");
        imglstCards.Images.SetKeyName(37, "Jofhearts.png");
        imglstCards.Images.SetKeyName(38, "Qofhearts.png");
        imglstCards.Images.SetKeyName(39, "Kofspades.png");
        imglstCards.Images.SetKeyName(40, "Aofspades.png");
        imglstCards.Images.SetKeyName(41, "2ofspades.png");
        imglstCards.Images.SetKeyName(42, "3ofspades.png");
        imglstCards.Images.SetKeyName(43, "4ofspades.png");
        imglstCards.Images.SetKeyName(44, "5ofspades.png");
        imglstCards.Images.SetKeyName(45, "6ofspades.png");
        imglstCards.Images.SetKeyName(46, "7ofspades.png");
        imglstCards.Images.SetKeyName(47, "8ofspades.png");
        imglstCards.Images.SetKeyName(48, "9ofspades.png");
        imglstCards.Images.SetKeyName(49, "10ofspades.png");
        imglstCards.Images.SetKeyName(50, "Jofspades.png");
        imglstCards.Images.SetKeyName(51, "Qofspades.png");
        // 
        // picCard1
        // 
        picCard1.Location = new Point(49, 143);
        picCard1.Margin = new Padding(3, 2, 3, 2);
        picCard1.Name = "picCard1";
        picCard1.Size = new Size(109, 155);
        picCard1.TabIndex = 2;
        picCard1.TabStop = false;
        picCard1.Click += hand1PictureBox_Click;
        // 
        // btnDeal
        // 
        btnDeal.Location = new Point(49, 29);
        btnDeal.Margin = new Padding(3, 2, 3, 2);
        btnDeal.Name = "btnDeal";
        btnDeal.Size = new Size(109, 43);
        btnDeal.TabIndex = 0;
        btnDeal.Text = "&Deal";
        btnDeal.UseVisualStyleBackColor = true;
        btnDeal.Click += dealButton_Click;
        // 
        // picCard5
        // 
        picCard5.Location = new Point(672, 143);
        picCard5.Margin = new Padding(3, 2, 3, 2);
        picCard5.Name = "picCard5";
        picCard5.Size = new Size(109, 155);
        picCard5.TabIndex = 6;
        picCard5.TabStop = false;
        picCard5.Click += hand5PictureBox_Click;
        // 
        // picCard4
        // 
        picCard4.Location = new Point(516, 143);
        picCard4.Margin = new Padding(3, 2, 3, 2);
        picCard4.Name = "picCard4";
        picCard4.Size = new Size(109, 155);
        picCard4.TabIndex = 7;
        picCard4.TabStop = false;
        picCard4.Click += hand4PictureBox_Click;
        // 
        // picCard3
        // 
        picCard3.Location = new Point(360, 143);
        picCard3.Margin = new Padding(3, 2, 3, 2);
        picCard3.Name = "picCard3";
        picCard3.Size = new Size(109, 155);
        picCard3.TabIndex = 8;
        picCard3.TabStop = false;
        picCard3.Click += hand3PictureBox_Click;
        // 
        // picCard2
        // 
        picCard2.Location = new Point(205, 143);
        picCard2.Margin = new Padding(3, 2, 3, 2);
        picCard2.Name = "picCard2";
        picCard2.Size = new Size(109, 155);
        picCard2.TabIndex = 9;
        picCard2.TabStop = false;
        picCard2.Click += hand2PictureBox_Click;
        // 
        // chkboxKeep1
        // 
        chkboxKeep1.AutoSize = true;
        chkboxKeep1.Location = new Point(49, 115);
        chkboxKeep1.Margin = new Padding(3, 2, 3, 2);
        chkboxKeep1.Name = "chkboxKeep1";
        chkboxKeep1.Size = new Size(61, 19);
        chkboxKeep1.TabIndex = 4;
        chkboxKeep1.Text = "Keep &1";
        chkboxKeep1.UseVisualStyleBackColor = true;
        // 
        // chkboxKeep2
        // 
        chkboxKeep2.AutoSize = true;
        chkboxKeep2.Location = new Point(205, 112);
        chkboxKeep2.Margin = new Padding(3, 2, 3, 2);
        chkboxKeep2.Name = "chkboxKeep2";
        chkboxKeep2.Size = new Size(61, 19);
        chkboxKeep2.TabIndex = 5;
        chkboxKeep2.Text = "Keep &2";
        chkboxKeep2.UseVisualStyleBackColor = true;
        // 
        // chkboxKeep3
        // 
        chkboxKeep3.AutoSize = true;
        chkboxKeep3.Location = new Point(360, 112);
        chkboxKeep3.Margin = new Padding(3, 2, 3, 2);
        chkboxKeep3.Name = "chkboxKeep3";
        chkboxKeep3.Size = new Size(61, 19);
        chkboxKeep3.TabIndex = 6;
        chkboxKeep3.Text = "Keep &3";
        chkboxKeep3.UseVisualStyleBackColor = true;
        // 
        // chkboxKeep4
        // 
        chkboxKeep4.AutoSize = true;
        chkboxKeep4.Location = new Point(516, 112);
        chkboxKeep4.Margin = new Padding(3, 2, 3, 2);
        chkboxKeep4.Name = "chkboxKeep4";
        chkboxKeep4.Size = new Size(61, 19);
        chkboxKeep4.TabIndex = 7;
        chkboxKeep4.Text = "Keep &4";
        chkboxKeep4.UseVisualStyleBackColor = true;
        // 
        // chkboxKeep5
        // 
        chkboxKeep5.AutoSize = true;
        chkboxKeep5.Location = new Point(672, 112);
        chkboxKeep5.Margin = new Padding(3, 2, 3, 2);
        chkboxKeep5.Name = "chkboxKeep5";
        chkboxKeep5.Size = new Size(61, 19);
        chkboxKeep5.TabIndex = 8;
        chkboxKeep5.Text = "Keep &5";
        chkboxKeep5.UseVisualStyleBackColor = true;
        // 
        // btnSaveHand
        // 
        btnSaveHand.Location = new Point(360, 29);
        btnSaveHand.Margin = new Padding(3, 2, 3, 2);
        btnSaveHand.Name = "btnSaveHand";
        btnSaveHand.Size = new Size(109, 43);
        btnSaveHand.TabIndex = 2;
        btnSaveHand.Text = "&Save Hand";
        btnSaveHand.UseVisualStyleBackColor = true;
        btnSaveHand.Click += saveButton_Click;
        // 
        // btnLoadHand
        // 
        btnLoadHand.Location = new Point(516, 29);
        btnLoadHand.Margin = new Padding(3, 2, 3, 2);
        btnLoadHand.Name = "btnLoadHand";
        btnLoadHand.Size = new Size(109, 43);
        btnLoadHand.TabIndex = 3;
        btnLoadHand.Text = "&Load Hand";
        btnLoadHand.UseVisualStyleBackColor = true;
        btnLoadHand.Click += loadButton_Click;
        // 
        // ofdLoad
        // 
        ofdLoad.FileName = "openFileDialog1";
        // 
        // btnShowDeck
        // 
        btnShowDeck.Location = new Point(672, 29);
        btnShowDeck.Margin = new Padding(3, 2, 3, 2);
        btnShowDeck.Name = "btnShowDeck";
        btnShowDeck.Size = new Size(109, 43);
        btnShowDeck.TabIndex = 10;
        btnShowDeck.Text = "S&how Deck";
        btnShowDeck.UseVisualStyleBackColor = true;
        btnShowDeck.Click += btnShowDeck_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(833, 358);
        Controls.Add(btnShowDeck);
        Controls.Add(btnLoadHand);
        Controls.Add(btnSaveHand);
        Controls.Add(chkboxKeep5);
        Controls.Add(chkboxKeep4);
        Controls.Add(chkboxKeep3);
        Controls.Add(chkboxKeep2);
        Controls.Add(chkboxKeep1);
        Controls.Add(picCard2);
        Controls.Add(picCard3);
        Controls.Add(picCard4);
        Controls.Add(picCard5);
        Controls.Add(btnDeal);
        Controls.Add(picCard1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 2, 3, 2);
        MaximizeBox = false;
        Name = "MainForm";
        Text = "Poker Hand Simulator";
        Load += MainForm_Load;
        ((System.ComponentModel.ISupportInitialize)picCard1).EndInit();
        ((System.ComponentModel.ISupportInitialize)picCard5).EndInit();
        ((System.ComponentModel.ISupportInitialize)picCard4).EndInit();
        ((System.ComponentModel.ISupportInitialize)picCard3).EndInit();
        ((System.ComponentModel.ISupportInitialize)picCard2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private ImageList imglstCards;
    private PictureBox picCard1;
    private Button btnDeal;
    private PictureBox picCard5;
    private PictureBox picCard4;
    private PictureBox picCard3;
    private PictureBox picCard2;
    private CheckBox chkboxKeep1;
    private CheckBox chkboxKeep2;
    private CheckBox chkboxKeep3;
    private CheckBox chkboxKeep4;
    private CheckBox chkboxKeep5;
    private Button btnSaveHand;
    private Button btnLoadHand;
    private OpenFileDialog ofdLoad;
    private SaveFileDialog sfdSave;
    private Button btnShowDeck;
}
