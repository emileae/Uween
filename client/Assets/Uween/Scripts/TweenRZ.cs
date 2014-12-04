﻿using UnityEngine;
using System.Collections;

public class TweenRZ : TweenVec1R<TweenRZ>
{
    public static TweenRZ Add(GameObject g, float duration, float to)
    {
        return Add<TweenRZ>(g, duration, to);
    }
    
    override public float value
    {
        get
        {
            return vector.z;
        }
        set
        {
            Vector3 v = vector;
            v.z = value;
            vector = v;
        }
    }
}
