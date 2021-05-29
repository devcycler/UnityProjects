using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FloatReference
{
    public bool UseConstant = true;
    public float ConstantValue;
    public FloatVariable variable;

    public float Value{
        get{return UseConstant ? ConstantValue : variable.value;}
    }
}
