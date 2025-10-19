using System;
using cfg;
using SimpleJSON;
using UnityEngine;
using System.IO;

namespace SN.Framework
{
    public class GameConfigManger : MonoInstance<GameConfigManger>
    {
        private bool _isInit = false;
        private void Awake()
        {
            Init();
        }

        private void Init()
        {
            if (!_isInit) return;
            _isInit = true;
        
            string path = "Assset/GameConfig/LubanJSGen";
            var tables = new cfg.Tables(file => JSON.Parse(File.ReadAllText($"{path}/{file}.json")));
        }
    }
}

