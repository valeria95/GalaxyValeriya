#region using

using System;
using System.Diagnostics;
using System.Windows;
using Galaxy.Core.Actors;
using Galaxy.Core.Environment;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

#endregion

namespace Galaxy.Environments.Actors
{
    public class Ship2 : Ship
    {

        private const int MaxSpeed = 2;
        private const long StartFlyMs = 2000;
        public Ship2(ILevelInfo info)
            : base(info)
        {
            Width = 30;
            Height = 30;
            ActorType = ActorType.Enemy;
        }

       
        public override void Load()
        {
            Inity();
            Load(@"Assets\ship2.png");
           
        }


    }
}
