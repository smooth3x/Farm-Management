using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmManagement
{
    [Serializable]
    public class Building
    {
        int _id;
        string _type;
        Panel _infoPanel;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public Panel InfoPanel
        {
            get { return _infoPanel; }
            set { _infoPanel = value; }
        }
    }

    [Serializable]
    public class Maintenance : Building
    {
        
    }
    [Serializable]
    public class Garage: Maintenance
    {
        List<string> _machines;

        public Garage(Panel infoPanel, int id, string type)
        {
            this.InfoPanel = infoPanel;
            this.Id = id;
            this.Type = type;

            _machines = new List<string>();
        }

        public void AddMachine(string name)
        {
            _machines.Add(name);
        }

        public void RemoveMachine(string name)
        {
            _machines.Remove(name);
        }

        public void copyFromList(List<string> items)
        {
            foreach (var item in items)
            {
                Machines.Add(item);
            }
        }

        public List<string> Machines
        {
            get { return _machines; }
            set { this._machines = value; }
        }
    }
    [Serializable]
    public class Storage: Maintenance
    {
        List<Item> _items;

        public Storage(Panel infoPanel, int id, string type)
        {
            this.InfoPanel= infoPanel;
            this.Id = id;
            this.Type = type;

            this._items = new List<Item>();
        }

        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public void AddItemToStorage(ListViewItem item)
        {
            if(item != null)
            {
                Item itemToAdd = new Item();

                itemToAdd.Name = item.Text;
                itemToAdd.Amount = Int32.Parse(item.SubItems[1].Text); 
                itemToAdd.Unit = item.SubItems[2].Text;

                Items.Add(itemToAdd);
            }
        }
        public void Remove(ListViewItem item)
        {
            Items.Remove(Items.Single(s => s.Name == item.Text));
        }

        public void copyFromList(List<Item> items)
        {
            foreach (var item in items)
            {
                Items.Add(item);
            }
        }

        public bool FindItem(string name)
        {
            if (Items.Find(s => s.Name == name) != null)
                return true;
            return false;
        }
    }
    [Serializable]
    public class GrowingArea : Building
    {
        int _count = 0;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
    }

    public class Animal : GrowingArea
    {
        int _maxCapacity = 10;
        string _foodType;
        double _foodAmountPerAnimal = 0.0;
        double _waterAmountPerAnimal = 0.0;
        string _produceType;
        double _produceAmountPerAnimal;
        string _produceUnit;


        public Animal(Panel infoPanel, int id, string animalType, double foodAmountPerAnimal, double waterAmountPerAnimal, string foodType, string produceType, double produceAmountPerAnimal, string produceUnit)
        {
            this.InfoPanel = infoPanel;

            this.Id = id;
            this.Type = animalType;
            this._foodType = foodType;
            this._foodAmountPerAnimal = foodAmountPerAnimal;
            this._waterAmountPerAnimal = waterAmountPerAnimal;
            this._produceType = produceType;
            this._produceAmountPerAnimal = produceAmountPerAnimal;
            this._produceUnit = produceUnit;
        }

        public int MaxCapacity
        {
            get { return _maxCapacity; }
            set { _maxCapacity = value; }
        }

        public string FoodType
        {
            get { return _foodType; }
            set { _foodType = value; }
        }

        public double WaterAmountPerAnimal
        {
            get { return _waterAmountPerAnimal; }
            set { _waterAmountPerAnimal = value;}
        }

        public double FoodAmountPerAnimal
        {
            get { return _foodAmountPerAnimal; }
            set { _foodAmountPerAnimal= value; }
        }

        public string ProduceType
        {
            get { return _produceType; }
            set { _produceType = value; }
        }

        public double ProduceAmountPerAnimal
        {
            get { return _produceAmountPerAnimal; }
            set { _produceAmountPerAnimal = value; }
        }

        public string ProduceUnit
        {
            get { return _produceUnit; }
            set { _produceUnit = value; }
        }

    }
    [Serializable]
    public class Vegetation: GrowingArea
    {
        int _wateringBreakDays;
        int _wateringAmount;
        int _weeklyProduceAmount;
        string _productUnit;

        public Vegetation(Panel infoPanel, int id, string type, int wateringBreakDays, int wateringAmount, int weeklyProduceAmount, string productUnit)
        {
            this.InfoPanel = infoPanel;
            this.Id = id;
            this.Type = type;
            this._wateringBreakDays = wateringBreakDays;
            this._wateringAmount = wateringAmount;
            this._weeklyProduceAmount = weeklyProduceAmount;
            this._productUnit = productUnit;
        }

        public int WateringBreakDays
        {
            get { return _wateringBreakDays; }
            set { _wateringBreakDays = value; }
        }
        public int WateringAmount
        {
            get { return _wateringAmount; }
            set { _wateringAmount = value; }
        }
        public int WeeklyProduceAmount
        {
            get { return _weeklyProduceAmount; }
            set { _weeklyProduceAmount = value; }
        }
        public string ProductUnit
        {
            get { return _productUnit; }
            set { this._productUnit = value; }
        }
    }

    [Serializable]
    public class BuildingList
    {
        static string[] BuildingNames = { "אורווה", "לול", "רפת", "דיר", "מחסן", "מוסך", "עלי נענע", "גזרים", "לימונים", "תפוזים", "תפו\"א" };
        static string[] BuildingFoodType = { "חציר", "גרגירים", "דשא", "דשא" };
        static double[] BuildingFoodPerAnimal = { 4.5, 0.25, 10.0, 1.0 };
        static double[] BuildingWaterPerAnimal = { 20.0, 0.5, 45.0, 5.0 };
        static double[] BuildingAverageProducePerAnimal = { 80, 5, 7, 0.2 };
        static string[] BuildingProduceType = { "רכיבה", "ביצים", "חלב", "צמר", "", "", "עלי נענע", "גזרים", "לימונים", "תפוזים", "תפו\"א" };
        static string[] BuildingProduceUnit = { "ק\"מ", "יחידות", "ליטרים", "מטרים", "", "", "גבעולים", "ק\"ג", "ק\"ג", "ק\"ג", "ק\"ג" };

        static int[] VegWateringBreakDays = { -1, -1, -1, -1, -1, -1, 1, 3, 1, 1, 4 };
        static int[] VegWateringAmount = { -1, -1, -1, -1, -1, -1, 2, 1, 2, 2, 1 };
        static int[] VegWeeklyProduceAmount = { -1, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1 };

        protected List<Building> _buildingList;

        public BuildingList()
        {
            _buildingList = new List<Building>();
        }

        public List<Building> GetBuildings
        {
            get { return _buildingList; }
            set { _buildingList = value; }
        }

        public void AddNewBuilding(Panel infoPanel, int type, int id)
        {
            switch (type)
            {
                case 0: case 1: case 2: case 3:
                    {
                        _buildingList.Add(new Animal(infoPanel, id, BuildingNames[type], BuildingFoodPerAnimal[type], BuildingWaterPerAnimal[type], BuildingFoodType[type], BuildingProduceType[type], BuildingAverageProducePerAnimal[type], BuildingProduceUnit[type]));
                        break;
                    }
                case 4:
                    {
                        _buildingList.Add(new Storage(infoPanel, id, BuildingNames[type]));
                        break;
                    }
                case 5:
                    {
                        _buildingList.Add(new Garage(infoPanel, id, BuildingNames[type]));
                        break;
                    }
                case 6: case 7: case 8: case 9: case 10:
                    {
                        _buildingList.Add(new Vegetation(infoPanel, id, BuildingNames[type], VegWateringBreakDays[type], VegWateringAmount[type], VegWeeklyProduceAmount[type], BuildingProduceUnit[type]));
                        break;
                    }
            }

            MainApp app = (MainApp)infoPanel.Parent.Parent;
            app.updateProduce();
        }


        public dynamic GetBuildingById(int id)
        {
            return _buildingList.Find(s => s.Id == id);
        }

        public void RemoveBuildingById(int id)
        {
            Panel infoPanel = _buildingList.Find(s => s.Id == id).InfoPanel;

            MainApp app = (MainApp)infoPanel.Parent.Parent;
            
            if(infoPanel.Tag != null && infoPanel.Tag.ToString() == id.ToString())
            {
                infoPanel.Hide();
            }

            _buildingList.Remove(_buildingList.Single(s => s.Id == id));
            app.updateProduce();

        }
 
    }
}
