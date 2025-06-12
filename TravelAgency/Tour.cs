using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency;

namespace TravelAgency
{
    public class Tour : IEnumerable<Tourist>
    {
        public string Title { get; set; }
        public string TourCode { get; }
        public int TouristCount => tourists.Count;

        private readonly List<Tourist> tourists = new List<Tourist>();

        public Tour(string title, string tourCode, IEnumerable<Tourist> tourists)
        {
            Title = title;
            TourCode = tourCode;

            foreach (var tourist in tourists)
            {
                if (tourist.TourCode == tourCode && !this.tourists.Contains(tourist))
                {
                    this.tourists.Add(tourist);
                }
            }
        }

        public IEnumerator<Tourist> GetEnumerator() => tourists.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
