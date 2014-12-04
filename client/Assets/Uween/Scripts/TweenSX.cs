﻿using UnityEngine;
using System.Collections;

public class TweenSX : TweenVec1S<TweenSX>
{
    public static TweenSX Add(GameObject g, float duration, float to)
    {
        return Add<TweenSX>(g, duration, to);
    }
    
    override public float value
    {
        get
        {
            return vector.x;
        }
        set
        {
            Vector3 v = vector;
            v.x = value;
            vector = v;
        }
    }
}
