using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endingDialog : MonoBehaviour
{
    // Start is called before the first frame update
     private Queue<string> sentences;

    public Text dialogText;

    public Animator ego, percakapan;
    public Image ego1;
    
 
    


    void Start()
    {

        sentences = new Queue<string>();

    }



    public void StartDialog(ending dialog)
    {
        //animator.SetBool("pindah", true);
        GameObject.Find("Trigger").SetActive(false);

        //nameText.text = dialog.name;
        sentences.Clear();
        foreach (string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);

        }

        DisplayNextDialog();

    }

    public void DisplayNextDialog()
    {
        if(sentences.Count == 14)
        {
            percakapan.SetBool("endingDialog",true);
        	ego1.enabled = false;
            //ego.SetBool("ending",true);
           
        }else if(sentences.Count == 11){
        	percakapan.SetBool("endingDialog",false);
        	ego1.enabled = true;
        }else if(sentences.Count == 9){
        	percakapan.SetBool("endingDialog",true);
        	ego1.enabled = false;
        }else if(sentences.Count == 6){
        	percakapan.SetBool("endingDialog",false);
        	ego1.enabled = true;
        }else if(sentences.Count == 3){
        	
        	ego.SetBool("ending",true);
        }else if(sentences.Count == 2){
        	percakapan.SetBool("endingDialog",true);
        	ego1.enabled = false;
        }else if(sentences.Count == 0){
        	SceneManager.LoadScene("tentang");
        }
        string sentence = sentences.Dequeue();
        // if (sentences.Count < 3)
        // {
        //     klik.SetActive(false);
        // }
        Debug.Log(sentences.Count);


        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogText.text += letter;
            yield return null;
        }
    }

    public void EndDialog()
    {
       //  int a = PlayerPrefs.GetInt("sesi");
       //  if(a == 2){
       // animator.SetActive("map", true);     
       //  }
       GameObject.Find("Next").SetActive(false);
       Debug.Log("selesai");
        
    }
    
}
