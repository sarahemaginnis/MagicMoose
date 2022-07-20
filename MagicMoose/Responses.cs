﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMoose
{
    internal class Responses
    {
        List<string> ResponsesList = new List<string>()
        {
            "As I see it yes.",
            "Ask again later.",
            "Better not tell you now",
            "Cannot predict now.",
            "Concentrate and ask again.",
            "Don't count on it.",
            "It is certain.",
            "It is decidedly so.",
            "Most likely.",
            "My reply is no.",
            "My sources say no.",
            "Outlook not so good.",
            "Outlook good.",
            "Reply hazy, try again.",
            "Signs point to yes.",
            "Very doubtful.",
            "Without a doubt.",
            "Yes.",
            "Yes - definitely.",
            "You may rely on it."
        };

        public string GetResponse()
        {
            Random random = new Random();
            int randomNumber = random.Next(ResponsesList.Count);
            return ResponsesList[randomNumber];
        }
    }
}
