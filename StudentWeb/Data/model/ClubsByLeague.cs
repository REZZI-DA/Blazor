using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWeb.Data.model
{

    public class ClubsByLeague
    {

        public long LeagueRank { get; set; }
        public string League { get; set; }
        public int YearEstablished { get; set; }
        public int NumberOfLeagues { get; set; }
        public decimal MembersByCapacity { get; set; }
        public int MaxCapacity { get; set; }
        public int CapacityByPatrons { get; set; }
    }
}
