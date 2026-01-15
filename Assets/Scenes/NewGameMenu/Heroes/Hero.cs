using Microsoft.Unity.VisualStudio.Editor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Heroes
{
    internal class Hero
    {
        protected Image HeroIcon { get; private set; }
        protected GameObject HeroModel { get; private set; }
        public Hero(Image heroIcon, GameObject heroModel) 
        {
            this.HeroIcon = heroIcon;
            this.HeroModel = heroModel;
        }
        
    }
}
