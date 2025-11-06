namespace WinFormsAssignment3
{
    partial class DeckForm
{

    private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            lblCards = new Label();
            lstboxDeck = new ListBox();
            picCard = new PictureBox();
            btnUp = new Button();
            btnDown = new Button();
            ((System.ComponentModel.ISupportInitialize)picCard).BeginInit();
            SuspendLayout();
            // 
            // lblCards
            // 
            lblCards.AutoSize = true;
            lblCards.Location = new Point(114, 123);
            lblCards.Name = "lblCards";
            lblCards.Size = new Size(37, 15);
            lblCards.TabIndex = 0;
            lblCards.Text = "&Cards";
            // 
            // lstboxDeck
            // 
            lstboxDeck.FormattingEnabled = true;
            lstboxDeck.ItemHeight = 15;
            lstboxDeck.Location = new Point(114, 141);
            lstboxDeck.Name = "lstboxDeck";
            lstboxDeck.Size = new Size(120, 199);
            lstboxDeck.TabIndex = 1;
            lstboxDeck.SelectedIndexChanged += lstboxDeck_SelectedIndexChanged;
            // 
            // picCard
            // 
            picCard.Location = new Point(240, 141);
            picCard.Name = "picCard";
            picCard.Size = new Size(139, 199);
            picCard.SizeMode = PictureBoxSizeMode.Zoom;
            picCard.TabIndex = 2;
            picCard.TabStop = false;
            // 
            // btnUp
            // 
            btnUp.Location = new Point(404, 141);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(75, 23);
            btnUp.TabIndex = 3;
            btnUp.Text = "&Up";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(404, 170);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(75, 23);
            btnDown.TabIndex = 4;
            btnDown.Text = "&Down";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // DeckForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDown);
            Controls.Add(btnUp);
            Controls.Add(picCard);
            Controls.Add(lstboxDeck);
            Controls.Add(lblCards);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeckForm";
            Text = "Deck";
            ((System.ComponentModel.ISupportInitialize)picCard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lblCards;
        private ListBox lstboxDeck;
        private PictureBox picCard;
        private Button btnUp;
        private Button btnDown;
    }
}