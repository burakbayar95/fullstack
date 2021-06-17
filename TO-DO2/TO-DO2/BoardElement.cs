using System;
using System.Collections.Generic;
using System.Text;

namespace TO_DO2
{
    class BoardElement
    {
        public Card Card { get; set; }

        public BoardElement(Card card)
        {
            this.Card = card;
            
        }
        public BoardElement()
        {

        }

        public List<BoardElement> BoardElements { get; set; }

    }
}
