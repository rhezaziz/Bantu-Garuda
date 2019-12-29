using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;

    //public void TriggerDialog()
    //{
    //    FindObjectOfType<DialogGaruda>().StartDialog(dialog);
    //}

     public void TriggerDialog()
    {
        FindObjectOfType<DialogGaruda>().StartDialog(dialog);
    }
}
