using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BakeryFP.Models
{
    public class Message
    {
        public string MessageText { get; set; }
        public Message() { }
        public Message(string text)
        {
            MessageText = text;
        }
    }
}