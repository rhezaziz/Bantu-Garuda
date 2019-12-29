using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endingTrigger : MonoBehaviour
{
    // Start is called before the first frame update
   
    public ending dialog ;

    public void triggerEnding(){
    	FindObjectOfType<endingDialog>().StartDialog(dialog);
    }
}
