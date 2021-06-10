using System;
using System.Collections.Generic;
using System.Text;

namespace TO_DO2
{
    public enum Size
    {
        XS = 1,
        S,
        M,
        L,
        XL

    }

   
    public class Card
    {
        public string title { get; set; }
        public string content { get; set; }
        public Size size { get; set; }
        public int memberid { get; set; }
      

        public Card(string title, string content, Size size, int memberid)
        {
            this.title = title;
            this.content = content;
            this.size = size;
            this.memberid = memberid;
           
        }

        public Card() { }
    }
}
