using System.Collections.Generic;

 namespace Packs.Models
 {
     public class Category
     {
         private static List<Category> _instances = new List<Category> {};
         public string Name { get; set; }
         public int Id { get; }
         public List <Tracking> Trackings { get; set; }
      
        public Category(string name)
        {
            Name = name;
            _instances.Add(this);
            Id = _instances.Count;
            Trackings = new List<Tracking>{};
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
        public static List<Category> GetAll()
        {
            return _instances;
        }
        public static Category Find(int iD)
        {
            return _instances[iD-1];
        }
        public void AddItem(Tracking track)
        {
            Trackings.Add(track);
        }
     }
 }