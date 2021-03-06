﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class ArrayExtensions : MonoBehaviour {
 public static class ArrayExtensions
 {
     // This is an extension method. RandomItem() will now exist on all arrays.
     public static T RandomItem<T>(this T[] array)
     {
     return array[Random.Range(0, array.Length)];
     }
 }
