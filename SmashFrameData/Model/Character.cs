using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashFrameData.Model
{
    public class Character
    {
        public string Name { get; set; }
        public SortedDictionary<string, int> moves;

        public Character(string name) { Name = name; }
    }
}
