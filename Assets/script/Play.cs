using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{

    AudioSource dialog, klik,indo,musikbiasa;
    int sesi;
    public GameObject menuAwal , keluar;


    private void Start()
    {

        sesi = PlayerPrefs.GetInt("sesi");
        indo = GameObject.Find("indo").GetComponent<AudioSource>();
        musikbiasa = GameObject.Find("musikbiasa").GetComponent<AudioSource>();
        keluar.SetActive(false);
        menuAwal.SetActive(false);
        Debug.Log("sesi = "+sesi);
        if(sesi <= 34)
        {
            musikbiasa.Play();
            //indo.Play();
        }
        else {
            indo.Play();
        }

       // keluar.SetActive(false);
    }

    public void play()
    {
        klik = GameObject.Find("klik").GetComponent<AudioSource>();
        klik.Play();
        PlayerPrefs.DeleteKey("life");
        PlayerPrefs.DeleteKey("garuda");
        PlayerPrefs.SetInt("life", 27);
        
        PlayerPrefs.SetInt("garuda", 9);
        PlayerPrefs.DeleteKey("sesi");
        PlayerPrefs.SetInt("sesi", 1);
        PlayerPrefs.SetInt("btnpilih", 0);
        SceneManager.LoadScene("panel1");
        PlayerPrefs.SetInt("Animasi", 0);
        PlayerPrefs.SetInt("ego", 0);
        PlayerPrefs.SetInt("pop", 0);
      //  map();
    }
    public void kembali()
    {
        // klik = GameObject.Find("klik").GetComponent<AudioSource>();
        // klik.Play();
        SceneManager.LoadScene("Game");
    }
    public void Menu()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Lanjut()
    {
        klik = GameObject.Find("klik").GetComponent<AudioSource>();
        klik.Play();
        int garuda = PlayerPrefs.GetInt("garuda");
        int life = PlayerPrefs.GetInt("life");
        if (garuda == 0 && life == 0)
        {
            play();

        }
        else
        {
            SceneManager.LoadScene("pilihlevel");
        }
    }
    public void Tentang()

    {
        klik = GameObject.Find("klik").GetComponent<AudioSource>();
        klik.Play();
        SceneManager.LoadScene("tentang");
    }
    public void doExitGame()
    {
        klik = GameObject.Find("klik").GetComponent<AudioSource>();
        klik.Play();
        PlayerPrefs.DeleteKey("sesi");
        PlayerPrefs.DeleteKey("life");
        PlayerPrefs.DeleteKey("garuda");
        PlayerPrefs.DeleteKey("btnpilih");
        Application.Quit();

    }
    public void tidak()
    {

        GameObject.Find("popup").SetActive(false);

    }
    public void ok()
    {
        klik = GameObject.Find("klik").GetComponent<AudioSource>();
        klik.Play();
        GameObject.Find("PanelInfo").SetActive(false);
    }

    public void Pilih()
    {
        keluar.SetActive(false);
    }

    public void jalaninsuaradialog()
    {
        dialog = GameObject.Find("dialog").GetComponent<AudioSource>();
        dialog.Play();
    }

    public void lanjutAwal()
    {
        sesi = PlayerPrefs.GetInt("sesi");

        if(sesi >  1 ){
            menuAwal.SetActive(true);
            }else if (sesi == 1){
                play();
                Debug.Log("berhasil");
            }

        
    }
    public void map(){
        PlayerPrefs.SetInt("aceh",0);
        PlayerPrefs.SetInt("sumut",0);
        PlayerPrefs.SetInt("sumbar",0);
        PlayerPrefs.SetInt("gorontalo",0);
        PlayerPrefs.SetInt("riau",0);
        PlayerPrefs.SetInt("Kriau",0);
        PlayerPrefs.SetInt("lampung",0);
        PlayerPrefs.SetInt("bangka",0);
        PlayerPrefs.SetInt("sumsel",0);
        PlayerPrefs.SetInt("jambi",0);
        PlayerPrefs.SetInt("banten",0);
        PlayerPrefs.SetInt("dki",0);
        PlayerPrefs.SetInt("jabar",0);
        PlayerPrefs.SetInt("jateng",0);
        PlayerPrefs.SetInt("jatim",0);
        PlayerPrefs.SetInt("yogya",0);
        PlayerPrefs.SetInt("bali",0);
        PlayerPrefs.SetInt("ntb",0);
        PlayerPrefs.SetInt("ntt",0);
    }


}



