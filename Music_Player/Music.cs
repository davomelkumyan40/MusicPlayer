using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    class Music
    {
        public Music()
        {

        }

        public Music(string name, string executor, int size, Image picture)
        {
            Name = name;
            Executor = executor;
            Size = size;
            Picture = picture;
        }

        public string Name { get; set; }

        public string Executor { get; set; }

        public int Size { get; set; }

        public Image Picture { get; set; }
    }
}
