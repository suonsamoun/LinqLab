using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class SkipAndTakeLab
    {
        private static IEnumerable<Sample> Source { get; set; }

        public SkipAndTakeLab()
        {
            Source = new SampleDate().GetData();
        }

        public List<Sample> Skip5Data()
        {
            return Source.Skip(5).ToList();
        }

        public List<Sample> Take5Data()
        {
            return Source.Take(5).ToList();
        }

        public List<Sample> Skip5DataAndTake2Data()
        {
            return Source.Skip(5).Take(2).ToList();
        }
    }
}
