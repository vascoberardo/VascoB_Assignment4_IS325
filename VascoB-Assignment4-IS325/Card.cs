using System.Drawing;

namespace WinFormsAssignment3
{
    public class Card
    {
        public int Id { get; }
        public Image? CardImage { get; }
        public string Name { get; }

        public Card(int id, Image? image, string name = "")
        {
            Id = id;
            CardImage = image;
            Name = name ?? "";
        }

        public static readonly Card NoCard = new Card(-1, null, "No Card");

        public override string ToString()
        {
            return string.IsNullOrEmpty(Name) ? Id.ToString() : Name;
        }
    }
}
