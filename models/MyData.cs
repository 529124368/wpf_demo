using System;
using System.Collections.Generic;


namespace WpfApp1.models
{
    class MyData
    {
        private string _name = "nihao";
        private int _age = 30;
        private List<string> _course;
        private static MyData instance;

        private MyData() { }
        public static MyData GetInstance()
        {
            if(instance == null)
            {
                instance= new MyData();
            }
            return instance;
        }
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public List<string> Course { get => _course; set => _course = value; }


    }

    class Menus
    {
        public string MenuName { set; get; }
        public List<Menus> SubMenu { set; get; }
        public Menus(string name, Menus parmentMenu)
        {
            MenuName = name;
            if (parmentMenu != null)
            {
                List<Menus> list = parmentMenu.SubMenu ?? new List<Menus>();
                list.Add(this);
                parmentMenu.SubMenu = list;
            }
        }
    }
}
