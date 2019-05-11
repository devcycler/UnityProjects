using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomArrayExtensions
{
    public static class ArrayExtensions
    {
        public static T GetRandom<T>(this T[] array)
        {
            return array[Random.Range(0, array.Length)];
        }
    }
}