#if (UNITY_EDITOR || UNITY_ANDROID)
/**
 * $File: AndroidBehaviour.cs $
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
public abstract class AndroidBehaviour<T> : MonoBehaviour where T : AndroidBehaviour<T>
{
    protected abstract string javaClassName { get; }

    private static T _instance;
    protected static T instance { get { return _instance; } }

    protected AndroidBehaviour() { _instance = this as T; }

    protected void CallStatic(string methodName, params object[] args)
    {
        using (AndroidJavaClass ajc = new AndroidJavaClass(javaClassName))
        {
            ajc.CallStatic(methodName, args);
        }
    }

    protected ReturnType CallStatic<ReturnType>(string methodName, params object[] args)
    {
        using (AndroidJavaClass ajc = new AndroidJavaClass(javaClassName))
        {
            return ajc.CallStatic<ReturnType>(methodName, args);
        }
    }

    protected ReturnType GetStatic<ReturnType>(string fieldName)
    {
        using (AndroidJavaClass ajc = new AndroidJavaClass(javaClassName))
        {
            return ajc.GetStatic<ReturnType>(fieldName);
        }
    }
}
#endif
