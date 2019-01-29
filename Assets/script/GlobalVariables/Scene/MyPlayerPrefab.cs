using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerPrefab{
    private const string Key = "initial";
    //書き込み
    public static void SetObject<T>(string key, T objct)
    {
        var json = JsonUtility.ToJson(objct);
        PlayerPrefs.SetString(key, json);
    }

    //読み込み
    public static T GetObject<T>(string key)
    {
        if (PlayerPrefs.HasKey(key))
        {
            var json = PlayerPrefs.GetString(key);
            return  JsonUtility.FromJson<T>(json);
        }

        var Initialjson = PlayerPrefs.GetString(Key);
        return JsonUtility.FromJson<T>(Initialjson);
    }

    //上書き
    public static T LoadJsonOverwrite<T>(string key, T objct)
    {
        if (PlayerPrefs.HasKey(key))
        {
            var json = PlayerPrefs.GetString(key);
            JsonUtility.FromJsonOverwrite(json, objct);
            return objct;
        }

        var Initialjson = PlayerPrefs.GetString(Key);
        JsonUtility.FromJsonOverwrite(Initialjson, objct);
        return objct;
    }
}
