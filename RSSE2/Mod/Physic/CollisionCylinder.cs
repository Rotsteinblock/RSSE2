﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSE2
{
    public class CollisionCylinder : CollisionShape
    {
        public double h;
        public double r;

        public override string Name { get { return "Cylinder"; } }

        public override CollisionShapeViewModel CreateViewModel()
        {
            return new CollisionCylinderViewModel(this);
        }
    }
}
