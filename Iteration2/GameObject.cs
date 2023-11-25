using System;
using Iteration2;

namespace Iteration2
{
    public abstract class Game_Object : Identifiable_object
    {
        private string _description;
        private string _name;
        public Game_Object(string[] ids, string name, string desc) : base(ids)
        {
            _name = name;
            _description = desc;
        }
        public string Name //readonly property
        {
            get
            {
                return _name;
            }
        }
        public string ShortDescription //readonly property returns the required format of string displaying items from the list with required description
        {
            get
            {
                return "a " + _name + " " + "(" + FirstId + ")";
            }
        }
        public virtual string FullDescription //readonly returns the description.
        {
            get
            {
                return _description;
            }
        }
    }
}

