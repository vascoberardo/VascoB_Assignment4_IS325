using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace WinFormsAssignment3;

public partial class MainForm : Form
{
    private const string HANDS_FOLDER = @"C:\Users\Vasco Berardo\source\repos\VascoB-Assignment4-IS325\VascoB-Assignment4-IS325\hands";

    private const string DEFAULT_EXT = "txt";

    private Deck deck;

    private Card[] hand = new Card[5];

    private const int NO_CARD = -1;

    private DeckForm? deckForm;

    public MainForm()
    {
        InitializeComponent();
        deck = new Deck(imglstCards);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        for (int i = 0; i < hand.Length; i++)
        {
            hand[i] = Card.NoCard;
        }

        deck.Shuffle();
        for (int i = 0; i < hand.Length; i++)
        {
            DealCard(i);
        }
        UpdateHandPics();
    }

    private void DealCard(int pos)
    {
        if (pos < 0 || pos >= hand.Length) return;
        hand[pos] = deck.DealCard();
    }

    private bool IsRedraw()
    {
        return chkboxKeep1.Checked ||
            chkboxKeep2.Checked ||
            chkboxKeep3.Checked ||
            chkboxKeep4.Checked ||
            chkboxKeep5.Checked;
    }

    private void dealButton_Click(object sender, EventArgs e)
    {
        if (!IsRedraw())
        {
            deck.Shuffle();
        }

        if (!chkboxKeep1.Checked)
        {
            DealCard(0);
        }

        if (!chkboxKeep2.Checked)
        {
            DealCard(1);
        }

        if (!chkboxKeep3.Checked)
        {
            DealCard(2);
        }

        if (!chkboxKeep4.Checked)
        {
            DealCard(3);
        }

        if (!chkboxKeep5.Checked)
        {
            DealCard(4);
        }

        UpdateHandPics();
        ResetKeepCheckboxes();
    }

    private void ResetKeepCheckboxes()
    {
        chkboxKeep1.Checked = false;
        chkboxKeep2.Checked = false;
        chkboxKeep3.Checked = false;
        chkboxKeep4.Checked = false;
        chkboxKeep5.Checked = false;
    }

    private void UpdateHandPics()
    {
        picCard1.Image = hand[0].CardImage;
        picCard2.Image = hand[1].CardImage;
        picCard3.Image = hand[2].CardImage;
        picCard4.Image = hand[3].CardImage;
        picCard5.Image = hand[4].CardImage;
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        sfdSave.InitialDirectory = HANDS_FOLDER;
        sfdSave.AddExtension = true;
        sfdSave.DefaultExt = DEFAULT_EXT;
        if (sfdSave.ShowDialog() == DialogResult.Cancel) return;

        bool ok = deck.SaveHand(sfdSave.FileName, hand);
        if (!ok) MessageBox.Show("Save failed.");
    }

    private void hand1PictureBox_Click(object sender, EventArgs e)
    {
        chkboxKeep1.Checked = !chkboxKeep1.Checked;
    }

    private void hand2PictureBox_Click(object sender, EventArgs e)
    {
        chkboxKeep2.Checked = !chkboxKeep2.Checked;
    }

    private void hand3PictureBox_Click(object sender, EventArgs e)
    {
        chkboxKeep3.Checked = !chkboxKeep3.Checked;
    }

    private void hand4PictureBox_Click(object sender, EventArgs e)
    {
        chkboxKeep4.Checked = !chkboxKeep4.Checked;
    }

    private void hand5PictureBox_Click(object sender, EventArgs e)
    {
        chkboxKeep5.Checked = !chkboxKeep5.Checked;
    }

    private void loadButton_Click(object sender, EventArgs e)
    {
        ofdLoad.InitialDirectory = HANDS_FOLDER;
        if (ofdLoad.ShowDialog() == DialogResult.Cancel) return;

        bool ok = deck.LoadHand(ofdLoad.FileName, hand);
        if (!ok) MessageBox.Show("Load failed.");
        UpdateHandPics();
    }

    private void btnShowDeck_Click(object sender, EventArgs e)
    {
        if (deckForm == null || deckForm.IsDisposed)
        {
            deckForm = new DeckForm(deck, imglstCards); // ? Pass the shared ImageList
            deckForm.Show(this);
        }
        else if (!deckForm.Visible)
        {
            deckForm = new DeckForm(deck, imglstCards); // ? Pass the shared ImageList
            deckForm.Show(this);
        }
        else
        {
            deckForm.BringToFront();
        }
    }
}
