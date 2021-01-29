using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class TimeContainer
    {
        TimeSpan diff;
        DateTime? lastStartDate;
        public TimeContainer()
        {
            diff = TimeSpan.Zero;
        }

        public void Stop()
        {
            if(lastStartDate.HasValue)
            {
                diff = diff.Add(DateTime.Now - lastStartDate.Value);
                lastStartDate = null;
            }
        }

        public void Start()
        {
            if(!lastStartDate.HasValue)
            {
                lastStartDate = DateTime.Now;
            }
        }

        public override string ToString()
        {
            var totalDiff = diff;
            if(lastStartDate.HasValue)
                totalDiff = totalDiff.Add(DateTime.Now - lastStartDate.Value);

            return $"{(int)totalDiff.TotalHours}:{totalDiff.Minutes:00}:{totalDiff.Seconds:00}";
        }
    }
}
