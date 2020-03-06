using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3
{public enum  ChampionType {  FRONT_LINE = 0,
        DAMAGE = 1, SUPPORT=2, FLANK = 3
 }
    class Champion
    {
        private string _name;
        private ChampionType _type;
        private Ability _leftMouse;
        private Ability _rightMouse;
        private Ability _q;
        private Ability _f;
        private Ability _e;

        public Champion(string name, ChampionType type, Ability leftMouse, Ability rightMouse, Ability q, Ability f, Ability e)
        { _name = name;
            _type = type;
            _leftMouse = leftMouse;
            _rightMouse = rightMouse;
            _q = q;
            _f = f;
            _e = e;
        }

        public string Name { get => _name; }
        public ChampionType Type { get => _type; }
        public Ability LeftMouse { get => _leftMouse; }
            public Ability RightMouse { get => _rightMouse; }
            public Ability  Q { get => _q; }
            public Ability F { get => _f; }
    public Ability E { get => _e; }

    }
}
