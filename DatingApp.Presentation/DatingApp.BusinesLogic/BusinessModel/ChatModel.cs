using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.BusinesLogic.BusinessModel
{
    public class ChatModel
    {
        public int SenderId { get; set; }
        public int RecepientId { get; set; }
        public string TextMessage { get; set; }
    }
}
