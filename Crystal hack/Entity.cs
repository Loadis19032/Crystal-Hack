﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Crystal_hack
{
    public class Entity
    {
        public Vector3 position { get; set; }
        public Vector3 viewOffset { get; set; }
        public Vector2 position2D { get; set; }
        public Vector2 viewPosition2D { get; set; }
        public int team { get; set; }
        public int health { get; set; }
        public bool spotted { get; set; }
        public string name { get; set; }
        public List<Vector3> bones { get; set; }
        public List<Vector2> bones2d { get; set; }
        public float distance { get; set; }
    }
    public enum BoneIds
    {
        Waist = 0,
        Neck = 5, 
        Head = 6,
        ShouldLeft = 8,
        ForeLeft = 9,
        HandLeft = 11,
        ShouldRight = 13,
        ForeRight = 14,
        HandRight = 16,
        KneeLeft = 23,
        FeetLeft = 24,
        KneeRight = 26,
        FeetRight = 27
    }
    
}
