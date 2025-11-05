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
        cardsImageList = new ImageList(components);
        hand1PictureBox = new PictureBox();
        dealButton = new Button();
        hand5PictureBox = new PictureBox();
        hand4PictureBox = new PictureBox();
        hand3PictureBox = new PictureBox();
        hand2PictureBox = new PictureBox();
        keep1CheckBox = new CheckBox();
        keep2CheckBox = new CheckBox();
        keep3CheckBox = new CheckBox();
        keep4CheckBox = new CheckBox();
        keep5CheckBox = new CheckBox();
        saveButton = new Button();
        loadButton = new Button();
        openFileDialog = new OpenFileDialog();
        saveFileDialog = new SaveFileDialog();
        ((System.ComponentModel.ISupportInitialize)hand1PictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)hand5PictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)hand4PictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)hand3PictureBox).BeginInit();
        ((System.ComponentModel.ISupportInitialize)hand2PictureBox).BeginInit();
        SuspendLayout();
        // 
        // cardsImageList
        // 
        cardsImageList.ColorDepth = ColorDepth.Depth32Bit;
        cardsImageList.ImageStream = (ImageListStreamer)resources.GetObject("cardsImageList.ImageStream");
        cardsImageList.TransparentColor = Color.Transparent;
        cardsImageList.Images.SetKeyName(0, "p0.png");
        cardsImageList.Images.SetKeyName(1, "p1.png");
        cardsImageList.Images.SetKeyName(2, "p2.png");
        cardsImageList.Images.SetKeyName(3, "p3.png");
        cardsImageList.Images.SetKeyName(4, "p4.png");
        cardsImageList.Images.SetKeyName(5, "p5.png");
        cardsImageList.Images.SetKeyName(6, "p6.png");
        cardsImageList.Images.SetKeyName(7, "p7.png");
        cardsImageList.Images.SetKeyName(8, "p8.png");
        cardsImageList.Images.SetKeyName(9, "p9.png");
        cardsImageList.Images.SetKeyName(10, "p10.png");
        cardsImageList.Images.SetKeyName(11, "p11.png");
        cardsImageList.Images.SetKeyName(12, "p12.png");
        cardsImageList.Images.SetKeyName(13, "p13.png");
        cardsImageList.Images.SetKeyName(14, "p14.png");
        cardsImageList.Images.SetKeyName(15, "p15.png");
        cardsImageList.Images.SetKeyName(16, "p16.png");
        cardsImageList.Images.SetKeyName(17, "p17.png");
        cardsImageList.Images.SetKeyName(18, "p18.png");
        cardsImageList.Images.SetKeyName(19, "p19.png");
        cardsImageList.Images.SetKeyName(20, "p20.png");
        cardsImageList.Images.SetKeyName(21, "p21.png");
        cardsImageList.Images.SetKeyName(22, "p22.png");
        cardsImageList.Images.SetKeyName(23, "p23.png");
        cardsImageList.Images.SetKeyName(24, "p24.png");
        cardsImageList.Images.SetKeyName(25, "p25.png");
        cardsImageList.Images.SetKeyName(26, "p26.png");
        cardsImageList.Images.SetKeyName(27, "p27.png");
        cardsImageList.Images.SetKeyName(28, "p28.png");
        cardsImageList.Images.SetKeyName(29, "p29.png");
        cardsImageList.Images.SetKeyName(30, "p30.png");
        cardsImageList.Images.SetKeyName(31, "p31.png");
        cardsImageList.Images.SetKeyName(32, "p32.png");
        cardsImageList.Images.SetKeyName(33, "p33.png");
        cardsImageList.Images.SetKeyName(34, "p34.png");
        cardsImageList.Images.SetKeyName(35, "p35.png");
        cardsImageList.Images.SetKeyName(36, "p36.png");
        cardsImageList.Images.SetKeyName(37, "p37.png");
        cardsImageList.Images.SetKeyName(38, "p38.png");
        cardsImageList.Images.SetKeyName(39, "p39.png");
        cardsImageList.Images.SetKeyName(40, "p40.png");
        cardsImageList.Images.SetKeyName(41, "p41.png");
        cardsImageList.Images.SetKeyName(42, "p42.png");
        cardsImageList.Images.SetKeyName(43, "p43.png");
        cardsImageList.Images.SetKeyName(44, "p44.png");
        cardsImageList.Images.SetKeyName(45, "p45.png");
        cardsImageList.Images.SetKeyName(46, "p46.png");
        cardsImageList.Images.SetKeyName(47, "p47.png");
        cardsImageList.Images.SetKeyName(48, "p48.png");
        cardsImageList.Images.SetKeyName(49, "p49.png");
        cardsImageList.Images.SetKeyName(50, "p50.png");
        cardsImageList.Images.SetKeyName(51, "p51.png");
        // 
        // hand1PictureBox
        // 
        hand1PictureBox.Location = new Point(56, 191);
        hand1PictureBox.Name = "hand1PictureBox";
        hand1PictureBox.Size = new Size(125, 207);
        hand1PictureBox.TabIndex = 2;
        hand1PictureBox.TabStop = false;
        hand1PictureBox.Click += hand1PictureBox_Click;
        // 
        // dealButton
        // 
        dealButton.Location = new Point(56, 39);
        dealButton.Name = "dealButton";
        dealButton.Size = new Size(125, 57);
        dealButton.TabIndex = 0;
        dealButton.Text = "&Deal";
        dealButton.UseVisualStyleBackColor = true;
        dealButton.Click += dealButton_Click;
        // 
        // hand5PictureBox
        // 
        hand5PictureBox.Location = new Point(768, 191);
        hand5PictureBox.Name = "hand5PictureBox";
        hand5PictureBox.Size = new Size(125, 207);
        hand5PictureBox.TabIndex = 6;
        hand5PictureBox.TabStop = false;
        hand5PictureBox.Click += hand5PictureBox_Click;
        // 
        // hand4PictureBox
        // 
        hand4PictureBox.Location = new Point(590, 191);
        hand4PictureBox.Name = "hand4PictureBox";
        hand4PictureBox.Size = new Size(125, 207);
        hand4PictureBox.TabIndex = 7;
        hand4PictureBox.TabStop = false;
        hand4PictureBox.Click += hand4PictureBox_Click;
        // 
        // hand3PictureBox
        // 
        hand3PictureBox.Location = new Point(412, 191);
        hand3PictureBox.Name = "hand3PictureBox";
        hand3PictureBox.Size = new Size(125, 207);
        hand3PictureBox.TabIndex = 8;
        hand3PictureBox.TabStop = false;
        hand3PictureBox.Click += hand3PictureBox_Click;
        // 
        // hand2PictureBox
        // 
        hand2PictureBox.Location = new Point(234, 191);
        hand2PictureBox.Name = "hand2PictureBox";
        hand2PictureBox.Size = new Size(125, 207);
        hand2PictureBox.TabIndex = 9;
        hand2PictureBox.TabStop = false;
        hand2PictureBox.Click += hand2PictureBox_Click;
        // 
        // keep1CheckBox
        // 
        keep1CheckBox.AutoSize = true;
        keep1CheckBox.Location = new Point(56, 153);
        keep1CheckBox.Name = "keep1CheckBox";
        keep1CheckBox.Size = new Size(77, 24);
        keep1CheckBox.TabIndex = 4;
        keep1CheckBox.Text = "Keep &1";
        keep1CheckBox.UseVisualStyleBackColor = true;
        // 
        // keep2CheckBox
        // 
        keep2CheckBox.AutoSize = true;
        keep2CheckBox.Location = new Point(234, 149);
        keep2CheckBox.Name = "keep2CheckBox";
        keep2CheckBox.Size = new Size(77, 24);
        keep2CheckBox.TabIndex = 5;
        keep2CheckBox.Text = "Keep &2";
        keep2CheckBox.UseVisualStyleBackColor = true;
        // 
        // keep3CheckBox
        // 
        keep3CheckBox.AutoSize = true;
        keep3CheckBox.Location = new Point(412, 149);
        keep3CheckBox.Name = "keep3CheckBox";
        keep3CheckBox.Size = new Size(77, 24);
        keep3CheckBox.TabIndex = 6;
        keep3CheckBox.Text = "Keep &3";
        keep3CheckBox.UseVisualStyleBackColor = true;
        // 
        // keep4CheckBox
        // 
        keep4CheckBox.AutoSize = true;
        keep4CheckBox.Location = new Point(590, 149);
        keep4CheckBox.Name = "keep4CheckBox";
        keep4CheckBox.Size = new Size(77, 24);
        keep4CheckBox.TabIndex = 7;
        keep4CheckBox.Text = "Keep &4";
        keep4CheckBox.UseVisualStyleBackColor = true;
        // 
        // keep5CheckBox
        // 
        keep5CheckBox.AutoSize = true;
        keep5CheckBox.Location = new Point(768, 149);
        keep5CheckBox.Name = "keep5CheckBox";
        keep5CheckBox.Size = new Size(77, 24);
        keep5CheckBox.TabIndex = 8;
        keep5CheckBox.Text = "Keep &5";
        keep5CheckBox.UseVisualStyleBackColor = true;
        // 
        // saveButton
        // 
        saveButton.Location = new Point(590, 39);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(125, 57);
        saveButton.TabIndex = 2;
        saveButton.Text = "&Save Hand";
        saveButton.UseVisualStyleBackColor = true;
        saveButton.Click += saveButton_Click;
        // 
        // loadButton
        // 
        loadButton.Location = new Point(768, 39);
        loadButton.Name = "loadButton";
        loadButton.Size = new Size(125, 57);
        loadButton.TabIndex = 3;
        loadButton.Text = "&Load Hand";
        loadButton.UseVisualStyleBackColor = true;
        loadButton.Click += loadButton_Click;
        // 
        // openFileDialog
        // 
        openFileDialog.FileName = "openFileDialog1";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(952, 478);
        Controls.Add(loadButton);
        Controls.Add(saveButton);
        Controls.Add(keep5CheckBox);
        Controls.Add(keep4CheckBox);
        Controls.Add(keep3CheckBox);
        Controls.Add(keep2CheckBox);
        Controls.Add(keep1CheckBox);
        Controls.Add(hand2PictureBox);
        Controls.Add(hand3PictureBox);
        Controls.Add(hand4PictureBox);
        Controls.Add(hand5PictureBox);
        Controls.Add(dealButton);
        Controls.Add(hand1PictureBox);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "MainForm";
        Text = "Poker Hand Simulator";
        Load += MainForm_Load;
        ((System.ComponentModel.ISupportInitialize)hand1PictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)hand5PictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)hand4PictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)hand3PictureBox).EndInit();
        ((System.ComponentModel.ISupportInitialize)hand2PictureBox).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private ImageList cardsImageList;
    private PictureBox hand1PictureBox;
    private Button dealButton;
    private PictureBox hand5PictureBox;
    private PictureBox hand4PictureBox;
    private PictureBox hand3PictureBox;
    private PictureBox hand2PictureBox;
    private CheckBox keep1CheckBox;
    private CheckBox keep2CheckBox;
    private CheckBox keep3CheckBox;
    private CheckBox keep4CheckBox;
    private CheckBox keep5CheckBox;
    private Button saveButton;
    private Button loadButton;
    private OpenFileDialog openFileDialog;
    private SaveFileDialog saveFileDialog;
}
