using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace WinFormsAssignment3;

public partial class MainForm : Form
{
    private const string HANDS_FOLDER = @"C:\Users\bray_\source\repos\2024 fall c sharp class\WinFormsAssignment3\WinFormsAssignment3\hands\";

    private const string DEFAULT_EXT = "txt";

    private List<int> deck = new List<int>();

    private int[] hand = new int[5];

    private const int NO_CARD = -1;

    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        // starting hand
        ReshuffleDeck();
        for (int i = 0; i < hand.Length; i++)
        {
            DealCard(i);
        }
        UpdateHandPics();
    }

    private void DealCard(int pos)
    {
        if (pos < 0)
        {
            return;
        }

        if (pos >= hand.Length)
        {
            return;
        }

        hand[pos] = deck[0];
        deck.RemoveAt(0);
    }

    private void ReshuffleDeck()
    {
        deck.Clear();

        // load deck from image list
        for (int i = 0; i < cardsImageList.Images.Count; i++)
        {
            deck.Add(i);
        }

        // shuffle it
        Random rng = new Random();
        int n = deck.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            int value = deck[k];
            deck[k] = deck[n];
            deck[n] = value;
        }
    }

    private bool IsRedraw()
    {
        return keep1CheckBox.Checked ||
            keep2CheckBox.Checked ||
            keep3CheckBox.Checked ||
            keep4CheckBox.Checked ||
            keep5CheckBox.Checked;
    }

    private void dealButton_Click(object sender, EventArgs e)
    {
        // if we aren't redrawing reshuffle the deck to start fresh
        if (!IsRedraw())
        {
            ReshuffleDeck();
        }

        // deal out the cards
        if (!keep1CheckBox.Checked)
        {
            DealCard(0);
        }

        if (!keep2CheckBox.Checked)
        {
            DealCard(1);
        }

        if (!keep3CheckBox.Checked)
        {
            DealCard(2);
        }

        if (!keep4CheckBox.Checked)
        {
            DealCard(3);
        }

        if (!keep5CheckBox.Checked)
        {
            DealCard(4);
        }

        UpdateHandPics();
        ResetKeepCheckboxes();
    }

    private void ResetKeepCheckboxes()
    {
        keep1CheckBox.Checked = false;
        keep2CheckBox.Checked = false;
        keep3CheckBox.Checked = false;
        keep4CheckBox.Checked = false;
        keep5CheckBox.Checked = false;
    }

    private void UpdateHandPics()
    {
        hand1PictureBox.Image = null;
        if ((hand[0] > NO_CARD) && (hand[0] < cardsImageList.Images.Count))
        {
            hand1PictureBox.Image = cardsImageList.Images[hand[0]];
        }

        hand2PictureBox.Image = null;
        if ((hand[1] > NO_CARD) && (hand[1] < cardsImageList.Images.Count))
        {
            hand2PictureBox.Image = cardsImageList.Images[hand[1]];
        }

        hand3PictureBox.Image = null;
        if ((hand[2] > NO_CARD) && (hand[2] < cardsImageList.Images.Count))
        {
            hand3PictureBox.Image = cardsImageList.Images[hand[2]];
        }

        hand4PictureBox.Image = null;
        if ((hand[3] > NO_CARD) && (hand[3] < cardsImageList.Images.Count))
        {
            hand4PictureBox.Image = cardsImageList.Images[hand[3]];
        }

        hand5PictureBox.Image = null;
        if ((hand[4] > NO_CARD) && (hand[4] < cardsImageList.Images.Count))
        {
            hand5PictureBox.Image = cardsImageList.Images[hand[4]];
        }
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        saveFileDialog.InitialDirectory = HANDS_FOLDER;
        saveFileDialog.AddExtension = true;
        saveFileDialog.DefaultExt = DEFAULT_EXT;
        if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
        {
            return;
        }

        try
        {
            using (StreamWriter writer = new(saveFileDialog.FileName))
            {
                foreach (int card in hand)
                {
                    writer.WriteLine(card);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void hand1PictureBox_Click(object sender, EventArgs e)
    {
        keep1CheckBox.Checked = !keep1CheckBox.Checked;
    }

    private void hand2PictureBox_Click(object sender, EventArgs e)
    {
        keep2CheckBox.Checked = !keep2CheckBox.Checked;
    }

    private void hand3PictureBox_Click(object sender, EventArgs e)
    {
        keep3CheckBox.Checked = !keep3CheckBox.Checked;
    }

    private void hand4PictureBox_Click(object sender, EventArgs e)
    {
        keep4CheckBox.Checked = !keep4CheckBox.Checked;
    }

    private void hand5PictureBox_Click(object sender, EventArgs e)
    {
        keep5CheckBox.Checked = !keep5CheckBox.Checked;
    }

    private void loadButton_Click(object sender, EventArgs e)
    {
        openFileDialog.InitialDirectory = HANDS_FOLDER;
        if (openFileDialog.ShowDialog() == DialogResult.Cancel)
        {
            return;
        }

        try
        {
            using (StreamReader reader = new(openFileDialog.FileName))
            {
                for (int i = 0; i < hand.Length; i++)
                {
                    hand[i] = NO_CARD;
                    string? line = reader.ReadLine();
                    int card;
                    if (int.TryParse(line, out card))
                    {
                        hand[i] = card;
                    }
                }
            }
            UpdateHandPics();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
