using ODEV5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODEV5.Entities
{
    class Campaign : ICampaign
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descr { get; set; }
    }
}
