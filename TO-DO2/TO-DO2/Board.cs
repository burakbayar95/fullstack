using System;
using System.Collections.Generic;
using System.Text;

namespace TO_DO2
{
    public class Board
    {
        public List<Card>  ToDo { get; set; }
        public List<Card> InProgress { get; set; }
        public List<Card> Done { get; set; }


        public Board(List<Card> todo, List<Card> inprogress, List<Card> done)
        {
            ToDo = todo;
            InProgress = inprogress;
            Done = done;

        }
        public Board()
        {

        }
    }
}
