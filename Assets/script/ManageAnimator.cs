using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;

    public void pindahAnimator(){
 //   	animator.SetBool("sumatraHijau", false);
//    	GameObject.Find("ManageAnimator").SetActive(false);
        // int animasi = PlayerPrefs.GetInt("Animasi");
        // animasi += 1;
    	FindObjectOfType<cobacoba>().pindah();
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
