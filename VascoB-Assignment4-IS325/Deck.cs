using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WinFormsAssignment3
{
    public class Deck
    {
        private readonly List<Card> cards = new List<Card>();
        private readonly ImageList imageList;

        public Deck(ImageList imageList)
        {
            this.imageList = imageList;
            Shuffle();
        }

        public void Shuffle()
        {
            cards.Clear();
            for (int i = 0; i < imageList.Images.Count; i++)
            {
                Image? img = imageList.Images[i];
                cards.Add(new Card(i, img));
            }

            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card tmp = cards[k];
                cards[k] = cards[n];
                cards[n] = tmp;
            }
        }

        public Card DealCard()
        {
            if (cards.Count == 0) return Card.NoCard;
            Card c = cards[0];
            cards.RemoveAt(0);
            return c;
        }

        public bool SaveHand(string filename, Card[] hand)
        {
            try
            {
                using StreamWriter writer = new StreamWriter(filename);
                foreach (var c in hand)
                {
                    int id = c?.Id ?? -1;
                    writer.WriteLine(id);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool LoadHand(string filename, Card[] hand)
        {
            try
            {
                using StreamReader reader = new StreamReader(filename);
                for (int i = 0; i < hand.Length; i++)
                {
                    string? line = reader.ReadLine();
                    if (int.TryParse(line, out int id) && id >= 0 && id < imageList.Images.Count)
                    {
                        hand[i] = new Card(id, imageList.Images[id]);
                    }
                    else
                    {
                        hand[i] = Card.NoCard;
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int Count => cards.Count;

        public Card GetCard(int index)
        {
            if (index < 0 || index >= cards.Count) return Card.NoCard;
            return cards[index];
        }

        public void SwapCards(int index1, int index2)
        {
            if (index1 < 0 || index1 >= cards.Count) return;
            if (index2 < 0 || index2 >= cards.Count) return;
            Card tmp = cards[index1];
            cards[index1] = cards[index2];
            cards[index2] = tmp;
        }
    }
}