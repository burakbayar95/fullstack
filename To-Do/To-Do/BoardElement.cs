using System;
using System.Collections.Generic;
using System.Text;

namespace To_Do
{
    public class BoardElement
    {

        public enum StatusType
        {
            TODO = 1,
            INPROGRESS,
            DONE
        }

        public Card Card { get; set; }
        public StatusType Status { get; set; }

       

        public BoardElement(Card card, StatusType status)
        {
            Card = card;
            Status = status;
        }


        public BoardElement()
        {

        }
    }
}
