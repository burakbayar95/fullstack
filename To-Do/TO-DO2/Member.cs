using System;
using System.Collections.Generic;
using System.Text;

namespace TO_DO2
{
    public class Member
    {
        public int Id { get; set; }
        public string Mem_name { get; set; }
        public Member(int ıd, string mem_name)
        {
            this.Id = ıd;
            this.Mem_name = mem_name;
        }

    }
}
