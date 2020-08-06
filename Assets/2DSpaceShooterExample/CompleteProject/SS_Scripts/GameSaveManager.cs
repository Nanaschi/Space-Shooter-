using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class GameSaveManager : MonoBehaviour
{
    public static GameSaveManager instance;

    public SharedValues_Script values;

    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this) {
            Destroy(this);
        }
        DontDestroyOnLoad(this);
    }
    public bool SaveFile()
    {
        return Directory.Exists(Application.persistentDataPath+ "/game_save");
    }

    public void SaveGame()
    {
        if (!SaveFile())
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/game_save");
        }
        if (!Directory.Exists(Application.persistentDataPath + "/game_save/values_data"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/game_save/values_data");
        }
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/game_save/values_data/value_save.txt");
        var json = JsonUtility.ToJson(values);
        bf.Serialize(file, json);
        file.Close();
    }
    public void LoadGame()
    {
        if (!Directory.Exists(Application.persistentDataPath + "/game_save/values_data"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/game_save/values_data");
        }
        BinaryFormatter bf = new BinaryFormatter();
        if(File.Exists(Application.persistentDataPath + "/game_save/values_data/value_save.txt"))
        {
            FileStream file = File.Open(Application.persistentDataPath + "/game_save/values_data/value_save.txt", FileMode.Open);
            JsonUtility.FromJsonOverwrite((string)bf.Deserialize(file), values);
            file.Close();
        }
    }
}
