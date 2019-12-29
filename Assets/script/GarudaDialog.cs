using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GarudaDialog : MonoBehaviour
{
    private Queue<string> sentences;

    public Text dialogText;
    public Text nameText;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

   public void StartDialog(Dialog dialog)

    {

        animator.SetBool("pindah", true);

        nameText.text = dialog.name;

        sentences.Clear();

        foreach(string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayDialog();
    }

    public void DisplayDialog()
    {
        if (sentences.Count == 0)
        {
            EndDialog();
            return;
        }
         
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

    void EndDialog()
    {
        //Debug.Log("Sudah berakhir ");
        animator.SetBool("pindah", false);
    }

}
