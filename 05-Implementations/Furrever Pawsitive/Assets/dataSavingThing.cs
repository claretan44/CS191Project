using UnityEngine;
using System.Collections;

public class dataSavingThing : MonoBehaviour {

    public static dataSavingThing Instance;
    public int currID;
    public int catCount;
    public int score;
    public int spawned;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () 
    {

        currID = 0;
        catCount = 0;
        score = 0;
        spawned = 0;
	}
	
    void Update ()
    {
        print("Cat Count: " + PlayerPrefs.GetInt("Cat Count", 0));
    }

    public int GetNextCatID ()
    {
        for (int i = 0; i < 6; i++)
        {
            if (PlayerPrefs.GetInt("Cat " + i + " Exists", 0) == 0) return i;
        }

        return -1;
    }

    public void SaveCat (int id, float colorR, float colorG, float colorB, float hunger, float health, float friendship)
    {
        PlayerPrefs.SetInt("Cat " + id + " Exists", 1);
        PlayerPrefs.SetString("Cat " + id + " Name", "Name");
        PlayerPrefs.SetFloat("Cat " + id + " ColorR", colorR);
        PlayerPrefs.SetFloat("Cat " + id + " ColorG", colorG);
        PlayerPrefs.SetFloat("Cat " + id + " ColorB", colorB);
        PlayerPrefs.SetFloat("Cat " + id + " Hunger", hunger);
        PlayerPrefs.SetFloat("Cat " + id + " Health", health);
        PlayerPrefs.SetFloat("Cat " + id + " Friendship", friendship);
    }
}
