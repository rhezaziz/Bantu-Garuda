using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cobacoba : MonoBehaviour
{
     [System.Serializable]
    public class infoBudaya{
        public string nama;
        public string provinsi;

        [TextArea]
        public string materi;
        

    }
     public List<infoBudaya> aceh1 , sumut1 , riau1 , sumbar1 , jambi1 , kepRiau1 , bengkulu1 , sumsel1 , bangka1 , lampung1 , banten1 , dki1 , jabar1 , jatim1 , jateng1 , yogya1 , bali1 , ntb1 , ntt1 , kalbar1 , kalteng1 , kalsel1 , kaltim1 , kaltum1 , sulbar1 , sulsel1 , sultengga1 , sulteng1 , gorontalo1 , sulut1 , malut1 , maluku1 , papbar1 , papua1;
    public GameObject Lvl1, Lvl2, Lvl3, Lvl4, Lvl5, Lvl6, Lvl7, Lvl8, Lvl9, Lvl10, Lvl11, Lvl12, Lvl13, Lvl14, Lvl15, Lvl16, Lvl17, Lvl18, Lvl19 , Lvl20 , Lvl21 , Lvl22 , Lvl23 , Lvl24 , Lvl25 , Lvl26 , Lvl27 , Lvl28 , Lvl29 , Lvl30 , Lvl31 , Lvl32 , Lvl33 , Lvl34;
    public GameObject Popupmenu , info;
    public Image mapSumatera , mapJawa , mapKalimantan , mapPapua; 
    public Animator animSumatra , animJawa , animKalimantan , animPapua;
    int animasi , ego  , sesi , pop;
    Text nilai;
    
    Text textInformasi , infoLevel , textInfo , judul;

     Image aceh, sumut , riau, sumbar, jambi, kepRiau, bengkulu, sumsel, bangka, lampung, banten, dki, jabar, jatim, jateng, yogya, bali, ntb, ntt, kalbar, kalteng, kalsel, kaltim, kaltum, sulbar, sulsel, sultengga, sulteng, gorontalo, sulut, malut, maluku, papbar, papua;
    //gambar
     Image mapAceh , mapSumut , mapSumbar , mapRiau , mapKriau , mapJambi , mapGorontalo , mapSumsel , mapBangka , mapLampung , mapBanten , mapDki , mapJabar , mapJateng , mapYogya , mapJatim , mapBali , mapNtb , mapNtt;
    public GameObject ManageAnim;

    // Start is called before the first frame update
    void Start()
    {
        int sumselMap = PlayerPrefs.GetInt("sumsel");
    int acehMap = PlayerPrefs.GetInt("aceh");
    
        
        int gorontaloMap = PlayerPrefs.GetInt("gorontalo");
        int sumbarMap = PlayerPrefs.GetInt("sumbar");
        int sumutMap = PlayerPrefs.GetInt("sumut");
        int bangkaMap = PlayerPrefs.GetInt("bangka");
        int jambiMap = PlayerPrefs.GetInt("jambi");
        int riauMap = PlayerPrefs.GetInt("riau");
        int kRiauMap = PlayerPrefs.GetInt("Kriau");
        int lampungMap = PlayerPrefs.GetInt("lampung");
        int bantenMap = PlayerPrefs.GetInt("banten");
        int dkiMap = PlayerPrefs.GetInt("dki");
        int jabarMap = PlayerPrefs.GetInt("jabar");
        int jatengMap = PlayerPrefs.GetInt("jateng");
        int yogyaMap = PlayerPrefs.GetInt("yogya");
        int jatimMap = PlayerPrefs.GetInt("jatim");
        int baliMap = PlayerPrefs.GetInt("bali");
        int ntbMap = PlayerPrefs.GetInt("ntb");
        int nttMap = PlayerPrefs.GetInt("ntt");
        //PlayerPrefs.SetInt("sesi",34);
        Popupmenu.SetActive(false);
        ego = PlayerPrefs.GetInt("ego");
        int a = PlayerPrefs.GetInt("garuda");
        int b = PlayerPrefs.GetInt("life");
        sesi = PlayerPrefs.GetInt("sesi");
        animasi = PlayerPrefs.GetInt("Animasi");
         
        pop = PlayerPrefs.GetInt("pop");
        PlayerPrefs.SetInt("ego",0);
        PlayerPrefs.SetInt("pop",0);
        Debug.Log("AcehMap = "+acehMap);
        Debug.Log("ego = "+ego);
        Debug.Log("sesi = "+ sesi);
        Debug.Log("pop = "+pop);
        Debug.Log("animasi = "+animasi);
        // Debug.Log("");

        int garuda = PlayerPrefs.GetInt("garuda");
         mapSumatera = GameObject.Find("Image").GetComponent<Image>();
         mapJawa = GameObject.Find("Jawa").GetComponent<Image>();
         mapKalimantan = GameObject.Find("Kalimantan").GetComponent<Image>();
          mapPapua = GameObject.Find("papua").GetComponent<Image>();
          mapAceh = GameObject.Find("acehHijau").GetComponent<Image>();
        mapSumut = GameObject.Find("sumutHijau").GetComponent<Image>();
        mapSumbar = GameObject.Find("sumbarHijau").GetComponent<Image>();
        mapRiau = GameObject.Find("riauHijau").GetComponent<Image>();
        mapKriau = GameObject.Find("kRiauHijau").GetComponent<Image>();
        mapJambi = GameObject.Find("jambiHijau").GetComponent<Image>();
        mapGorontalo = GameObject.Find("gorontaloHijau").GetComponent<Image>();
        mapSumsel = GameObject.Find("sumselHijau").GetComponent<Image>();
        mapBangka = GameObject.Find("bangkaHijau").GetComponent<Image>();
        mapLampung = GameObject.Find("lampungHijau").GetComponent<Image>();
        mapBanten = GameObject.Find("bantenHijau").GetComponent<Image>();
        mapDki = GameObject.Find("dkiHijau").GetComponent<Image>();
        mapJabar = GameObject.Find("jabarHijau").GetComponent<Image>();
        mapJateng = GameObject.Find("jatengHijau").GetComponent<Image>();
        mapYogya = GameObject.Find("diyHijau").GetComponent<Image>();
        mapJatim = GameObject.Find("jatimHijau").GetComponent<Image>();
        mapBali = GameObject.Find("baliHijau").GetComponent<Image>();
        mapNtb = GameObject.Find("ntbHijau").GetComponent<Image>();
        mapNtt = GameObject.Find("nttHijau").GetComponent<Image>();
          // gambarGaruda = GameObject.Find("Garuda").GetComponent<Im>();
          riau = GameObject.Find("Riau").GetComponent<Image>();
          sumut = GameObject.Find("Sumut").GetComponent<Image>();
          aceh = GameObject.Find("infoGambar").GetComponent<Image>();
        sumbar = GameObject.Find("sumbar").GetComponent<Image>();
        jambi = GameObject.Find("jambi").GetComponent<Image>();
        kepRiau = GameObject.Find("kepRiau").GetComponent<Image>();
        bengkulu = GameObject.Find("bengkulu").GetComponent<Image>();
        sumsel = GameObject.Find("sumsel").GetComponent<Image>();
        bangka = GameObject.Find("bangka").GetComponent<Image>();
        lampung = GameObject.Find("lampung").GetComponent<Image>();
        banten = GameObject.Find("banten").GetComponent<Image>();
        dki = GameObject.Find("dki").GetComponent<Image>();
        jabar = GameObject.Find("jabar").GetComponent<Image>();
        jatim = GameObject.Find("jatim").GetComponent<Image>();
        jateng = GameObject.Find("jateng").GetComponent<Image>();
        yogya = GameObject.Find("yogya").GetComponent<Image>();
        bali = GameObject.Find("bali").GetComponent<Image>();
        ntb = GameObject.Find("ntb").GetComponent<Image>();
        ntt = GameObject.Find("ntt").GetComponent<Image>();
        kalbar = GameObject.Find("kalbar").GetComponent<Image>();
        kalteng = GameObject.Find("kalteng").GetComponent<Image>();
        kalsel = GameObject.Find("kalsel").GetComponent<Image>();
        kaltim = GameObject.Find("kaltim").GetComponent<Image>();
        kaltum = GameObject.Find("kaltum").GetComponent<Image>();
        sulbar = GameObject.Find("sulbar").GetComponent<Image>();
        sulsel = GameObject.Find("sulsel").GetComponent<Image>();
        sultengga = GameObject.Find("sultengga").GetComponent<Image>();
        sulteng = GameObject.Find("sulteng").GetComponent<Image>();
        gorontalo = GameObject.Find("gorontalo").GetComponent<Image>();
        sulut = GameObject.Find("sulut").GetComponent<Image>();
        malut = GameObject.Find("malut").GetComponent<Image>();
        maluku = GameObject.Find("maluku").GetComponent<Image>();
        papbar = GameObject.Find("papbar").GetComponent<Image>();
        papua = GameObject.Find("papua1").GetComponent<Image>();


        

        //nambah gambar

        textInfo = GameObject.Find("textInfo").GetComponent<Text>();
        infoLevel = GameObject.Find("infoLevel").GetComponent<Text>();
        judul = GameObject.Find("Judul").GetComponent<Text>();
        



         nilai = GameObject.Find("Nilai").GetComponent<Text>();
        Debug.Log("garuda = "+a);
        Debug.Log("SESI = "+ sesi);

        nilai.text = "X "+garuda;


        info.SetActive(false);
        
        // mapSumatera.enabled = true;
       
        ManageAnim.SetActive(false);
        mapSumatera.enabled = true;
        


        // Debug.Log("Animasi = "+ animasi );
        // Debug.Log("Ego = "+ ego );
        // Debug.Log("aceh = +"+ acehMap);
        // Debug.Log("sumut = +"+ sumutMap);
        // Debug.Log("sumbar = +"+ sumbarMap);
        // Debug.Log("riau = +"+ riauMap);
        // Debug.Log("Kriau = +"+ kRiauMap);
        // Debug.Log("jambi = +"+ jambiMap);
        // Debug.Log("gorontalo = +"+ gorontaloMap);
        // Debug.Log("bangka = +"+ bangkaMap);
        // Debug.Log("sumsel = +"+ sumselMap);
        // Debug.Log("lampung = +"+ lampungMap);


        if(acehMap == 2){
        	mapAceh.enabled = true;
        }
        if(sumutMap == 1){
        	mapSumut.enabled = true;
        }
        if(sumbarMap == 1){
        	mapSumbar.enabled = true;
        }
        if(sumselMap == 1){
        	mapSumsel.enabled = true;
        }
        if(gorontaloMap == 1){
        	mapGorontalo.enabled = true;

        }
        if(jambiMap == 1){
        	mapJambi.enabled = true;
        }
        if(lampungMap == 1){
        	mapLampung.enabled = true;
        }
        if(bangkaMap == 1){
        	mapBangka.enabled = true;
        }
        if(riauMap == 1){
        	mapRiau.enabled = true;
        }
        if(kRiauMap == 1){
        	mapKriau.enabled = true;
        }
        if(bantenMap == 1){
        	mapBanten.enabled = true;
        }
        if(dkiMap == 1){
        	mapDki.enabled = true;
        }
        if(jabarMap == 1){
        	mapJabar.enabled = true;
        }
        if(jatengMap == 1){
        	mapJateng.enabled = true;
        }
        if(yogyaMap == 1){
        	mapYogya.enabled = true;
        }
        if(jatimMap == 1){
        	mapJatim.enabled = true;
        }
        if(baliMap == 1){
        	mapBali.enabled = true;
        }
        if(ntbMap == 1){
        	mapNtb.enabled = true;
        }
        if(nttMap == 1){
        	mapNtt.enabled = true;
        }
//          if (sesi == 0 || sesi == 1 )
//         {
//             Lvl1.SetActive(true);


//             if(ego == 1 && pop == 1){
//         info.SetActive(true);
//         textInfo.text = aceh1[0].materi;
//         infoLevel.text = aceh1[0].provinsi;
//         judul.text = aceh1[0].nama;
//         aceh.enabled = true;
            
//             }
            
//           // mapLevel1.enabled = true;

//         }else if(sesi == 2){
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
// //            mapSumatera.enabled(true);
//             animSumatra.SetBool("sumatraHijau", true);


//             if(ego == 2 && pop == 1){
//         info.SetActive(true);
//         textInfo.text = sumut1[0].materi;
//         infoLevel.text = sumut1[0].provinsi;
//         judul.text = sumut1[0].nama;
//         sumut.enabled = true;
            
//         }

//             //mapLevel1.enabled = true;

//         }
//         else if (sesi == 3)
//         {   
            
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl4.SetActive(true);
//             animSumatra.SetBool("sumut",true);

//             if(ego == 3 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = sumbar1[0].materi;
//         infoLevel.text = sumbar1[0].provinsi;
//         judul.text = sumbar1[0].nama;
//         sumbar.enabled = true;
//             }
//         }
//         else if (sesi == 4)
//         {
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             animSumatra.SetBool("sumbar",true);
//              if(ego == 4 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = riau1[0].materi;
//         infoLevel.text = riau1[0].provinsi;
//         judul.text = riau1[0].nama;
//         riau.enabled = true;
//             }

        
//         }
//         else if (sesi == 5){
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             animSumatra.SetBool("riau",true);
//              if(ego == 5 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = kepRiau1[0].materi;
//         infoLevel.text = kepRiau1[0].provinsi;
//         judul.text = kepRiau1[0].nama;
//         kepRiau.enabled = true;
//             }
//         }
//         else if (sesi == 6)
//         {
            
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             animSumatra.SetBool("kRiau",true);

//              if(ego == 6 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = jambi1[0].materi;
//         infoLevel.text = jambi1[0].provinsi;
//         judul.text = jambi1[0].nama;
//         jambi.enabled = true;
//             }

//         }
//         else if (sesi == 7)
//         {
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             animSumatra.SetBool("jambi",true);
//             if(ego == 7 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = bengkulu1[0].materi;
//         infoLevel.text =  bengkulu1[0].provinsi;
//         judul.text = bengkulu1[0].nama;
//         bengkulu.enabled = true;
//             }
//         }
//         else if (sesi == 8)
//         {
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             animSumatra.SetBool("gorontalo",true);
//             if(ego == 8 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = sumsel1[0].materi;
//         infoLevel.text = sumsel1[0].provinsi;
//         judul.text = sumsel1[0].nama;
//         sumsel.enabled = true;
//             }
//         }
       
         
//         else if (sesi == 9)
//         {
//             Lvl1.SetActive(true);
// //            mapLevel1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             animSumatra.SetBool("sumsel",true);
//             if(ego == 9 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = bangka1[0].materi;
//         infoLevel.text = bangka1[0].provinsi;
//         judul.text = bangka1[0].nama;
//         bangka.enabled = true;
//             }
//            // Lvl10.SetActive(true);
//         }
//         else if (sesi == 10)
//         {
//         // mapSumatera.enabled = true;   
//             // if(animasi == 0){
         
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             animSumatra.SetBool("bangka",true);
//             if(ego == 10 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = lampung1[0].materi;
//         infoLevel.text = lampung1[0].provinsi;
//         judul.text = lampung1[0].nama;
//         lampung.enabled = true;
//             }
// //            
//         }
//         else if (sesi == 11)
//         {
//             // mapSumatera.enabled = true;
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             animSumatra.SetBool("lampung",true);
//             if(ego == 11 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = banten1[0].materi;
//         infoLevel.text = banten1[0].provinsi;
//         judul.text = banten1[0].nama;
//         banten.enabled = true;
//             }
//           //  Lvl12.SetActive(true);
//         }
//         else if (sesi == 12)
//         {
//             mapJawa.enabled = true;
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);

//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             animSumatra.SetBool("lampung",true);
//             animJawa.SetBool("JawaAnim",true);
//             if(ego == 12 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = dki1[0].materi;
//         infoLevel.text = dki1[0].provinsi;
//         judul.text = dki1[0].nama;
//         dki.enabled = true;
//             }
//         //    Lvl13.SetActive(true);
//         }
//         else if (sesi == 13)
//         {
//              mapJawa.enabled = true;
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);

//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             animJawa.SetBool("jakarta",true);
//             animSumatra.SetBool("lampung",true);
//             if(ego == 13 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = jabar1[0].materi;
//         infoLevel.text = jabar1[0].provinsi;
//         judul.text = jabar1[0].nama;
//         jabar.enabled = true;
//             }
//          //   Lvl14.SetActive(true);
//         }
//         else if (sesi == 14)
//         {
//             mapJawa.enabled = true;
//             Lvl1.SetActive(true);

//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             animJawa.SetBool("jabar",true);
//             animSumatra.SetBool("lampung",true);
//             if(ego == 14 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = jateng1[0].materi;
//         infoLevel.text = jateng1[0].provinsi;
//         judul.text = jateng1[0].nama;
//         jateng.enabled = true;
//             }
//         //    Lvl15.SetActive(true);
//         }
//         else if (sesi == 15)
//         {
//             mapJawa.enabled = true;
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);

//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             animSumatra.SetBool("lampung",true);
//             animJawa.SetBool("jateng",true);
//             if(ego == 15 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = yogya1[0].materi;
//         infoLevel.text = yogya1[0].provinsi;
//         judul.text = yogya1[0].nama;
//         yogya.enabled = true;
//             }
//         //    Lvl16.SetActive(true);
//         }
//         else if (sesi == 16)
//         {
//             mapJawa.enabled = true;
//             Lvl1.SetActive(true);

//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             animJawa.SetBool("yogya",true);
//             animSumatra.SetBool("lampung",true);
//             if(ego == 16 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = jatim1[0].materi;
//         infoLevel.text = jatim1[0].provinsi;
//         judul.text = jatim1[0].nama;
//         jatim.enabled = true;
//             }
//         //    Lvl17.SetActive(true);
//         }
//         else if (sesi == 17)
//         {
//             mapJawa.enabled = true;
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             animJawa.SetBool("jatim",true);
//             animSumatra.SetBool("lampung",true);
//             if(ego == 17 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = bali1[0].materi;
//         infoLevel.text = bali1[0].provinsi;
//         judul.text = bali1[0].nama;
//         bali.enabled = true;
//             }
//        //     Lvl18.SetActive(true);
//         }
//         else if (sesi == 18)
//         {
//             mapJawa.enabled = true;
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             Lvl18.SetActive(true);
//             animJawa.SetBool("bali",true);
//             animSumatra.SetBool("lampung",true);
//             if(ego == 18 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = ntb1[0].materi;
//         infoLevel.text = ntb1[0].provinsi;
//         judul.text = ntb1[0].nama;
//         ntb.enabled = true;
//             }
            
//         }
//         else if (sesi == 19)
//         {
//             mapJawa.enabled = true;
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             Lvl18.SetActive(true);
//             Lvl19.SetActive(true);
//             animSumatra.SetBool("lampung",true);
//             animJawa.SetBool("ntb",true);
//             if(ego == 19 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = ntt1[0].materi;
//         infoLevel.text = ntt1[0].provinsi;
//         judul.text = ntt1[0].nama;
//         ntt.enabled = true;
//             }
            
//         }
//         else if (sesi == 20)
//         {

//             mapJawa.enabled = true;
//             //}else{ 

//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             Lvl18.SetActive(true);
//             Lvl19.SetActive(true);
//             Lvl20.SetActive(true);
//             animJawa.SetBool("ntt",true);
//             animSumatra.SetBool("lampung",true);
//            // animJawa.SetBool("JawaAnim", false);
//             ManageAnim.SetActive(false);
//             if(ego == 20 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = kalbar1[0].materi;
//         infoLevel.text = kalbar1[0].provinsi;
//         judul.text = kalbar1[0].nama;
//         kalbar.enabled = true;
//             }

//             //}
//         }
//         else if (sesi == 21)
//         {
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             Lvl18.SetActive(true);
//             Lvl19.SetActive(true);
//             Lvl20.SetActive(true);
//             Lvl21.SetActive(true);
//             animKalimantan.SetBool("KaliAnim",true);
//             animSumatra.SetBool("lampung",true);
//             animJawa.SetBool("ntt",true);

//             mapJawa.enabled = true;
//             mapKalimantan.enabled = true;
//             // mapSumatera.enabled = true;
//             if(ego == 21 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = kalteng1[0].materi;
//         infoLevel.text = kalteng1[0].provinsi;
//         judul.text = kalteng1[0].nama;
//         kalteng.enabled = true;
//             }
//         }
//         else if (sesi == 22)
//         {
//             mapJawa.enabled = true;
//             mapKalimantan.enabled = true;
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             Lvl18.SetActive(true);
//             Lvl19.SetActive(true);
//             Lvl20.SetActive(true);
//             Lvl21.SetActive(true);
//             Lvl22.SetActive(true);
//             animKalimantan.SetBool("kalteng",true);
//             animSumatra.SetBool("lampung",true);
//             animJawa.SetBool("ntt",true);
//             if(ego == 22 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = kalsel1[0].materi;
//         infoLevel.text = kalsel1[0].provinsi;
//         judul.text = kalsel1[0].nama;
//         kalsel.enabled = true;
//             }
            
//         }
//         else if (sesi == 23)
//         {
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             Lvl18.SetActive(true);
//             Lvl19.SetActive(true);
//             Lvl20.SetActive(true);
//             Lvl21.SetActive(true);
//             Lvl22.SetActive(true);
//             Lvl23.SetActive(true);
//             mapJawa.enabled = true;
//             mapKalimantan.enabled = true;
//             animKalimantan.SetBool("kalsel",true);
//             animSumatra.SetBool("lampung",true);
//             animJawa.SetBool("ntt",true);
//             if(ego == 23 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = kaltim1[0].materi;
//         infoLevel.text = kaltim1[0].provinsi;
//         judul.text = kaltim1[0].nama;
//         kaltim.enabled = true;
//             }
//         }
//         else if (sesi == 24)
//         {
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             Lvl18.SetActive(true);
//             Lvl19.SetActive(true);
//             Lvl20.SetActive(true);
//             Lvl21.SetActive(true);
//             Lvl22.SetActive(true);
//             Lvl23.SetActive(true);
//             Lvl24.SetActive(true);
//             animKalimantan.SetBool("kaltim",true);
//             mapJawa.enabled = true;
//             mapKalimantan.enabled = true;
//             animSumatra.SetBool("lampung",true);
//             animJawa.SetBool("ntt",true);
//             if(ego == 24 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = kaltum1[0].materi;
//         infoLevel.text = kaltum1[0].provinsi;
//         judul.text = kaltum1[0].nama;
//         kaltum.enabled = true;
//             }
//         }
//         else if (sesi == 25)
//         {
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             Lvl18.SetActive(true);
//             Lvl19.SetActive(true);
//             Lvl20.SetActive(true);
//             Lvl21.SetActive(true);
//             Lvl22.SetActive(true);
//             Lvl23.SetActive(true);
//             Lvl24.SetActive(true);
//             Lvl25.SetActive(true);
//             animKalimantan.SetBool("kalut",true);
//             mapJawa.enabled = true;
//             mapKalimantan.enabled = true;
//             animSumatra.SetBool("lampung",true);
//             animJawa.SetBool("ntt",true);
//             if(ego == 25 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = sulbar1[0].materi;
//         infoLevel.text = sulbar1[0].provinsi;
//         judul.text = sulbar1[0].nama;
//         sulbar.enabled = true;
//             }
//         }
//         else if (sesi == 26)
//         {
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             Lvl18.SetActive(true);
//             Lvl19.SetActive(true);
//             Lvl20.SetActive(true);
//             Lvl21.SetActive(true);
//             Lvl22.SetActive(true);
//             Lvl23.SetActive(true);
//             Lvl24.SetActive(true);
//             Lvl25.SetActive(true);
//             Lvl26.SetActive(true);
//             animKalimantan.SetBool("sulbar",true);
//             mapJawa.enabled = true;
//             mapKalimantan.enabled = true;
//             animSumatra.SetBool("lampung",true);
//             animJawa.SetBool("ntt",true);
//             if(ego == 26 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = sulsel1[0].materi;
//         infoLevel.text = sulsel1[0].provinsi;
//         judul.text = sulsel1[0].nama;
//         sulsel.enabled = true;
//             }
//         }
//         else if (sesi == 27)
//         {
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             Lvl18.SetActive(true);
//             Lvl19.SetActive(true);
//             Lvl20.SetActive(true);
//             Lvl21.SetActive(true);
//             Lvl22.SetActive(true);
//             Lvl23.SetActive(true);
//             Lvl24.SetActive(true);
//             Lvl25.SetActive(true);
//             Lvl26.SetActive(true);
//             Lvl27.SetActive(true);
//             animKalimantan.SetBool("sulsel",true);
//             mapJawa.enabled = true;
//             mapKalimantan.enabled = true;
//             animSumatra.SetBool("lampung",true);
//             animJawa.SetBool("ntt",true);
//             if(ego == 27 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = sultengga1[0].materi;
//         infoLevel.text = sultengga1[0].provinsi;
//         judul.text = sultengga1[0].nama;
//         sultengga.enabled = true;
//             }
//         }
//         else if (sesi == 28)
//         {
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             Lvl18.SetActive(true);
//             Lvl19.SetActive(true);
//             Lvl20.SetActive(true);
//             Lvl21.SetActive(true);
//             Lvl22.SetActive(true);
//             Lvl23.SetActive(true);
//             Lvl24.SetActive(true);
//             Lvl25.SetActive(true);
//             Lvl26.SetActive(true);
//             Lvl27.SetActive(true);
//             Lvl28.SetActive(true);
//             animKalimantan.SetBool("sulTenggara",true);
//             mapJawa.enabled = true;
//             mapKalimantan.enabled = true;
//             animSumatra.SetBool("lampung",true);
//             animJawa.SetBool("ntt",true);
//             if(ego == 28 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = sulteng1[0].materi;
//         infoLevel.text = sulteng1[0].provinsi;
//         judul.text = sulteng1[0].nama;
//         sulteng.enabled = true;
//             }
//         }
//         else if (sesi == 29)
//         {
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             Lvl18.SetActive(true);
//             Lvl19.SetActive(true);
//             Lvl20.SetActive(true);
//             Lvl21.SetActive(true);
//             Lvl22.SetActive(true);
//             Lvl23.SetActive(true);
//             Lvl24.SetActive(true);
//             Lvl25.SetActive(true);
//             Lvl26.SetActive(true);
//             Lvl27.SetActive(true);
//             Lvl28.SetActive(true);
//             Lvl29.SetActive(true);
//             animKalimantan.SetBool("sulTengah",true);
//             mapJawa.enabled = true;
//             mapKalimantan.enabled = true;
//             animSumatra.SetBool("lampung",true);
//             animJawa.SetBool("ntt",true);
//             if(ego == 29 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = gorontalo1[0].materi;
//         infoLevel.text = gorontalo1[0].provinsi;
//         judul.text = gorontalo1[0].nama;
//         gorontalo.enabled = true;
//             }
//         }
//         else if (sesi == 30)
//         {
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             Lvl18.SetActive(true);
//             Lvl19.SetActive(true);
//             Lvl20.SetActive(true);
//             Lvl21.SetActive(true);
//             Lvl22.SetActive(true);
//             Lvl23.SetActive(true);
//             Lvl24.SetActive(true);
//             Lvl25.SetActive(true);
//             Lvl26.SetActive(true);
//             Lvl27.SetActive(true);
//             Lvl28.SetActive(true);
//             Lvl29.SetActive(true);
//             Lvl30.SetActive(true);
//             animKalimantan.SetBool("gorontalo",true);
//             mapJawa.enabled = true;
//             mapKalimantan.enabled = true;
//             animSumatra.SetBool("lampung",true);
//             animJawa.SetBool("ntt",true);
//             if(ego == 30){
//                 info.SetActive(true);
//         textInfo.text = sulut1[0].materi;
//         infoLevel.text = sulut1[0].provinsi;
//         judul.text = sulut1[0].nama;
//         sulut.enabled = true;
//             }
//         }
//         else if (sesi == 31)
//         {
//             // mapJawa.enabled = true;
//             // mapSumatera.enabled = true;
//             // mapKalimantan.enabled = true;
            
//           //  if(animasi == 2){
//          // mapLevel1.enabled = true;
//            Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             Lvl18.SetActive(true);
//             Lvl19.SetActive(true);
//             Lvl20.SetActive(true);
//             Lvl21.SetActive(true);
//             Lvl22.SetActive(true);
//             Lvl23.SetActive(true);
//             Lvl24.SetActive(true);
//             Lvl25.SetActive(true);
//             Lvl26.SetActive(true);
//             Lvl27.SetActive(true);
//             Lvl28.SetActive(true);
//             Lvl29.SetActive(true);
//             Lvl30.SetActive(true);
//             Lvl31.SetActive(true);
//             animKalimantan.SetBool("sulut",true);
//             animSumatra.SetBool("lampung",true);
//             animJawa.SetBool("ntt",true);
//              mapJawa.enabled = true;
//             mapKalimantan.enabled = true;

//             // animSumatra.SetBool("malu",true);
//             if(ego == 31 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = malut1[0].materi;
//         infoLevel.text = malut1[0].provinsi;
//         judul.text = malut1[0].nama;
//         malut.enabled = true;
//             }
          
//         }
//         else if (sesi == 32)
//         {
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             Lvl18.SetActive(true);
//             Lvl19.SetActive(true);
//             Lvl20.SetActive(true);
//             Lvl21.SetActive(true);
//             Lvl22.SetActive(true);
//             Lvl23.SetActive(true);
//             Lvl24.SetActive(true);
//             Lvl25.SetActive(true);
//             Lvl26.SetActive(true);
//             Lvl27.SetActive(true);
//             Lvl28.SetActive(true);
//             Lvl29.SetActive(true);
//             Lvl30.SetActive(true);
//             Lvl31.SetActive(true);
//             Lvl32.SetActive(true);
//             animPapua.SetBool("malukuUtara", true);
//             mapJawa.enabled = true;
//             mapPapua.enabled = true;
//             mapKalimantan.enabled = true;
//             animKalimantan.SetBool("sulut",true);
//             animSumatra.SetBool("lampung",true);
//             animJawa.SetBool("ntt",true);
//             if(ego == 32 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = maluku1[0].materi;
//         infoLevel.text = maluku1[0].provinsi;
//         judul.text = maluku1[0].nama;
//         maluku.enabled = true;
//             }
//         }
//         else if (sesi == 33)
//         {
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             Lvl18.SetActive(true);
//             Lvl19.SetActive(true);
//             Lvl20.SetActive(true);
//             Lvl21.SetActive(true);
//             Lvl22.SetActive(true);
//             Lvl23.SetActive(true);
//             Lvl24.SetActive(true);
//             Lvl25.SetActive(true);
//             Lvl26.SetActive(true);
//             Lvl27.SetActive(true);
//             Lvl28.SetActive(true);
//             Lvl29.SetActive(true);
//             Lvl30.SetActive(true);
//             Lvl31.SetActive(true);
//             Lvl32.SetActive(true);
//             Lvl33.SetActive(true);
//            animPapua.SetBool("maluku", true);
//             mapJawa.enabled = true;
//             mapPapua.enabled = true;
//             mapKalimantan.enabled = true;
//             animKalimantan.SetBool("sulut",true);
//             animSumatra.SetBool("lampung",true);
//             animJawa.SetBool("ntt",true);
//             if(ego == 33 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = papbar1[0].materi;
//         infoLevel.text = papbar1[0].provinsi;
//         judul.text = papbar1[0].nama;
//         papbar.enabled = true;
//             }
//         }
//         else if (sesi == 34)
//         {
//             Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             Lvl18.SetActive(true);
//             Lvl19.SetActive(true);
//             Lvl20.SetActive(true);
//             Lvl21.SetActive(true);
//             Lvl22.SetActive(true);
//             Lvl23.SetActive(true);
//             Lvl24.SetActive(true);
//             Lvl25.SetActive(true);
//             Lvl26.SetActive(true);
//             Lvl27.SetActive(true);
//             Lvl28.SetActive(true);
//             Lvl29.SetActive(true);
//             Lvl30.SetActive(true);
//             Lvl31.SetActive(true);
//             Lvl32.SetActive(true);
//             Lvl33.SetActive(true);
//             Lvl34.SetActive(true);
//            animPapua.SetBool("papbar", true);
//             mapJawa.enabled = true;
//             mapPapua.enabled = true;
//             mapKalimantan.enabled = true;
//             animKalimantan.SetBool("sulut",true);
//             animSumatra.SetBool("lampung",true);
//             animJawa.SetBool("ntt",true);
//             if(ego == 34 && pop == 1){
//                 info.SetActive(true);
//         textInfo.text = papua1[0].materi;
//         infoLevel.text = papua1[0].provinsi;
//         judul.text = papua1[0].nama;
//         papua.enabled = true;
//             }
//         }else if (sesi == 35)
//         {
            
//             mapJawa.enabled = true;
//             mapSumatera.enabled = true;
//             mapKalimantan.enabled = true;
//             mapPapua.enabled = true;

//             // if(animasi == 3){
//          // mapLevel1.enabled = true;
//            Lvl1.SetActive(true);
//             Lvl2.SetActive(true);
//             Lvl3.SetActive(true);
//             Lvl4.SetActive(true);
//             Lvl5.SetActive(true);
//             Lvl6.SetActive(true);
//             Lvl7.SetActive(true);
//             Lvl8.SetActive(true);
//             Lvl9.SetActive(true);
//             Lvl10.SetActive(true);
//             Lvl11.SetActive(true);
//             Lvl12.SetActive(true);
//             Lvl13.SetActive(true);
//             Lvl14.SetActive(true);
//             Lvl15.SetActive(true);
//             Lvl16.SetActive(true);
//             Lvl17.SetActive(true);
//             Lvl18.SetActive(true);
//             Lvl19.SetActive(true);
//             Lvl20.SetActive(true);
//             Lvl21.SetActive(true);
//             Lvl22.SetActive(true);
//             Lvl23.SetActive(true);
//             Lvl24.SetActive(true);
//             Lvl25.SetActive(true);
//             Lvl26.SetActive(true);
//             Lvl27.SetActive(true);
//             Lvl28.SetActive(true);
//             Lvl29.SetActive(true);
//             Lvl30.SetActive(true);
//             Lvl31.SetActive(true);
//             Lvl32.SetActive(true);
//             Lvl33.SetActive(true);
//             Lvl34.SetActive(true);
//             ManageAnim.SetActive(true);
//             animPapua.SetBool("PapuaAnim", true);
//             animKalimantan.SetBool("sulut",true);
//             animSumatra.SetBool("lampung",true);
//             animJawa.SetBool("ntt",true);
          
//         }
//         else
//         {
//             Debug.Log("Jumlah Sesi ");
//             Debug.Log(sesi);
//         }
    }
    void Update()
    {

        if(Input.GetKey(KeyCode.Escape)){
             SceneManager.LoadScene("SampleScene");
        }
    }
    public void pindah(){
        animasi = PlayerPrefs.GetInt("Animasi");
        animasi += 1;
       PlayerPrefs.SetInt("Animasi", animasi);
        animSumatra.SetBool("sumatraHijau", false);
        animJawa.SetBool("JawaAnim",false);
        animKalimantan.SetBool("KaliAnim", false);
        animPapua.SetBool("PapuaAnim" , false);
        ManageAnim.SetActive(false);

    }

    public void ok(){
        ego = PlayerPrefs.GetInt("ego");
        sesi = PlayerPrefs.GetInt("sesi");
        int acehMap = PlayerPrefs.GetInt("aceh");
        Debug.Log("aceh nya 2");
        if(acehMap == 1){
            SceneManager.LoadScene("Game");
            Debug.Log("aceh nya 1");
            PlayerPrefs.SetInt("ego",1);
                // PlayerPrefs.SetInt("pop", 0);
                
            //  if(acehMap == 2)
                        
            // {
            //     GameObject.Find("PanelInfo").SetActive(false);  
            //     hilang();      
            // }
        }else {
        	Debug.Log("gagal");
        }
        //  if(sesi == 2){
        //     if(ego == 2){
        //         PlayerPrefs.SetInt("pop", 0);
        //         SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }
        //  if(sesi == 3){
        //     if(ego == 3){
        //         PlayerPrefs.SetInt("pop", 0);
        //         SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }
        //  if(sesi == 4){
        //     if(ego == 4){
        //         PlayerPrefs.SetInt("pop", 0);
        //         SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }
        //  if(sesi == 5){
        //     if(ego == 5){
        //          PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }
        //  if(sesi == 6){
        //     if(ego == 6){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }
        //  if(sesi == 7){
        //     if(ego == 7){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 8){
        //     if(ego == 8){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 9){
        //     if(ego == 9){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 10){
        //     if(ego == 10){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 11){
        //     if(ego == 11){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 12){
        //     if(ego == 12){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 13){
        //     if(ego == 13){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 14){
        //     if(ego == 14){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 15){
        //     if(ego == 15){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 16){
        //     if(ego == 16){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 17){
        //     if(ego == 17){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 18){
        //     if(ego == 18){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 19){
        //     if(ego == 19){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 20){
        //     if(ego == 20){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 21){
        //     if(ego == 21){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 22){
        //     if(ego == 22){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 23){
        //     if(ego == 23){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 24){
        //     if(ego == 24){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 25){
        //     if(ego == 25){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 26){
        //     if(ego == 26){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 27){
        //     if(ego == 27){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 28){
        //     if(ego == 28){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 29){
        //     if(ego == 29){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 30){
        //     if(ego == 30){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 31){
        //     if(ego == 31){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 32){
        //     if(ego == 32){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 33){
        //     if(ego == 33){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else if(sesi == 34){
        //     if(ego == 34){
        //         PlayerPrefs.SetInt("pop", 0);
        //          SceneManager.LoadScene("Game");         
        //     }else{
        //         GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();      
        //     }
        // }else {
        //     GameObject.Find("PanelInfo").SetActive(false);  
        //         hilang();     
       // }
        
        // acehImage.enabled = false;
        
    }

    public void hilang(){
       riau.enabled = false;
        aceh.enabled = false;
        sumut.enabled = false;
        
        sumbar.enabled = false;
        jambi.enabled = false;
        kepRiau.enabled = false;
        bengkulu.enabled = false;
        sumsel.enabled = false;
        bangka.enabled = false;
        lampung.enabled = false;
        banten.enabled = false;
        dki.enabled = false;
        jabar.enabled = false;
        jatim.enabled = false;
        jateng.enabled = false;
        yogya.enabled = false;
        bali.enabled = false;
        ntb.enabled = false;
        ntt.enabled = false;
        kalbar.enabled = false;
        kalteng.enabled = false;
        kalsel.enabled = false;
        kaltim.enabled = false;
        kaltum.enabled = false;
        sulbar.enabled = false;
        sulsel.enabled = false;
        sultengga.enabled = false;
        sulteng.enabled = false;
        gorontalo.enabled = false;
        sulut.enabled = false;
        malut.enabled = false;
        maluku.enabled = false;
        papbar.enabled = false;
        papua.enabled = false;
    }
}
