using System.Collections.Generic;

namespace CodeCampSDQ.Common
{
    public class Schedule
    {
        public Schedule()
        {
            Days = new List<Day>();
        }

        public int Id { get; set; }

        public ICollection<Day> Days { get; set; }
    }


}