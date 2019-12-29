using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Penjelasan : MonoBehaviour
{
    private Queue<string> sentences;

    public Text dialogText;
    
 
    


    void Start()
    {

        sentences = new Queue<string>();

    }



    public void StartDialog(Cakap dialog)
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
        if(sentences.Count == 0)
        {
            EndDialog();
            return;
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
        
    }
}
