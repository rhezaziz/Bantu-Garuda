using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEgo : MonoBehaviour
{
    public DialogEgo dialog;

    public void EgoTrigger(){
    	FindObjectOfType<EgoDialog>().StartDialog(dialog);
       //GameObject.Find("Next").SetActive(false);
    }
}
