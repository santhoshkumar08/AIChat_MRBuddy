﻿using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Dialogs.Adaptive.Recognizers;
using System.Collections.Generic;

namespace MRBuddy
{
    public static class IntentRecognizer
    {
        public static  Recognizer CreateRecognizer()
        {
           return new RegexRecognizer
            {
                Intents = new List<IntentPattern>
                {                    
                     new IntentPattern("coil", "(?i)coil|rf|gradient|rf coil|gradient coil"),
                     new IntentPattern("help", "(?i)help")                   
                }
            };
        }
    }
}
