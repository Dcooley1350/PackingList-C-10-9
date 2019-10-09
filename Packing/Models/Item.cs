using System.Collections.Generic;

namespace Packs.Models
{
    public class Tracking
    {
        public string ItemName { get; set; }
        public string Category { get; set; }

        public int Id { get; }
        private static List<Tracking> _packList = new List<Tracking> {};

        public TrackingInput(string itemName, string category)
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


    }
}