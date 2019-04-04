using System;
using System.IO;
using UnityEngine;

public class ParameterLoader : MonoBehaviour
{

    private string filePath = "./setting.txt";
    private JsonData jsonData;


    [Serializable]
    public class JsonData
    {
        public string AppType;
        public string ServerHost;
        public string ServerPort;
		public bool IsDebug;
    }



    public static ParameterLoader Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("ParameterLoader").AddComponent<ParameterLoader>();
                DontDestroyOnLoad(instance);
            }
            return instance;
        }
    }

    public static JsonData Data
    {
        get
        {
            return Instance.jsonData;
        }
    }


    private static ParameterLoader instance = null;

    // Use this for initialization
    void Awake()
    {
        instance = this;
        jsonData = new JsonData();
        jsonData = loadSettingFile();
	}

    void Update()
    {

    }


    private JsonData loadSettingFile()
    {
        var text = File.ReadAllText(filePath);
        jsonData = new JsonData();
        var data = JsonUtility.FromJson<JsonData>(text);
        return data;
    }


}
