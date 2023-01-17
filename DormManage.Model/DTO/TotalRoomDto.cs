using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.Model
{
    public class TotalRoomDto
    {
        public int totalperson { get; set; }

        public int totalman { get; set; }

        public int totalwoman { get; set; }

        public string roomnum { get; set; }
        public string bednum { get; set; }
    }
}
