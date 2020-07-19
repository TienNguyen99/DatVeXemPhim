using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatVeXemPhim.Common
{
    [Serializable]
    public class UserLogin
    {
        public int CusId { get; set; }
        public string UserName { get; set; }
    }
}