using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sesi : MonoBehaviour
{
    public GameObject Lanjut;
    // Start is called before the first frame update
    void Start()
    {
        int garuda = PlayerPrefs.GetInt("garuda");
        garuda += 0;
        Debug.Log("garuda " + garuda);

        if(garuda == 0)
        {
            PlayerPrefs.SetInt("garuda", garuda);

        }
        else
        {

        }

        int life = PlayerPrefs.GetInt("life");
        life += 0;
        if(life == 0)
        {
            PlayerPrefs.SetInt("life", life);
        }
        else
        {

        }

        int a = PlayerPrefs.GetInt("sesi");
        a += 0;

        if (a == 0)
        {
            PlayerPrefs.SetInt("sesi", a);
            Lanjut.SetActive(false);
            Debug.Log("ini a di menu lanjut false");
            Debug.Log(a);

        }
        else
        {
            Lanjut.SetActive(true);
            Debug.Log("ini a di menu lanjut active");
            Debug.Log(a);

        }

    }





    // public GameObject Lanjut;
    // // Start is called before the first frame update
    // void Start()
    // {
    //    int a = PlayerPrefs.GetInt("sesi");
    //     a += 0;

    //     if (a == 0)
    //     {
    //         PlayerPrefs.SetInt("sesi", a);
    //         Lanjut.SetActive(false);
    //         Debug.Log("ini a di menu lanjut false");
    //         Debug.Log("sesi"+a);

    //     }
    //     else
    //     {
    //         Lanjut.SetActive(true);
    //         Debug.Log("ini a di menu lanjut active");
    //         Debug.Log("sesi"+a);

    //     }

    // }

    // Update is called once per frame

}
