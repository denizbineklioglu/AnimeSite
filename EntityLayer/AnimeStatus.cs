using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AnimeStatus
    {
        public int ID { get; set; }
        public string Status { get; set; }

        public List<AnimeUserStatus> AnimeUserStatuses { get; set; }
    }
}
