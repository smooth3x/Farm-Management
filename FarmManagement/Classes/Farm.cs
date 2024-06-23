using System;
using System.Collections.Generic;
using System.Drawing;


namespace FarmManagement
{
    //--- Farm Class: Main Class for this project ---
    [Serializable]
    public class Farm
    {
        string _name;
        string _ownerName;
        Map _map;

        public Farm()
        {
            _name = "";
            _ownerName = "";
            _map = new Map(Properties.Resources.Background_darker);
        }
        public Farm( string name, string ownerName, Image image)
        {
            _name = name;
            _ownerName = ownerName;
            _map = new Map(image);
        }
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public String OwnerName
        {
            get { return _ownerName; }
            set { _ownerName = value; }
        }
        public Map Map
        {
            get { return _map; }
        }
    }
}
