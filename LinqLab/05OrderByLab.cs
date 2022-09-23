using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class OrderByLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public OrderByLab()
        {
            Source = new SampleDate().GetData();
        }

        public List<Sample> AscendingId()
        {
            return Source.OrderBy(x => x.Id).ToList();
        }

        public List<Sample> DescendingId()
        {
            return Source.OrderByDescending(x => x.Id).ToList();
        }

        public List<Sample> AscendingPriceAndThenAscendingId()
        {
            return Source.OrderBy(x => x.Price).ThenBy(x => x.Id).ToList();
        }
    }
}
