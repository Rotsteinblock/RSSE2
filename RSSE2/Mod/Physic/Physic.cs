﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSE2
{
    public class Physic : Mod
    {

        public bool collision;
        public CollisionShape shape;
        public double mass;
        public double friction;

        public override ModViewModel CreateViewModel()
        {
            return new PhysicViewModel(this);
        }
    }
}
