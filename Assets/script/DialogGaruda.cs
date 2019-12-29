using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogGaruda : MonoBehaviour
{
    private Queue<string> sentences;

    public Text dialogText;
    
   // public Dialog cakap;

    
    public Animator animator;

    void Start()
    {

        sentences = new Queue<string>();

    }
    // void update(){
    //     StartDialog(cakap);
    // }

    public void StartDialog(Dialog dialog)
    {
        //animator.SetBool("pindah", true);

        GameObject.Find("Trigger").SetActive(false);
       // GameObject.Find("Level1").SetActive(false);

        
        sentences.Clear();

        foreach(string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextDialog();
    }


    public void DisplayNextDialog()
    {
        // if(sentences.Count == 0)
        // {
        //     EndDialog();
        //     return;
        // }

        if(sentences.Count == 17){
            animator.SetBool("pindah", true);
        }else if(sentences.Count == 16){
            animator.SetBool("pindah", false);
        }else if(sentences.Count == 14){
            animator.SetBool("obrolan", true);
        }else if(sentences.Count == 12){
            animator.SetBool("obrolan", false);
        }else if(sentences.Count == 9){
            animator.SetBool("obrolan", true);
        }else if(sentences.Count == 7){
            animator.SetBool("obrolan", false);
        }else if(sentences.Count == 5){
            animator.SetBool("Map" , true);
        }else if(sentences.Count == 4){
            animator.SetBool("Map", false);
        }else if(sentences.Count == 1){
            // animator.SetBool("MarkerMap", true);
            SceneManager.LoadScene("pilihlevel");
        }else if(sentences.Count == 0){
            SceneManager.LoadScene("pilihlevel");
            GameObject.Find("Button").SetActive(false);
            
           // GameObject.Find("Panel").SetActive(false);
            // GameObject.Find("Level1").SetActive(true);

        }
        string sentence = sentences.Dequeue();
      //  Debug.Log(sentence);


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
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       // animator.SetBool("pindah", false);
        
    }

}
