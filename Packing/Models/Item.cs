using System.Collections.Generic;

namespace Packs.Models
{
    public class Tracking
    {
        public string ItemName { get; set; }
        public string Category { get; set; }

        public int Id { get; }
        private static List<Tracking> _packList = new List<Tracking> {};

        public Tracking(string itemName, string category)
        {
            ItemName = itemName;
            Category = category;
            _packList.Add(this);
            Id = _packList.Count;
        }

        public static List<Tracking> GetAll()
        {
            return _packList;
        }

        public static void ClearAll()
        {
            _packList.Clear();
        }

        public static Tracking Find(int search)
        {
            return _packList[search -1];
        }

        public static void Delete(int ID)
        {
            for(int i=0; i<_packList.Count; i++)
            {
                if(_packList[i].Id == ID)
                {
                    _packList.Remove(_packList[i]);
                }
            }
        }

    }
}