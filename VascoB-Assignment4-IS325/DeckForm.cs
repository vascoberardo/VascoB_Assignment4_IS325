using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsAssignment3
{
    public partial class DeckForm : Form
    {
        private readonly Deck? deck;

        public DeckForm()
        {
            InitializeComponent();
        }

        public DeckForm(Deck deck) : this()
        {
            this.deck = deck;
            this.Load += DeckForm_Load;
            this.lstboxDeck.SelectedIndexChanged += lstboxDeck_SelectedIndexChanged;
        }

        private void DeckForm_Load(object? sender, EventArgs e)
        {
            UpdateDeck();
        }

        public void UpdateDeck()
        {
            if (deck == null) return;

            lstboxDeck.Items.Clear();
            for (int i = 0; i < deck.Count; i++)
            {
                lstboxDeck.Items.Add(deck.GetCard(i));
            }
        }

        private void lstboxDeck_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Card? card = lstboxDeck.SelectedItem as Card;
            picCard.Image = card?.CardImage;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int idx = lstboxDeck.SelectedIndex;
            if (idx <= 0) return; 
            int newIndex = idx - 1;

            deck?.SwapCards(idx, newIndex);
            UpdateDeck();
            lstboxDeck.SetSelected(newIndex, true);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int idx = lstboxDeck.SelectedIndex;
            if (deck == null || idx < 0 || idx >= deck.Count - 1) return;
            int newIndex = idx + 1;

            deck.SwapCards(idx, newIndex);
            UpdateDeck();
            lstboxDeck.SetSelected(newIndex, true);
        }
    }
}