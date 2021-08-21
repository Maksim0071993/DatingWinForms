using System;
using System.Collections.Generic;

#nullable disable

namespace Dating.DataAccessLayer.Models
{
    public partial class Chat
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int RecipientId { get; set; }
        public string TextMessage { get; set; }

        public virtual Profile Recipient { get; set; }
        public virtual Profile Sender { get; set; }
    }
}
