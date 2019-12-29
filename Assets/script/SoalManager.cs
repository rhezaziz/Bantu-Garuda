using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoalManager : MonoBehaviour {

    [System.Serializable]
    public class Soal
    {
        [TextArea]
        [Header("Soal")]
        public string soal;

        [Header("Pilihan untuk jawaban")]
        public string pilA;
        public string pilB, pilC, pilD;

        [Header("Kunci Jawaban")]
        public bool A;
        public bool B, C, D;

    }
    bool level1open, level2open, level3open, level4open, level5open, level6open, level7open, level8open, level9open, level10open, level11open, level12open, level13open, level14open, level15open, level16open, level17open, level18open;
    int session,sesssion , garuda ,sisa , pop,acehMap;
    public Text Level;
    public GameObject selesai;
    public GameObject Dialog;
    public GameObject btngede;
    public GameObject pause;
    public int skor = 0;
    public int waktu;
    public bool isImgOn;
    AudioSource salah,benar,boss,quiz;
    public Image gambar1;
    public Image gambar2;
    public Image gambar3;
    public Image gambar4;
    public Image gambarEgo;
    public Image hati1;
    public Image hati2;
    public Animator anim;
    public Image hati3;
    private int nilaiAcak;
    int sumselMap = PlayerPrefs.GetInt("sumsel");
        
        int gorontaloMap = PlayerPrefs.GetInt("gorontalo");
        int sumbarMap = PlayerPrefs.GetInt("sumbar");
        int sumutMap = PlayerPrefs.GetInt("sumut");
        int bangkaMap = PlayerPrefs.GetInt("bangka");
        int jambiMap = PlayerPrefs.GetInt("jambi");
        int riauMap = PlayerPrefs.GetInt("riau");
        int kRiauMap = PlayerPrefs.GetInt("Kriau");
        int lampungMap = PlayerPrefs.GetInt("lampung");
        int ego = PlayerPrefs.GetInt("ego");
   // public int jumlahsoal; //di if berdasarkan level
    Text textSoal, textA, textB, textC, textD, textWaktu,textsisa;
    public List<Soal> KumpulanSoal,aceh , sumut , riau , sumbar , jambi , kepRiau , bengkulu , sumsel , bangka , lampung , banten , dki , jabar , jatim , jateng , yogya , bali , ntb , ntt , kalbar , kalteng , kalsel , kaltim , kaltum , sulbar , sulsel , sultengga , sulteng , gorontalo , sulut , malut , maluku , papbar , papua;
    public List<Soal> acehEGo , sumutEgo , riauEgo , sumbarEgo , jambiEgo , kepRiauEgo , bengkuluEgo , sumselEgo , bangkaEgo , lampungEgo , bantenEgo , dkiEgo , jabarEgo , jatimEgo , jatengEgo , yogyaEgo , baliEgo , ntbEgo , nttEgo , kalbarEGo , kaltengEgo , kalselEgo , kaltimEgo , kaltumEGo , sulbarEgo , sulselEgo , sultenggaEgo , sultengEgo , gorontaloEgo , sulutEgo , malutEgo , malukuEgo , papbarEgo , papuaEgo;
    // Use this for initialization

    void Start () {

        // btngede.SetActive(false);
        // PlayerPrefs.SetInt("sesi", 34);
        // PlayerPrefs.SetInt("ego", 34);
        // ego = PlayerPrefs.GetInt("ego");
        // PlayerPrefs.SetInt("btnpilih", 34);
        btngede.SetActive(false);
        session =  PlayerPrefs.GetInt("btnpilih");
          
        pop = PlayerPrefs.GetInt("pop");

        sesssion = PlayerPrefs.GetInt("sesi");
        garuda = PlayerPrefs.GetInt("garuda");
        waktu = PlayerPrefs.GetInt("life");
        salah = GameObject.Find("salah").GetComponent<AudioSource>();
        benar = GameObject.Find("benar").GetComponent<AudioSource>();
        boss = GameObject.Find("boss").GetComponent<AudioSource>();
        quiz = GameObject.Find("quiz").GetComponent<AudioSource>();
        // Debug.Log("sesi = "+session);
        //Debug.Log("Ego " +ego);

        gambarEgo = GameObject.Find("GambarEgo").GetComponent<Image>();

        if (session == 1 || session == 0)
        {
            quiz.Play();
            KumpulanSoal = aceh;
             Level.text = "Provinsi Aceh";
            gambar1 = GameObject.Find("Aceh01").GetComponent<Image>();
            gambar2= GameObject.Find("Aceh02").GetComponent<Image>();
            gambar3 = GameObject.Find("Aceh03").GetComponent<Image>();
            gambar4 = GameObject.Find("Aceh04").GetComponent<Image>();
            Debug.Log("Session = " + session);

            if(ego == 1){
                KumpulanSoal = acehEGo;
                Debug.Log("EGO = "+ego);
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            }

        }
        else if (session == 2)
        {
            quiz.Play();
            KumpulanSoal = sumut;
            Level.text = "Provinsi Sumatera Utara";
            Debug.Log("Session = " + session);
            gambar1 = GameObject.Find("gambar1").GetComponent<Image>();
            gambar2= GameObject.Find("gambar2").GetComponent<Image>();
            gambar3 = GameObject.Find("gambar3").GetComponent<Image>();
            gambar4 = GameObject.Find("gambar4").GetComponent<Image>();

            if(ego == 2){
                KumpulanSoal = sumutEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            }

        }
        else if (session == 3)
        {
            quiz.Play();
            KumpulanSoal = sumbar;
            Level.text = "Provinsi Sumatera Barat";
            gambar1 = GameObject.Find("sumbar1").GetComponent<Image>();
            gambar2= GameObject.Find("sumbar2").GetComponent<Image>();
            gambar3 = GameObject.Find("sumbar3").GetComponent<Image>();
            gambar4 = GameObject.Find("sumbar4").GetComponent<Image>();
            if(ego == 3){
                KumpulanSoal = sumbarEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            }

        }else if(session == 4){
            quiz.Play();
            KumpulanSoal = riau;
            Level.text = "Provinsi Riau";
            gambar1 = GameObject.Find("Riau01").GetComponent<Image>();
            gambar2= GameObject.Find("Riau02").GetComponent<Image>();
            gambar3 = GameObject.Find("Riau03").GetComponent<Image>();
            gambar4 = GameObject.Find("Riau04").GetComponent<Image>();
            if(ego == 4){
                KumpulanSoal = riauEgo;
                quiz.Stop();
                boss.Play();

                gambarEgo.enabled = true;
           
            }

        }else if(session == 5){
            quiz.Play();
            KumpulanSoal = kepRiau;
            Level.text = "Provinsi Kepulauan Riau";
            gambar1 = GameObject.Find("kepRiau1").GetComponent<Image>();
            gambar2= GameObject.Find("kepRiau2").GetComponent<Image>();
            gambar3 = GameObject.Find("kepRiau3").GetComponent<Image>();
            gambar4 = GameObject.Find("kepRiau4").GetComponent<Image>();
            if(ego == 5){
                KumpulanSoal = kepRiauEgo;
                quiz.Stop();
                boss.Play();

                gambarEgo.enabled = true;
            
            }

        }else if(session == 6){
            quiz.Play();
            KumpulanSoal = jambi;
            Level.text = "Provinsi Jambi";
            gambar1 = GameObject.Find("jambi1").GetComponent<Image>();
            gambar2= GameObject.Find("jambi2").GetComponent<Image>();
            gambar3 = GameObject.Find("jambi3").GetComponent<Image>();
            gambar4 = GameObject.Find("jambi4").GetComponent<Image>();
            if(ego == 6){
                KumpulanSoal = jambiEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
           
            }

        }else if(session == 7){
            quiz.Play();
            KumpulanSoal = bengkulu;
            Level.text = "Provinsi Bengkulu";
            gambar1 = GameObject.Find("bengkulu1").GetComponent<Image>();
            gambar2= GameObject.Find("bengkulu2").GetComponent<Image>();
            gambar3 = GameObject.Find("bengkulu3").GetComponent<Image>();
            gambar4 = GameObject.Find("bengkulu4").GetComponent<Image>();
            if(ego == 7){
                KumpulanSoal = bengkuluEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }

        }else if(session == 8){
            quiz.Play();
            KumpulanSoal = sumsel;
            Level.text = "Provinsi Sumatera Selatan";
            gambar1 = GameObject.Find("sumsel1").GetComponent<Image>();
            gambar2= GameObject.Find("sumsel2").GetComponent<Image>();
            gambar3 = GameObject.Find("sumsel3").GetComponent<Image>();
            gambar4 = GameObject.Find("sumsel4").GetComponent<Image>();
            if(ego == 8){
                KumpulanSoal = sumselEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }

        }else if(session == 9){
            quiz.Play();
            KumpulanSoal = bangka;
            Level.text = "Provinsi Bangka Belitung";
            gambar1 = GameObject.Find("bangka1").GetComponent<Image>();
            gambar2= GameObject.Find("bangka2").GetComponent<Image>();
            gambar3 = GameObject.Find("bangka3").GetComponent<Image>();
            gambar4 = GameObject.Find("bangka4").GetComponent<Image>();
            if(ego == 9){
                KumpulanSoal = bangkaEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }

        }else if(session == 10){
            quiz.Play();
            KumpulanSoal = lampung;
            Level.text = "Provinsi Lampung";
            gambar1 = GameObject.Find("lampung1").GetComponent<Image>();
            gambar2= GameObject.Find("lampung2").GetComponent<Image>();
            gambar3 = GameObject.Find("lampung3").GetComponent<Image>();
            gambar4 = GameObject.Find("lampung4").GetComponent<Image>();
            if(ego == 10){
                KumpulanSoal = lampungEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }


        }else if(session == 11){
            quiz.Play();
            KumpulanSoal = banten;
            Level.text = "Provinsi Banten";
            gambar1 = GameObject.Find("banten1").GetComponent<Image>();
            gambar2= GameObject.Find("banten2").GetComponent<Image>();
            gambar3 = GameObject.Find("banten3").GetComponent<Image>();
            gambar4 = GameObject.Find("banten4").GetComponent<Image>();
            if(ego == 11){
                KumpulanSoal = bantenEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5


        }else if(session == 12){
            quiz.Play();
            KumpulanSoal = dki;
            Level.text = "Provinsi DKI Jakarta";
            gambar1 = GameObject.Find("dki1").GetComponent<Image>();
            gambar2= GameObject.Find("dki2").GetComponent<Image>();
            gambar3 = GameObject.Find("dki3").GetComponent<Image>();
            gambar4 = GameObject.Find("dki4").GetComponent<Image>();
            if(ego == 12){
                KumpulanSoal = dkiEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5

        }else if(session == 13){
            quiz.Play();
            KumpulanSoal = jabar;
            Level.text = "Provinsi Jawa Barat";
            gambar1 = GameObject.Find("jabar1").GetComponent<Image>();
            gambar2= GameObject.Find("jabar2").GetComponent<Image>();
            gambar3 = GameObject.Find("jabar3").GetComponent<Image>();
            gambar4 = GameObject.Find("jabar4").GetComponent<Image>();
            if(ego == 13){
                KumpulanSoal = jabarEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5

        }else if(session == 14){
            quiz.Play();
            KumpulanSoal = jateng;
            Level.text = "Provinsi Jawa Tengah";
            gambar1 = GameObject.Find("jateng1").GetComponent<Image>();
            gambar2= GameObject.Find("jateng2").GetComponent<Image>();
            gambar3 = GameObject.Find("jateng3").GetComponent<Image>();
            gambar4 = GameObject.Find("jateng4").GetComponent<Image>();
            if(ego == 14){
                KumpulanSoal = jatengEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5

        }else if(session == 15){
            quiz.Play();
            KumpulanSoal = yogya;
            Level.text = "Provinsi Daerah Istimewa Yogyakarta";
            gambar1 = GameObject.Find("yogya1").GetComponent<Image>();
            gambar2= GameObject.Find("yogya2").GetComponent<Image>();
            gambar3 = GameObject.Find("yogya3").GetComponent<Image>();
            gambar4 = GameObject.Find("yogya4").GetComponent<Image>();
            if(ego == 15){
                KumpulanSoal = yogyaEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5

        }else if(session == 16){
            quiz.Play();
            KumpulanSoal = jatim;
            Level.text = "Provinsi Jawa Timur";
            gambar1 = GameObject.Find("jatim1").GetComponent<Image>();
            gambar2= GameObject.Find("jatim2").GetComponent<Image>();
            gambar3 = GameObject.Find("jatim3").GetComponent<Image>();
            gambar4 = GameObject.Find("jatim4").GetComponent<Image>();
            if(ego == 16){
                KumpulanSoal = jatimEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5

        }else if(session == 17){
            quiz.Play();
            KumpulanSoal = bali;
            Level.text = "Provinsi Bali";
            gambar1 = GameObject.Find("bali1").GetComponent<Image>();
            gambar2= GameObject.Find("bali2").GetComponent<Image>();
            gambar3 = GameObject.Find("bali3").GetComponent<Image>();
            gambar4 = GameObject.Find("bali4").GetComponent<Image>();
            if(ego == 17){
                KumpulanSoal = baliEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5

        }else if(session == 18){
            quiz.Play();
            KumpulanSoal = ntb;
            Level.text = "Provinsi Nusa Tenggara Barat";
            gambar1 = GameObject.Find("ntb1").GetComponent<Image>();
            gambar2= GameObject.Find("ntb2").GetComponent<Image>();
            gambar3 = GameObject.Find("ntb3").GetComponent<Image>();
            gambar4 = GameObject.Find("ntb4").GetComponent<Image>();
            if(ego == 18){
                KumpulanSoal = ntbEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5

        }else if(session == 19){
            quiz.Play();
            KumpulanSoal = ntt;
            Level.text = "Provinsi Nusa Tenggara Timur";
            gambar1 = GameObject.Find("ntt1").GetComponent<Image>();
            gambar2= GameObject.Find("ntt2").GetComponent<Image>();
            gambar3 = GameObject.Find("ntt3").GetComponent<Image>();
            gambar4 = GameObject.Find("ntt4").GetComponent<Image>();
            if(ego == 19){
                KumpulanSoal = nttEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5

        }else if(session == 20){
            quiz.Play();
            KumpulanSoal = kalbar;
            Level.text = "Provinsi Kalimantan Barat";
            gambar1 = GameObject.Find("kalbar1").GetComponent<Image>();
            gambar2= GameObject.Find("kalbar2").GetComponent<Image>();
            gambar3 = GameObject.Find("kalbar3").GetComponent<Image>();
            gambar4 = GameObject.Find("kalbar4").GetComponent<Image>();
            if(ego == 20){
                KumpulanSoal = kalbarEGo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5
            //gambar6

        }else if(session == 21){
            quiz.Play();
            KumpulanSoal = kalteng;
            Level.text = "Provinsi Kalimantan Tengah";
            gambar1 = GameObject.Find("kalteng1").GetComponent<Image>();
            gambar2= GameObject.Find("kalteng2").GetComponent<Image>();
            gambar3 = GameObject.Find("kalteng3").GetComponent<Image>();
            gambar4 = GameObject.Find("kalteng4").GetComponent<Image>();
            if(ego == 21){
                KumpulanSoal = kaltengEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5
            //gambar6

        }else if(session == 22){
            quiz.Play();
            KumpulanSoal = kalsel;
            Level.text = "Provinsi Kalimantan Selatan";
            gambar1 = GameObject.Find("kalsel1").GetComponent<Image>();
            gambar2= GameObject.Find("kalsel2").GetComponent<Image>();
            gambar3 = GameObject.Find("kalsel3").GetComponent<Image>();
            gambar4 = GameObject.Find("kalsel4").GetComponent<Image>();
            if(ego == 22){
                KumpulanSoal = kalselEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5
            //gambar6

        }else if(session == 23){
            quiz.Play();
            KumpulanSoal = kaltim;
            Level.text = "Provinsi Kalimantan Timur";
            gambar1 = GameObject.Find("kaltim1").GetComponent<Image>();
            gambar2= GameObject.Find("kaltim2").GetComponent<Image>();
            gambar3 = GameObject.Find("kaltim3").GetComponent<Image>();
            gambar4 = GameObject.Find("kaltim4").GetComponent<Image>();
            if(ego == 23){
                KumpulanSoal = kaltimEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5
            //gambar6

        }else if(session == 24){
            quiz.Play();
            KumpulanSoal = kaltum;
            Level.text = "Provinsi Kalimantan Utara";
            gambar1 = GameObject.Find("kaltum1").GetComponent<Image>();
            gambar2= GameObject.Find("kaltum2").GetComponent<Image>();
            gambar3 = GameObject.Find("kaltum3").GetComponent<Image>();
            gambar4 = GameObject.Find("kaltum4").GetComponent<Image>();
            if(ego == 25){
                KumpulanSoal = kaltumEGo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5
            //gambar6

        }else if(session == 25){
            quiz.Play();
            KumpulanSoal = sulbar;
            Level.text = "Provinsi Sulawesi Barat";
            gambar1 = GameObject.Find("sulbar1").GetComponent<Image>();
            gambar2= GameObject.Find("sulbar2").GetComponent<Image>();
            gambar3 = GameObject.Find("sulbar3").GetComponent<Image>();
            gambar4 = GameObject.Find("sulbar4").GetComponent<Image>();
            if(ego == 25){
                KumpulanSoal = sulbarEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5
            //gambar6

        }else if(session == 26){
            quiz.Play();
            KumpulanSoal = sulsel;
            Level.text = "Provinsi Sulawesi Selatan";
            gambar1 = GameObject.Find("sulsel1").GetComponent<Image>();
            gambar2= GameObject.Find("sulsel2").GetComponent<Image>();
            gambar3 = GameObject.Find("sulsel3").GetComponent<Image>();
            gambar4 = GameObject.Find("sulsel4").GetComponent<Image>();
            if(ego == 26){
                KumpulanSoal = sulselEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5
            //gambar6

        }else if(session == 27){
            quiz.Play();
            KumpulanSoal = sultengga;
            Level.text = "Provinsi Sulawesi Tenggara";
            gambar1 = GameObject.Find("sultengga1").GetComponent<Image>();
            gambar2= GameObject.Find("sultengga2").GetComponent<Image>();
            gambar3 = GameObject.Find("sultengga3").GetComponent<Image>();
            gambar4 = GameObject.Find("sultengga4").GetComponent<Image>();
            if(ego == 27){
                KumpulanSoal = sultenggaEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5
            //gambar6

        }else if(session == 28){
            quiz.Play();
            KumpulanSoal = sulteng;
            Level.text = "Provinsi Sulawesi Tengah";
            gambar1 = GameObject.Find("sulteng1").GetComponent<Image>();
            gambar2= GameObject.Find("sulteng2").GetComponent<Image>();
            gambar3 = GameObject.Find("sulteng3").GetComponent<Image>();
            gambar4 = GameObject.Find("sulteng4").GetComponent<Image>();
            if(ego == 28){
                KumpulanSoal = sultengEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5
            //gambar6

        }else if(session == 29){
            quiz.Play();
            KumpulanSoal = gorontalo;
            Level.text = "Provinsi Gorontalo";
            gambar1 = GameObject.Find("gorontalo1").GetComponent<Image>();
            gambar2= GameObject.Find("gorontalo2").GetComponent<Image>();
            gambar3 = GameObject.Find("gorontalo3").GetComponent<Image>();
            gambar4 = GameObject.Find("gorontalo4").GetComponent<Image>();
            if(ego == 29){
                KumpulanSoal = gorontaloEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5
            //gambar6

        }else if(session == 30){
            quiz.Play();
            KumpulanSoal = sulut;
            Level.text = "Provinsi Sulawesi Utara";
            gambar1 = GameObject.Find("sulut1").GetComponent<Image>();
            gambar2= GameObject.Find("sulut2").GetComponent<Image>();
            gambar3 = GameObject.Find("sulut3").GetComponent<Image>();
            gambar4 = GameObject.Find("sulut4").GetComponent<Image>();
            if(ego == 30){
                KumpulanSoal = sulutEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5
            //ga,bar6

        }else if(session == 31){
            quiz.Play();
            KumpulanSoal = malut;
            Level.text = "Provinsi Maluku Utara";
            gambar1 = GameObject.Find("malut1").GetComponent<Image>();
            gambar2= GameObject.Find("malut2").GetComponent<Image>();
            gambar3 = GameObject.Find("malut3").GetComponent<Image>();
            gambar4 = GameObject.Find("malut4").GetComponent<Image>();
            if(ego == 31){
                KumpulanSoal = malutEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5
            //gambar6
            //gambar7

        }else if(session == 32){
            quiz.Play();
            KumpulanSoal = maluku;
            Level.text = "Provinsi Maluku";
            gambar1 = GameObject.Find("maluku1").GetComponent<Image>();
            gambar2= GameObject.Find("maluku2").GetComponent<Image>();
            gambar3 = GameObject.Find("maluku3").GetComponent<Image>();
            gambar4 = GameObject.Find("maluku4").GetComponent<Image>();
            if(ego == 32){
                KumpulanSoal = malukuEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5
            //gambar6
            //gambar7

        }else if(session == 33){
            quiz.Play();
            KumpulanSoal = papbar;
            Level.text = "Provinsi Papua Barat";
            gambar1 = GameObject.Find("papbar1").GetComponent<Image>();
            gambar2= GameObject.Find("papbar2").GetComponent<Image>();
            gambar3 = GameObject.Find("papbar3").GetComponent<Image>();
            gambar4 = GameObject.Find("papbar4").GetComponent<Image>();
            if(ego == 33){
                KumpulanSoal = papbarEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar6
            //gambar5
            //gambar7

        }else if(session == 34){
            quiz.Play();
            KumpulanSoal = papua;
            Level.text = "Provinsi Papua";
            gambar1 = GameObject.Find("papua1").GetComponent<Image>();
            gambar2= GameObject.Find("papua2").GetComponent<Image>();
            gambar3 = GameObject.Find("papua3").GetComponent<Image>();
            gambar4 = GameObject.Find("papua4").GetComponent<Image>();
            if(ego == 34){
                KumpulanSoal = papuaEgo;
                quiz.Stop();
                boss.Play();
                gambarEgo.enabled = true;
            
            }
            //gambar5
            //gambar6
            //gambar7

        }
        
        
       // jumlahsoal = KumpulanSoal.Count;
        
        hati1 = GameObject.Find("hati1").GetComponent<Image>();
        hati2 = GameObject.Find("hati2").GetComponent<Image>();
        hati3 = GameObject.Find("hati3").GetComponent<Image>();

        // gambar1.enabled = true;
        // gambar2.enabled = true;
        // gambar3.enabled = true;
        // gambar4.enabled = true;
        if (waktu == 1 || waktu == 4 || waktu == 7 || waktu == 10 || waktu == 13 || waktu == 16 || waktu == 19 || waktu == 22 || waktu == 25)
        {
            hati1.enabled = true;
            hati2.enabled = false;
            hati3.enabled = false;
            PlayerPrefs.SetInt("life", waktu);
            //waktu = PlayerPrefs.GetInt("life");

        }
        else if (waktu == 2 || waktu == 5 || waktu == 8 || waktu == 11 || waktu == 14 || waktu == 17 || waktu == 20 || waktu == 23 || waktu == 26)
        {
            hati1.enabled = true;
            hati2.enabled = true;
            hati3.enabled = false;
            PlayerPrefs.SetInt("life", waktu);
        }
        else if (waktu == 3 || waktu == 6 || waktu == 9 || waktu == 12 || waktu == 15 || waktu == 18 || waktu == 21 || waktu == 24 || waktu == 27)
        {
            if (waktu == 27)
            {
                garuda = 9;
                PlayerPrefs.SetInt("garuda", garuda);
                selesai.SetActive(true);
            }
            else if (waktu == 24)
            {
                garuda = 8;
                PlayerPrefs.SetInt("garuda", garuda);
                sisa = PlayerPrefs.GetInt("garuda");
                // textsisa.text = sisa + " x ";
                selesai.SetActive(true);
            }
            else if (waktu == 21)
            {
                garuda = 7;
                PlayerPrefs.SetInt("garuda", garuda);
                sisa = PlayerPrefs.GetInt("garuda");

                selesai.SetActive(true);
            }
            else if (waktu == 18)
            {
                garuda = 6;
                PlayerPrefs.SetInt("garuda", garuda);
                sisa = PlayerPrefs.GetInt("garuda");

                selesai.SetActive(true);
            }
            else if (waktu == 15)
            {
                garuda = 5;
                PlayerPrefs.SetInt("garuda", garuda);
                sisa = PlayerPrefs.GetInt("garuda");

                selesai.SetActive(true);
            }
            else if (waktu == 12)
            {
                garuda = 4;
                PlayerPrefs.SetInt("garuda", garuda);
                sisa = PlayerPrefs.GetInt("garuda");

                selesai.SetActive(true);
            }
            else if (waktu == 9)
            {
                garuda = 3;
                PlayerPrefs.SetInt("garuda", garuda);
                sisa = PlayerPrefs.GetInt("garuda");

                selesai.SetActive(true);
            }
            else if (waktu == 6)
            {
                garuda = 2;
                PlayerPrefs.SetInt("garuda", garuda);
                sisa = PlayerPrefs.GetInt("garuda");

                selesai.SetActive(true);
            }
            else if (waktu == 3)
            {
                garuda = 1;
                PlayerPrefs.SetInt("garuda", garuda);
                sisa = PlayerPrefs.GetInt("garuda");

                selesai.SetActive(true);
            }
            else { }
            hati1.enabled = true;
            hati2.enabled = true;
            hati3.enabled = true;
            PlayerPrefs.SetInt("life", waktu);
        }

        textSoal = GameObject.Find("TextSoal").GetComponent<Text>();
        textA = GameObject.Find("A").GetComponent<Text>();
        textB = GameObject.Find("B").GetComponent<Text>();
        textC = GameObject.Find("C").GetComponent<Text>();
        textD = GameObject.Find("D").GetComponent<Text>();
        textsisa = GameObject.Find("sisa").GetComponent<Text>();
        //GameObject.Find("UlangBtn").SetActive(false);

        //    textWaktu = GameObject.Find("TextWaktu").GetComponent<Text>();
        selesai.SetActive(false);
        GameObject.Find("Garuda").SetActive(false);
        pause.SetActive(false);

        nilaiAcak = Random.Range(0,KumpulanSoal.Count);

    }
    
    // Update is called once per frame
    void Update () {

        if(Input.GetKey(KeyCode.Escape)){
            pause.SetActive(true);
        }

        if (KumpulanSoal.Count > 0)
        {
            textSoal.text = KumpulanSoal[nilaiAcak].soal;
            textA.text = KumpulanSoal[nilaiAcak].pilA;
            textB.text = KumpulanSoal[nilaiAcak].pilB;
            textC.text = KumpulanSoal[nilaiAcak].pilC;
            textD.text = KumpulanSoal[nilaiAcak].pilD;

            if (sesssion > ego)
            {


                if (skor == 1)
                {
                    gambar1.enabled = true;
                }
                else if (skor == 2)
                {
                    gambar2.enabled = true;
                }
                else if (skor == 3)
                {
                    gambar3.enabled = true;
                }
                else if (skor == 4)
                {
                    gambar4.enabled = true;


                    if (session == 1 || session == 0)
                    { //kasih & + else if buat nampilin info sesuai buton yg di pilih
                      // Dialog.SetActive(true);

                        Debug.Log("Skor " + skor);
                        textSoal.text = "Cut Nyak Dhien";
                        Dialog.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                        btngede.SetActive(true);

                        // GameObject.Find("Garuda").SetActive(true);

                    }
                    else if (session == 2)
                    {
                        Debug.Log("Skor " + skor);
                        textSoal.text = "Sisingamangaraja XII";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);

                    }
                    else if (session == 3)
                    {
                        textSoal.text = "Tuanku Imam Bonjol";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);

                    }
                    else if (session == 4)
                    {
                        textSoal.text = "Sultan Syarif Kasim II ";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);

                    }
                    else if (session == 5)
                    {
                        textSoal.text = "Raja Ali Haji (RAH)";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);

                    }
                    else if (session == 6)
                    {
                        textSoal.text = "Sultan Thaha Syaifuddin";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);

                    }
                    else if (session == 7)
                    {
                        textSoal.text = "Fatmawati";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);

                    }
                    else if (session == 8)
                    {
                        textSoal.text = "A.K. Gani";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);

                    }
                    else if (session == 9)
                    {
                        textSoal.text = "Depati Amir";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);

                    }
                    else if (session == 10)
                    {
                        textSoal.text = "Radin Inten II";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 11)
                    {

                        Dialog.SetActive(true);
                        textSoal.text = "Syekh Arsyad Thawil";
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 12)
                    {
                        textSoal.text = "Ismail Marzuki";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 13)
                    {
                        textSoal.text = "Raden Dewi Sartika";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 14)
                    {
                        textSoal.text = "Jenderal Besar Raden Soedirman";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 15)
                    {
                        textSoal.text = "Raden Mas Soewardi Soerjaningrat";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 16)
                    {
                        textSoal.text = "Raden Hadji Oemar Said Tjokroaminoto";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 17)
                    {
                        textSoal.text = "I Gusti Ngurah Rai";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 18)
                    {
                        textSoal.text = "Tuan Guru Kyai Hajjī Muhammād Zainuddīn Abdul Madjīd";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 19)
                    {
                        textSoal.text = "Izaac Huru Doko";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 20)
                    {
                        textSoal.text = "Brigjen Hasan Basry";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 21)
                    {
                        textSoal.text = "Tjilik Riwut";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 22)
                    {
                        textSoal.text = "Ir. H. Pangeran Muhammad Noor";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 23)
                    {
                        textSoal.text = "Haji Abdoel Moeis Hassan";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 24)
                    {
                        textSoal.text = "dr. H. Jusuf Serang Kasim";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 25)
                    {
                        textSoal.text = "Andi Depu Maraddia Balanipa";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 26)
                    {
                        textSoal.text = "Syekh Yusuf Abul Mahasin Tajul Khalwati Al-Makasari Al-Bantani";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 27)
                    {
                        textSoal.text = "Komisaris Jenderal Polisi (Purn.) Dr. H. Muhammad Jasin";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 28)
                    {
                        textSoal.text = "Pue Lasadindi";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 29)
                    {
                        textSoal.text = "Nani Wartabone";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 30)
                    {
                        textSoal.text = "Dr. Gerungan Saul Samuel Jacob Ratulangi";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }

                    else if (session == 31)
                    {
                        textSoal.text = "Sultan Nuku";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 32)
                    {
                        textSoal.text = "Dr. Johannes Leimena ";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 33)
                    {
                        textSoal.text = "Silas Papare";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 34)
                    {
                        textSoal.text = "Frans Kaisiepo";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                    else if (session == 35)
                    {
                       // textSoal.text = "Frans Kaisiepo";
                        Dialog.SetActive(true);
                        btngede.SetActive(true);
                        GameObject.Find("Panel").SetActive(false);
                    }
                }

            }
            else if (sesssion == ego)
            {
                Debug.Log("Sesssion = " + sesssion);
                Debug.Log("Ego = " + ego);
                Debug.Log("Skor =" + skor);
                if (skor == 1)
                {
                    anim.SetBool("ego",true);

                }else if( skor == 2){
                	anim.SetBool("hilang",true);
                	textSoal.text = "Selamat Anda Berhasil ";
                    Dialog.SetActive(true);
                    btngede.SetActive(true);
                    GameObject.Find("Panel").SetActive(false);
                    Debug.Log("Sesssion = " + sesssion);
                    Debug.Log("Ego = " + ego);
                    Debug.Log("Skor =" + skor);
                }
            }

   
        }           
}

        
    


    public void CekJawaban(string jawaban) {
        if (KumpulanSoal[nilaiAcak].A == true && jawaban=="a") {
            //gambar1.enabled = true;

            skor++;
            benar.Play();
           // nilaiAcak -= 1;
            KumpulanSoal.RemoveAt(nilaiAcak);
        nilaiAcak = Random.Range(0, KumpulanSoal.Count);
            Debug.Log(nilaiAcak);
            Debug.Log("garuda sisa ");
            Debug.Log(garuda);
            Debug.Log("life sisa ");
            Debug.Log(waktu);

        }
        else if (KumpulanSoal[nilaiAcak].B == true && jawaban == "b")
        {
            //gambar2.enabled = true;
            benar.Play();
            skor++;
           // nilaiAcak -= 1;
            KumpulanSoal.RemoveAt(nilaiAcak);
        nilaiAcak = Random.Range(0, KumpulanSoal.Count);
            Debug.Log(nilaiAcak);
            Debug.Log("garuda sisa ");
            Debug.Log(garuda);
            Debug.Log("life sisa ");
            Debug.Log(waktu);
        }
        else if (KumpulanSoal[nilaiAcak].C == true && jawaban == "c")
        {
            //gambar3.enabled = true;
            benar.Play();
            skor++;
            //nilaiAcak -= 1;
            KumpulanSoal.RemoveAt(nilaiAcak);
        nilaiAcak = Random.Range(0, KumpulanSoal.Count);
            Debug.Log(nilaiAcak);
            Debug.Log("garuda sisa ");
            Debug.Log(garuda);
            Debug.Log("life sisa ");
            Debug.Log(waktu);
        }
        else if (KumpulanSoal[nilaiAcak].D == true && jawaban == "d")
        {
            //  gambar4.enabled = true;
            benar.Play();
            skor++;
           // nilaiAcak -= 1;
            KumpulanSoal.RemoveAt(nilaiAcak);
        nilaiAcak = Random.Range(0, KumpulanSoal.Count);
            Debug.Log(nilaiAcak);
            Debug.Log("garuda sisa ");
            Debug.Log(garuda);
            Debug.Log("life sisa ");
            Debug.Log(waktu);
        }
        else
        {
            salah.Play();
            waktu -= 1;


                   if (waktu == 0) {
            GameObject.Find("Panel").SetActive(false);
            garuda = PlayerPrefs.GetInt("garuda");
                sisa = PlayerPrefs.GetInt("garuda");
                //selesai.SetActive(true);
                textsisa.text = sisa + " x ";
                textSoal.text = "Nyawa anda telah habis";
            hati1.enabled = false;
            hati2.enabled = false;
            hati3.enabled = false;
           // PlayerPrefs.SetInt("garuda", 0);    
            //GameObject.Find("Panel").SetActive(false);
            if(garuda == 1){
                    PlayerPrefs.SetInt("garuda", 0);
                    SceneManager.LoadScene("SampleScene");
            }

        }
            else if (waktu == 1 || waktu == 4 || waktu == 7 || waktu == 10 || waktu == 13 || waktu == 16 || waktu == 19 || waktu == 22 || waktu == 25)
            {
                hati1.enabled = true;
                hati2.enabled = false;
                hati3.enabled = false;
                PlayerPrefs.SetInt("life", waktu);
                //waktu = PlayerPrefs.GetInt("life");

            }
            else if (waktu == 2 || waktu == 5 || waktu == 8 || waktu == 11 || waktu == 14 || waktu == 17 || waktu == 20 || waktu == 23 || waktu == 26)
            {
                hati1.enabled = true;
                hati2.enabled = true;
                hati3.enabled = false;
                PlayerPrefs.SetInt("life", waktu);
            }
            else if (waktu == 3 || waktu == 6 || waktu == 9 || waktu == 12 || waktu == 15 || waktu == 18 || waktu == 21 || waktu == 24 || waktu == 27)
            {
                if (waktu == 27)
                {
                    garuda = 9;
                    PlayerPrefs.SetInt("garuda", garuda);
                    selesai.SetActive(true);
                }
                else if (waktu == 24)
                {
                    garuda = 8;
                    PlayerPrefs.SetInt("garuda", garuda);
                    sisa = PlayerPrefs.GetInt("garuda");
                    textsisa.text = sisa + " x ";
                    selesai.SetActive(true);
                }
                else if (waktu == 21)
                {
                    garuda = 7;
                    PlayerPrefs.SetInt("garuda", garuda);
                    sisa = PlayerPrefs.GetInt("garuda");
                    textsisa.text = sisa + " x ";
                    selesai.SetActive(true);
                }
                else if (waktu == 18)
                {
                    garuda = 6;
                    PlayerPrefs.SetInt("garuda", garuda);
                    sisa = PlayerPrefs.GetInt("garuda");
                    textsisa.text = sisa + " x ";
                    selesai.SetActive(true);
                }
                else if (waktu == 15)
                {
                    garuda = 5;
                    PlayerPrefs.SetInt("garuda", garuda);
                    sisa = PlayerPrefs.GetInt("garuda");
                    textsisa.text = sisa + " x ";
                    selesai.SetActive(true);
                }
                else if (waktu == 12)
                {
                    garuda = 4;
                    PlayerPrefs.SetInt("garuda", garuda);
                    sisa = PlayerPrefs.GetInt("garuda");
                    textsisa.text = sisa + " x ";
                    selesai.SetActive(true);
                }
                else if (waktu == 9)
                {
                    garuda = 3;
                    PlayerPrefs.SetInt("garuda", garuda);
                    sisa = PlayerPrefs.GetInt("garuda");
                    textsisa.text = sisa + " x ";
                    selesai.SetActive(true);
                }
                else if (waktu == 6)
                {
                    garuda = 2;
                    PlayerPrefs.SetInt("garuda", garuda);
                    sisa = PlayerPrefs.GetInt("garuda");
                    textsisa.text = sisa + " x ";
                    selesai.SetActive(true);
                }
                else if (waktu == 3)
                {
                    garuda = 1;
                    PlayerPrefs.SetInt("garuda", garuda);
                    sisa = PlayerPrefs.GetInt("garuda");
                    textsisa.text = sisa + " x ";
                    selesai.SetActive(true);
                }
                else { }
            hati1.enabled = true;
            hati2.enabled = true;
            hati3.enabled = true;
            PlayerPrefs.SetInt("life", waktu);
        }
           // nilaiAcak += 1;
            // Debug.Log(nilaiAcak);
            // Debug.Log("garuda sisa ");
            // Debug.Log(garuda);
            // Debug.Log("life sisa ");
            // Debug.Log(waktu);

            
            
        }
       // KumpulanSoal.RemoveAt(nilaiAcak);
       //  nilaiAcak = Random.Range(0, KumpulanSoal.Count);
    }

    public void buttonlanjut()
    {
        Debug.Log("jacnuk");

        session = PlayerPrefs.GetInt("btnpilih");
        sesssion = PlayerPrefs.GetInt("sesi");
        ego = PlayerPrefs.GetInt("ego");
        acehMap = PlayerPrefs.GetInt("aceh");

        // int sumselMap = PlayerPrefs.GetInt("sumsel");
        // int acehMap = PlayerPrefs.GetInt("aceh");
        // int gorontaloMap = PlayerPrefs.GetInt("gorontalo");
        // int sumbarMap = PlayerPrefs.GetInt("sumbar");
        // int sumutMap = PlayerPrefs.GetInt("sumut");
        // int bangkaMap = PlayerPrefs.GetInt("bangka");
        // int jambiMap = PlayerPrefs.GetInt("jambi");
        // int riauMap = PlayerPrefs.GetInt("riau");
        // int kRiauMap = PlayerPrefs.GetInt("Kriau");
        // int lampungMap = PlayerPrefs.GetInt("lampung");
        // int bantenMap = PlayerPrefs.GetInt("banten");
        // int dkiMap = PlayerPrefs.GetInt("dki");
        // int jabarMap = PlayerPrefs.GetInt("jabar");
        // int jatengMap = PlayerPrefs.GetInt("jateng");
        // int yogyaMap = PlayerPrefs.GetInt("yogya");
        // int jatimMap = PlayerPrefs.GetInt("jatim");
        // int baliMap = PlayerPrefs.GetInt("bali");
        // int ntbMap = PlayerPrefs.GetInt("ntb");
        // int nttMap = PlayerPrefs.GetInt("ntt");
        

        // Debug.Log("aceh = +"+ acehMap);
        
        // Debug.Log("pop = " +pop);
        // Debug.Log("sumut = +"+ sumutMap);
        // Debug.Log("sumbar = +"+ sumbarMap);
        // Debug.Log("riau = +"+ riauMap);
        // Debug.Log("Kriau = +"+ kRiauMap);
        // Debug.Log("jambi = +"+ jambiMap);
        // Debug.Log("gorontalo = +"+ gorontaloMap);
        // Debug.Log("bangka = +"+ bangkaMap);
        // Debug.Log("sumsel = +"+ sumselMap);
        // Debug.Log("lampung = +"+ lampungMap);
Debug.Log("ego = "+ ego);
Debug.Log("pop = "+ pop);
        SceneManager.LoadScene("pilihlevel");

        if(session == 1 ){
            if(ego == 0){
            // ego += 1;
            //   PlayerPrefs.SetInt("pop", 1);
            //   PlayerPrefs.SetInt("ego",ego);
            ego+=1;
                Debug.Log("ini ego nya 0");
                PlayerPrefs.SetInt("ego",ego);
                Debug.Log("ini ego nya "+ego);
            //  PlayerPrefs.SetInt("aceh",2);

               
            }else if(ego == 1){
             PlayerPrefs.SetInt("aceh",2);
             PlayerPrefs.SetInt("ego",0);
             Debug.Log("ego = "+ego);
        }
            
        }else if(session == 2){
            PlayerPrefs.SetInt("sumut",1);
        }else if(session == 3){
            PlayerPrefs.SetInt("sumbar",1);
        }else if(session == 4){
            PlayerPrefs.SetInt("riau",1);
        }else if(session == 5){
            PlayerPrefs.SetInt("Kriau",1);
        }else if(session == 6){
            PlayerPrefs.SetInt("jambi",1);
        }else if(session == 7){
            PlayerPrefs.SetInt("gorontalo",1);
        }else if(session == 8){
            PlayerPrefs.SetInt("sumsel",1);
        }else if(session == 9){
            SceneManager.LoadScene("pilihlevel");
            PlayerPrefs.SetInt("bangka",1);
        }else if(session == 10){
            SceneManager.LoadScene("pilihlevel");
            PlayerPrefs.SetInt("lampung",1);
        }else if(session == 11){
            SceneManager.LoadScene("pilihlevel");
            PlayerPrefs.SetInt("banten",1);
        }else if(session == 12){
            SceneManager.LoadScene("pilihlevel");
            PlayerPrefs.SetInt("dki",1);
        }else if(session == 13){
            SceneManager.LoadScene("pilihlevel");
            PlayerPrefs.SetInt("jabar",1);
        }else if(session == 14){
            SceneManager.LoadScene("pilihlevel");
            PlayerPrefs.SetInt("jateng",1);
        }else if(session == 15){
            SceneManager.LoadScene("pilihlevel");
            PlayerPrefs.SetInt("yogya",1);
        }else if(session == 16){
            SceneManager.LoadScene("pilihlevel");
            PlayerPrefs.SetInt("jatim",1);
        }else if(session == 17){
            SceneManager.LoadScene("pilihlevel");
            PlayerPrefs.SetInt("bali",1);
        }else if(session == 18){
            SceneManager.LoadScene("pilihlevel");
            PlayerPrefs.SetInt("ntb",1);
        }else if(session == 19){
            
            PlayerPrefs.SetInt("ntt",1);
        }
       //  if (sesssion == 35 && ego == 34)
       //  {
       //      SceneManager.LoadScene("contoh");
       //  }
       // else if(sesssion > ego){
       //  ego += 1;
       //  PlayerPrefs.SetInt("ego", ego);
       //      PlayerPrefs.SetInt("pop", 1);
       //  }else if (sesssion == ego){
       //      sesssion += 1;
       //      PlayerPrefs.SetInt("sesi", sesssion);
       //      PlayerPrefs.SetInt("pop", 0);
       //  }

       //  else {
       //      Debug.Log("SALAH OY");
       //  }
       //  // Debug.Log("sesi setelah nambah 1");
       //  // Debug.Log(sesssion);
        
       //  Debug.Log("sesi nambah 1");
       //  Debug.Log(session);
       //  Debug.Log(ego);
       //  if (sesssion == 35 && ego == 34)
       //  {
       //      SceneManager.LoadScene("contoh");
       //  }
        else
        {


            SceneManager.LoadScene("pilihlevel");
        }
    }

    public void ulang() {
        SceneManager.LoadScene("Game");
    }

    public void lanjut()
    {
        selesai.SetActive(false);
        //pause.SetActive(false);
    }
    public void pauseLanjut()
    {
        pause.SetActive(false);
    }
    public void keluarPause()
    {
        SceneManager.LoadScene("pilihlevel");
    }
}

/**
-respawn = 9 (nyawa besar)
- while respawn < 0 
        hati = 3
        while hati < 0
            lanjut game
            if(salah == true)
                hati -= 1
        respawn -=1 

    }
*/









