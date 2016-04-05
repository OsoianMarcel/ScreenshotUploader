using System;

namespace App.Models.StaticMd
{
    public class Token
    {
        public string token { get; set; }
        public int token_valid_after_seconds { get; set; }
        public int token_valid_after_timestamp { get; set; }
        public int token_valid_seconds { get; set; }
        public int server_timestamp { get; set; }
        public string error { get; set; }
    }
}