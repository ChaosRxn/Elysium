using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour
{

    public float health;
    public float experience;
    public static GameControl control;

    void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    void OnGui()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "Health: " + health);
        GUI.Label(new Rect(10, 40, 150, 30), "Experience: " + experience);
    }

    public void SaveState()
    {
        PlayerPrefs.SetFloat("PosX", transform.position.x);
        PlayerPrefs.SetFloat("PosY", transform.position.y);
        PlayerPrefs.SetFloat("PosZ", transform.position.z);

        PlayerPrefs.SetFloat("RotX", transform.eulerAngles.x);
        PlayerPrefs.SetFloat("RotY", transform.eulerAngles.y);
        PlayerPrefs.SetFloat("RotZ", transform.eulerAngles.z);
    }

    public void LoadState()
    {
        float x = PlayerPrefs.GetFloat("PosX");
        float y = PlayerPrefs.GetFloat("PosY");
        float z = PlayerPrefs.GetFloat("PosZ");

        float rx = PlayerPrefs.GetFloat("RotX");
        float ry = PlayerPrefs.GetFloat("RotY");
        float rz = PlayerPrefs.GetFloat("RotZ");

        transform.position = new Vector3(x, y, z);
        transform.rotation = Quaternion.Euler(rx, ry, rz);
    }


}
