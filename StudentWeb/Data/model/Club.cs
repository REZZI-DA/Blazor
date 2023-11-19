using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWeb.Data.model
{
    [Table("Club")]
    public class Club
    {
        [Key]
        public string ClubName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Established { get; set; }


        public int StadiumCapacity { get; set; }


        public string League { get; set; }
    }
}
