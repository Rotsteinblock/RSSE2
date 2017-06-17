﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSE2
{
    class CollisionSphereViewModel : CollisionShapeViewModel
    {

        private CollisionSphere _sphere;
        public CollisionSphere Sphere { get { return _sphere; } }

        public double Radius
        {
            get { return _sphere.r; }
            set
            {
                _sphere.r = value;
                OnPropertyChanged();
            }
        }

        public CollisionSphereViewModel(CollisionSphere sphere)
        {
            _sphere = sphere;
        }
    }
}
