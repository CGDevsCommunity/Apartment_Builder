﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Foxsys.ApartmentBuilder
{
    public interface IWallObject
    {
        bool TryAddObject(Vector2 position);
        void DrawOnWall(Vector2 position);
    }
}