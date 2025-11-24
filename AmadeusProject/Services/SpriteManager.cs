using System;
using System.Collections.Generic;
using System.IO;

namespace AmadeusProject.Services
{
    public class SpriteManager
    {
        private Dictionary<string, string> _sprites;

        public SpriteManager()
        {
            _sprites = new Dictionary<string, string>
            {
                { "[NEUTRAL]",   "peaceful.png" },
                { "[HAPPY]",     "happy.png" },
                { "[VERYHAPPY]", "veryhappy.png" },
                { "[ANGRY]",     "angry.png" },
                { "[VERYANGRY]", "veryangry.png" },
                { "[SAD]",       "sad.png" },
                { "[SHY]",       "shy.png" },
                { "[VERYSHY]",   "veryshy.png" },
                { "[SMIRK]",     "smirk.png" }
            };
        }

        public string GetSpritePath(string emotionTag)
        {
            string key = emotionTag.Trim().ToUpper();

            string fileName;
            if (_sprites.ContainsKey(key))
            {
                fileName = _sprites[key];
            }
            else
            {
                fileName = "happy.png"; // Image par défaut
            }

            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", fileName);
        }
    }
}