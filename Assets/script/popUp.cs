using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popUp : MonoBehaviour
{
    // Start is called before the first frame update
     [System.Serializable]
    public class infoBudaya{
        public string nama;
        public string provinsi;

        [TextArea]
        public string materi;
        

    }

   public GameObject Popupmenu;
   public GameObject info;
   public Image gambar;
    public Text Text , level;
    // string m_Path;
    public List<infoBudaya> aceh , sumut , riau , sumbar , jambi , kepRiau , bengkulu , sumsel , bangka , lampung , banten , dki , jabar , jatim , jateng , yogya , bali , ntb , ntt , kalbar , kalteng , kalsel , kaltim , kaltum , sulbar , sulsel , sultengga , sulteng , gorontalo , sulut , malut , maluku , papbar , papua;
    private int nilaiAcak;
	Text textInformasi , infoLevel , textInfo , judul;
    void Start()
    {
    	Debug.Log("Berhasil masuk GameObject");
    	int a = PlayerPrefs.GetInt("sesi");
        Text = GameObject.Find("Text").GetComponent<Text>();
        level = GameObject.Find("level").GetComponent<Text>();
        Popupmenu.SetActive(false);
        info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
//        Debug.Log("garuda = "+b);
        gambar = GameObject.Find("Sumut").GetComponent<Image>();
        gambar.enabled = false;


        if(a == 2){
        	info.SetActive(true);
        gambar = GameObject.Find("infoGambar").GetComponent<Image>();
        textInfo = GameObject.Find("textInfo").GetComponent<Text>();
        infoLevel = GameObject.Find("infoLevel").GetComponent<Text>();
        judul = GameObject.Find("Judul").GetComponent<Text>();
        textInfo.text = aceh[0].materi;
        infoLevel.text = aceh[0].provinsi;
        judul.text = aceh[0].nama;
         gambar.enabled = true;
        
        }else {
        	Debug.Log("gagal");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
