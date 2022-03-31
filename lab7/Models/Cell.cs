using Avalonia.Media;
using System;

namespace lab7.Models
{
    [Serializable()]
    public class Cell
    {
        string mark;
        public string Mark
        {
            get => mark;
            set
            {
                mark = value;
                switch (value)
                {
                    case "0":
                        Background = Brushes.Red;
                        break;
                    case "1":
                        Background = Brushes.Yellow;
                        break;
                    case "2":
                        Background = Brushes.Green;
                        break;
                    default:
                        mark = "#ERROR";
                        Background = Brushes.White;
                        break;
                }
            }
        }
        [field: NonSerialized()]
        public IBrush Background { get; set; }
        public Cell(string mark)
        {
            Mark = mark;
        }
    }
}
