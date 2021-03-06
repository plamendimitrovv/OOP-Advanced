﻿using _Logger.Interfaces;
using _Logger.Models.LayoutModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Logger.Factories
{
    public class FactoryLayout
    {
        public ILayout Create(string layoutType)
        {
            if (layoutType == "SimpleLayout")
            {
                return new SimpleLayout(); 
            }

            else if (layoutType == "XmlLayout")
            {
                return new XmlLayout(); 
            }

            throw new ArgumentException("Invalid type of Layout!");
        }
    }
}
