using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testpopup : MonoBehaviour
{

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
    
 
 void Update(){
    level = GameObject.Find("level").GetComponent<Text>();
        //Popupmenu.SetActive(false);
        //info.SetActive(false);
       // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        gambar = GameObject.Find("aceh").GetComponent<Image>();
       // gambar.enabled = false;

       // level.text = "Provinsi Aceh";
 }

    public void btn1()
    {
        int a = PlayerPrefs.GetInt("aceh");
        int ego = PlayerPrefs.GetInt("ego");
        Debug.Log("aceh = "+a);
        //PlayerPrefs.SetInt("ego",1);
        Debug.Log("ego nya "+ego);
        // PlayerPrefs.SetInt("sesi",2);
         if(a == 0 && ego == 0){
        PlayerPrefs.SetInt("btnpilih", 1);
        Popupmenu.SetActive(true);
        Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Aceh";

        }else {
        info.SetActive(true);
      
         gambar = GameObject.Find("infoGambar").GetComponent<Image>();
        textInfo = GameObject.Find("textInfo").GetComponent<Text>();
        infoLevel = GameObject.Find("infoLevel").GetComponent<Text>();
        judul = GameObject.Find("Judul").GetComponent<Text>();
        textInfo.text = aceh[0].materi;
        infoLevel.text = aceh[0].provinsi;
        judul.text = aceh[0].nama;
         gambar.enabled = true;
        


        }
        // if (PlayerPrefs)

    }
    public void btn2()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");

        // PlayerPrefs.SetInt("sesi",2);
//         // level = GameObject.Find("level").GetComponent<Text>();
//         // Popupmenu.SetActive(false);
//         // info.SetActive(false);
//         // int b = PlayerPrefs.GetInt("garuda");
//         // Debug.Log("garuda = "+b);
//         // gambar = GameObject.Find("aceh").GetComponent<Image>();
//         // gambar.enabled = false;

//         if(a == 2 && ego == 1){
            PlayerPrefs.SetInt("btnpilih", 2);
            Popupmenu.SetActive(true);
            level.text = "Provinsi Sumatra Utara";
            Text.text = "Apakah anda siap melawan EGO ?";
//         }else{
// //            
//             info.SetActive(true);
//         gambar = GameObject.Find("Sumut").GetComponent<Image>();

//         textInfo = GameObject.Find("textInfo").GetComponent<Text>();
//         infoLevel = GameObject.Find("infoLevel").GetComponent<Text>();
//         judul = GameObject.Find("Judul").GetComponent<Text>();
//         textInfo.text = sumut[0].materi;
//         infoLevel.text = sumut[0].provinsi;
//         judul.text = sumut[0].nama;
//         gambar.enabled = true;
        

        

    }
    public void btn3()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
  
            PlayerPrefs.SetInt("btnpilih", 3);
            Popupmenu.SetActive(true);
            level.text = "Provinsi Sumatra Barat";
            Text.text = "Apakah anda siap melawan EGO ?";
        }

    public void btn4()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 4);
            Popupmenu.SetActive(true);
            level.text = "Provinsi Riau";
            Text.text = "Apakah anda siap melawan EGO ?";
        

    }
    public void btn5()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 5);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Kepulauan Riau";
        

    }
    public void btn6()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 6);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Jambi";
        

    }
    public void btn7()
    {
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        
            PlayerPrefs.SetInt("btnpilih", 7);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Bengkulu";
        

    }
    public void btn8()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        
            PlayerPrefs.SetInt("btnpilih", 8);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Sumatra Selatan";
        
    }
    public void btn9()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        
            PlayerPrefs.SetInt("btnpilih", 9);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Bangka Belitung";
        

    }
    public void btn10()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        
            PlayerPrefs.SetInt("btnpilih", 10);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Lampung";
        

    }
    public void btn11()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        
            PlayerPrefs.SetInt("btnpilih", 11);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Banten";
        

    }
    public void btn12()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        
            PlayerPrefs.SetInt("btnpilih", 12);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi DKI Jakarta";
        

    }
    public void btn13()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        
            PlayerPrefs.SetInt("btnpilih", 13);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Jawa Barat";
        

    }
    public void btn14()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 14);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Jawa Tengah";
        
    }
    public void btn15()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        
            PlayerPrefs.SetInt("btnpilih", 15);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi DIY Yogyakarta";
        

    }
    public void btn16()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");


        
            PlayerPrefs.SetInt("btnpilih", 16);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Jawa Timur";
        

    }
    public void btn17()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 17);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Bali";
        

    }
    public void btn18()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 18);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Nusa Tenggara Barat";
        

    }
    public void btn19()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 19);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Nusa Tenggara Timur";
        

    }
    public void btn20()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 20);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Kalimantan Barat";

    }
    public void btn21()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 21);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Kalimantan Tengah";
        

    }
    public void btn22()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 22);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Kalimantan Selatan";
        

    }
    public void btn23()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 23);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Kalimantan Timur";
        

    }
    public void btn24()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 24);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Kalimantan Utara";
        

    }
    public void btn25()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 25);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Sulawesi Barat";
        

    }
    public void btn26()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 26);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Sulawesi Selatan";
        

    }
    public void btn27()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 27);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Sulawesi Tenggara";
        

    }
    public void btn28()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

       
            PlayerPrefs.SetInt("btnpilih", 28);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Sulawesi Tengah";
        

    }
    public void btn29()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 29);
            Popupmenu.SetActive(true);
        Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Gorontalo";
        

    }
    public void btn30()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

       
            PlayerPrefs.SetInt("btnpilih", 30);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Sulawesi Utara";
        

    }
    public void btn31()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 31);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Maluku Utara";
        

    }
    public void btn32()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 32);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Maluku";
        

    }
    public void btn33()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 33);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Papua Barat";
        

    }
    public void btn34()
    {
        int a = PlayerPrefs.GetInt("sesi");
        int ego = PlayerPrefs.GetInt("ego");
        // level = GameObject.Find("level").GetComponent<Text>();
        // Popupmenu.SetActive(false);
        // info.SetActive(false);
        // int b = PlayerPrefs.GetInt("garuda");
        // Debug.Log("garuda = "+b);
        // gambar = GameObject.Find("aceh").GetComponent<Image>();
        // gambar.enabled = false;

        
            PlayerPrefs.SetInt("btnpilih", 34);
            Popupmenu.SetActive(true);
            Text.text = "Apakah anda siap melawan EGO ?";
        level.text = "Provinsi Papua";


    }

    public void ok(){
        GameObject.Find("PanelInfo").SetActive(false);
        // acehImage.enabled = false;
        gambar.enabled = false;
    }


}
