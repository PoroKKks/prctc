using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SytnikPP
{
    public class Comment
    {
        public string Message { get; set; }
        public int RequestID { get; set; }

        public Comment(string message, int requestID)
        {
            Message = message;
            RequestID = requestID;
        }
    }
}
