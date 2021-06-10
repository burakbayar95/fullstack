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

    public enum Type
    {
        ToDo,
        InProgress,
        Done

    }
    public class Card
    {
        public string title { get; set; }
        public string content { get; set; }
        public Size size { get; set; }
        public Member member { get; set; }
        public Type type { get; set; }

        public Card(string title, string content, Size size, Member member, Type type)
        {
            this.title = title;
            this.content = content;
            this.size = size;
            this.member = member;
            this.type = type;
        }

        public Card() { }
    }
}
