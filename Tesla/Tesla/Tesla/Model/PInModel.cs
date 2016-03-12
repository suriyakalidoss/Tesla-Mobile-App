﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesla.Base;
using TeslaDefinition.Interfaces.Model;

namespace Tesla.Model
{
    public class PinModel: BaseModel, IPinModel
    {
        private string _pin = "";
        public string Pin { get { return _pin; } set { _pin = value; OnPropertyChanged(); } }

        private string _hiddenPin = "";
        public string HiddenPin { get { return _hiddenPin; } set { _hiddenPin = value; OnPropertyChanged(); } }
    }
}
