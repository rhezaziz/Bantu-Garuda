using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EgoDialog : MonoBehaviour
{
    
	private Queue<string> sentences;

	public Text dialogText;
	public Text nameText;

	public Animator animator;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialog(DialogEgo dialog){
        //	animator.SetBool("pindahDialog", true);
       GameObject.Find("Trigger").SetActive(false);
        //GameObject.Find("Next").SetActive(true);
        nameText.text = dialog.name;

    	sentences.Clear();

    	foreach(string sentence in dialog.sentences){
    		sentences.Enqueue(sentence);
    	}

    	DisplayNext();
    }

    public void DisplayNext(){
    	// animator.SetBool("pindahDialog", false);

    	if(sentences.Count == 18){
            animator.SetBool("Next", true);
    		// return;
    		// Debug.Log("berubah");

    	}else if(sentences.Count == 16){
    		 animator.SetBool("Next" , false);
    		//Debug.Log("wey");
    	}else if(sentences.Count == 13){
    		animator.SetBool("Next", true);
    	}else if(sentences.Count == 11){
    		animator.SetBool("Next" , false);
    	}else if(sentences.Count == 9){
    		animator.SetBool("pindahDialog", true);
    	}else if(sentences.Count == 6){
    		animator.SetBool("pindahDialog", false);
    	}

        // else if(sentences.Equals("6")){

        // 	//animator.SetBool("pindahDialog", false);
        // 		if(sentences.Count == 4){
        // 			//animator.SetBool("pindahDialog", true);
        // 			animator.SetBool("pindahDialog", true);
        // 		}
        // 	}else if(sentences.Equals("2")){
        // 		if(sentences.Count == 2){
        // 			animator.SetBool("pindahDialog" , true);
        // 		}
        // 	}
        // if(sentences.Equals("5")){
        // 	EndDialog();
        // 	return;
        // }
        //animator.SetBool("Next", false);
    	
    	string sentence = sentences.Dequeue();
    	// Debug.Log(sentence);

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


    public void EndDialog(){
    	 //Debug.Log("Selesai");
    Debug.Log("sudah selesai");
    }

    
}
