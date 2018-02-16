using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public abstract class Players
    {
        private string _name;

        public string Name {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public Players(string name)
        {
            Name = name;
        }


        public virtual void Action()
        {
            
        }
    }
}
