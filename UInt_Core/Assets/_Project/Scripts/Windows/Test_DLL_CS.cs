#if (UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN)
/**
 * $File: Test_DLL_CS.cs $
 * $Date: 2020-07-26 01:14:03 $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information 
 *	                 Copyright © 2020 by Shen, Jen-Chieh $
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity_Interaction;

/// <summary>
/// Test for DLL from C# windows.
/// </summary>
public class Test_DLL_CS 
    : MonoBehaviour 
{
    /* Variables */

    /* Setter & Getter */

    /* Functions */

    private void Start()
    {
        TestClass tc = new TestClass();
        int num = tc.Add(1, 2);

        Debug.Log(num);
    }
}
#endif
