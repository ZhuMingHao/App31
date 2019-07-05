using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App31
{

    public class RooterMasterDetailPageMenuItem
    {
        public RooterMasterDetailPageMenuItem()
        {
            TargetType = typeof(RooterMasterDetailPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}