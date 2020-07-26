#if (UNITY_EDITOR || UNITY_ANDROID)
/**
 * $File: Test_Interaction.cs $
 * $Date: #CREATIONDATE# $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information 
 *	                 Copyright © #CREATEYEAR# by Shen, Jen-Chieh $
 */
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 
/// </summary>
public class Test_Interaction
    : MonoBehaviour
{
    /* Variables */

    private AndroidJavaObject javaClass = null;

    public Text myText = null;

    /* Setter & Getter */

    /* Functions */

    private void Start()
    {
#if ENABLE_WINMD_SUPPORT
        Debug.Log("Hello World!");
#else
        javaClass = new AndroidJavaObject("com.jcs.jcslib.TestClass");

        javaClass.Call("LogNativeAndroidLogcatMessage");

        myText.text = javaClass.Call<int>("add", 1, 2).ToString();
#endif
    }
}
#endif
