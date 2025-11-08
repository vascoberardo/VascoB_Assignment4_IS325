using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsAssignment3
{
    public partial class DeckForm : Form
    {
        private readonly Deck? _deck;

        private readonly ImageList _imglstCards;

        public DeckForm(Deck deck, ImageList imglstCards)
        {
            _deck = deck;
            _imglstCards = imglstCards;

            InitializeComponent();
            UpdateDeck();
        }

        private void DeckForm_Load(object? sender, EventArgs e)
        {
            for (int i = 0; i < _imglstCards.Images.Count; i++)
            {
                Image img = _imglstCards.Images[i];
                string name = _imglstCards.Images.Keys[i]; 
                _deck?.AddCard(new Card(i, img, name));
            }

            UpdateDeck();
        }

        public void UpdateDeck()
        {
            if (_deck == null) return;

            lstboxDeck.Items.Clear();
            for (int i = 0; i < _deck.Count; i++)
            {
                lstboxDeck.Items.Add(_deck.GetCard(i));
            }
        }

        private void lstboxDeck_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Card? card = lstboxDeck.SelectedItem as Card;
            picCard.Image = card?.CardImage;
            lstboxDeck.Text = card?.Name ?? string.Empty;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int idx = lstboxDeck.SelectedIndex;
            if (idx <= 0) return;
            int newIndex = idx - 1;

            _deck?.SwapCards(idx, newIndex);
            UpdateDeck();
            lstboxDeck.SetSelected(newIndex, true);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int idx = lstboxDeck.SelectedIndex;
            if (_deck == null || idx < 0 || idx >= _deck.Count - 1) return;
            int newIndex = idx + 1;

            _deck.SwapCards(idx, newIndex);
            UpdateDeck();
            lstboxDeck.SetSelected(newIndex, true);
        }
    }
}