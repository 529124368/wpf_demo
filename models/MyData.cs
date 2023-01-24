using System;
using System.Collections.Generic;


namespace WpfApp1.models
{
    public class Storage
    {
        public static string Token = "";
    }
    public class MyData
    {
        private string _name = "nihao";
        private int _age = 30;
        private List<string> _course;


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

    class GameModel
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Developer { get; set; }
        public string SavePath { get; set; }
        public GameModel(string name, string path, string dev, string savePath)
        {
            Name = name;
            Path = path;
            Developer = dev;
            SavePath = savePath;
        }
    }
    public class Route
    {
        private string _path = "";

        private Dictionary<string,string> _mapping = new Dictionary<string,string>();

        public string Path { get => _path; set => _path = value; }
        public Dictionary<string, string> Mapping { get => _mapping; set => _mapping = value; }
        public Route()
        {
            string basePath = "/windows";
            _mapping.Add("main", basePath + "/Page1.xaml");
            _mapping.Add("center", basePath + "/Page2.xaml");
            _mapping.Add("store", basePath + "/Page3.xaml");
            _mapping.Add("setting", basePath + "/Page4.xaml");
            _mapping.Add("users", basePath + "/Page5.xaml");
            _mapping.Add("download", basePath + "/Page6.xaml");
        }

        public string GetPageUri()
        {
            return _mapping[_path];
        }
    }
}
