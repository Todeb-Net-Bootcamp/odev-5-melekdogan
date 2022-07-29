using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Configuration.Response
{
    public class CommandResponse
    {
        public bool Status { get; set; }//işlem başarılı mı değil mi (true/false)
        public string Message { get; set; }//hata ya da bilgi mesajı 
    }
}
