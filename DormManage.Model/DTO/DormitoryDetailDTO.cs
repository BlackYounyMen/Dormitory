using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManage.Model
{
    public class DormitoryDetailDTO
    {
        public int Id { get; set; }
        public string DormitoryNum { get; set; }
        public string Bed1 { get; set; }
        public string Bed2 { get; set; }
        public string Bed3 { get; set; }
        public string Bed4 { get; set; }
        public string Bed5 { get; set; }
        public string Bed6 { get; set; }
        public string Bed7 { get; set; }
        public string Bed8 { get; set; }
        public string Bed9 { get; set; }
        public string Bed10 { get; set; }
        public int TotalPerson { get; set; }
        public int WeekCheckIn { get; set; }
        public int WeekCheckOut { get; set; }
        public string DormitoryManager { get; set; }
        public int FreeBedNum { get; set; }

        public string FlagManAndWoMen { get; set; }
    }
}
