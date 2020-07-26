#if (UNITY_EDITOR || UNITY_ANDROID)
/**
 * $File: Test_Bluetooth.cs $
 * $Date: #CREATIONDATE# $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information 
 *	                 Copyright © #CREATEYEAR# by Shen, Jen-Chieh $
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class Test_Bluetooth
    : AndroidBehaviour<Test_Bluetooth>
{
    /* Variables */

    /* Setter & Getter */

    /* Functions */

    // 要呼叫的class所在的Package名稱.要呼叫的java class名稱
    protected override string javaClassName { get { return "com.example.bluetooth.BluetoothConnection"; } }

    public static void openBT()
    {
        //instance.CallStatic("openBluetooth");
        instance.CallStatic("helloWorld");
    }
}
#endif
