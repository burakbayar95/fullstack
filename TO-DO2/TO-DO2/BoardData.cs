using System;
using System.Collections.Generic;
using System.Text;

namespace TO_DO2
{
    public static class BoardData
    {
        public static Board board = new Board()
        {
            ToDo = new List<Card>()
            {
                new Card("title1","content1",Size.XS,1)
            },
            InProgress = new List<Card>()
            {
                new Card("title2","content2",Size.S,2)
            },

            Done = new List<Card>()
            {
                new Card("title3","content3",Size.XS,3)
            }




        };

       


    }
}
