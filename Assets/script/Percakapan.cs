using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Percakapan : MonoBehaviour
{
    public Cakap dialog , sumut , riau, sumbar , Priau , jambi, bengkulu , sumsel ,	bangka , lampung, banten , jakarta , jabar , jateng , yogya , jatim , bali , ntt , ntb , kalbar , kalteng , kalsel , kaltum , kaltim , sulbar , sulsel, sultenggah , sulteng , gorontalo , sulut , malut , maluku , papbar , papua;
    public Cakap acehEgo, sumutEgo , riauEgo, sumbarEgo , PriauEgo , jambiEgo, bengkuluEgo , sumselEgo , bangkaEgo , lampungEgo, bantenEgo , jakartaEgo , jabarEgo , jatengEgo , yogyaEgo , jatimEgo , baliEgo , nttEgo , ntbEgo , kalbarEgo , kaltengEgo , kalselEgo , kaltumEgo , kaltimEgo , sulbarEgo , sulselEgo, sultenggahEgo , sultengEgo , gorontaloEgo , sulutEgo , malutEgo , malukuEgo , papbarEgo , papuaEgo , egoHilang;
    

    public void TriggerDialog()
    {

    	int a = PlayerPrefs.GetInt("sesi");
    	int ego = PlayerPrefs.GetInt("ego");

    	        if (a == 1)
        {
            if (ego == 0)
            {
                FindObjectOfType<Penjelasan>().StartDialog(dialog);
            }
            else if (ego == 1)
            {
                FindObjectOfType<Penjelasan>().StartDialog(acehEgo);
            }
        }
        else if (a == 2)
        {
            if (ego == 1)
            {
                FindObjectOfType<Penjelasan>().StartDialog(sumut);
            }
            else if (ego == 2)
            {
                FindObjectOfType<Penjelasan>().StartDialog(sumutEgo);
            }

        }
        else if (a == 3)
        {
            if (ego == 2)
            {
                FindObjectOfType<Penjelasan>().StartDialog(sumbar);
            }
            else if (ego == 3)
            {
                FindObjectOfType<Penjelasan>().StartDialog(sumbarEgo);
            }
        }

        else if (a == 4)
        {
            if (ego == 3)
            {
                FindObjectOfType<Penjelasan>().StartDialog(riau);
            }
            else if (ego == 4)
            {
                FindObjectOfType<Penjelasan>().StartDialog(riauEgo);
            }
        }



        else if (a == 5)
        {
            if (ego == 4)
            {
                FindObjectOfType<Penjelasan>().StartDialog(Priau);
            }

            else if (ego == 5)
            {
                FindObjectOfType<Penjelasan>().StartDialog(PriauEgo);
            }
        }

        else if (a == 6)
        {
            if (ego == 5)
            {
                FindObjectOfType<Penjelasan>().StartDialog(jambi);
            }
            else if (ego == 6)
            {
                FindObjectOfType<Penjelasan>().StartDialog(jambiEgo);
            }
        }


        else if (a == 7)
        {
            if (ego == 6)
            {
                FindObjectOfType<Penjelasan>().StartDialog(bengkulu);
            }
            else if (ego == 7)
            {
                FindObjectOfType<Penjelasan>().StartDialog(bengkuluEgo);
            }
        }


        else if (a == 8)
        {
            if (ego == 7)
            {
                FindObjectOfType<Penjelasan>().StartDialog(sumsel);
            }
            else if (ego == 8)
            {
                FindObjectOfType<Penjelasan>().StartDialog(sumselEgo);
            }
        }
        else if (a == 9)
        {
            if (ego == 8)
            {
                FindObjectOfType<Penjelasan>().StartDialog(bangka);
            }
            else if (ego == 9)
            {
                FindObjectOfType<Penjelasan>().StartDialog(bangkaEgo);
            }
        }

        else if (a == 10)
        {
            if (ego == 9)
            {
                FindObjectOfType<Penjelasan>().StartDialog(lampung);
            }
            else if (ego == 10)
            {
                FindObjectOfType<Penjelasan>().StartDialog(lampungEgo);
            }
        }

        else if (a == 11)
        {
            if (ego == 10)
            {
                FindObjectOfType<Penjelasan>().StartDialog(banten);
            }
            else if (ego == 11)
            {
                FindObjectOfType<Penjelasan>().StartDialog(bantenEgo);
            }
        }
        else if (a == 12)
        {
            if (ego == 11)
            {
                FindObjectOfType<Penjelasan>().StartDialog(jakarta);
            }
            else if (ego == 12)
            {
                FindObjectOfType<Penjelasan>().StartDialog(jakartaEgo);
            }
        }
        else if (a == 13)
        {
            if (ego == 12)
            {
                FindObjectOfType<Penjelasan>().StartDialog(jabar);
            }
            else if (ego == 13)
            {
                FindObjectOfType<Penjelasan>().StartDialog(jabarEgo);
            }
        }
        else if (a == 14)
        {
            if (ego == 13)
            {
                FindObjectOfType<Penjelasan>().StartDialog(jateng);
            }
            else if (ego == 14)
            {
                FindObjectOfType<Penjelasan>().StartDialog(jatengEgo);
            }
        }
        else if (a == 15)
        {
            if (ego == 14)
            {
                FindObjectOfType<Penjelasan>().StartDialog(yogya);
            }
            else if (ego == 15)
            {
                FindObjectOfType<Penjelasan>().StartDialog(yogyaEgo);
            }
        }
        else if (a == 16)
        {
            if (ego == 15)
            {
                FindObjectOfType<Penjelasan>().StartDialog(jatim);
            }
            else if (ego == 16)
            {
                FindObjectOfType<Penjelasan>().StartDialog(jatimEgo);
            }
        }
        else if (a == 17)
        {
            if (ego == 16)
            {
                FindObjectOfType<Penjelasan>().StartDialog(bali);
            }
            else if (ego == 17)
            {
                FindObjectOfType<Penjelasan>().StartDialog(baliEgo);
            }
        }
        else if (a == 18)
        {
            if (ego == 17)
            {
                FindObjectOfType<Penjelasan>().StartDialog(ntb);
            }
            else if (ego == 18)
            {
                FindObjectOfType<Penjelasan>().StartDialog(ntbEgo);
            }
        }
        else if (a == 19)
        {
            if (ego == 18)
            {
                FindObjectOfType<Penjelasan>().StartDialog(ntt);
            }
            else if (ego == 19)
            {
                FindObjectOfType<Penjelasan>().StartDialog(nttEgo);
            }
        }
        else if (a == 20)
        {
            if (ego == 19)
            {
                FindObjectOfType<Penjelasan>().StartDialog(kalbar);
            }
            else if (ego == 20)
            {
                FindObjectOfType<Penjelasan>().StartDialog(kalbarEgo);
            }
        }
        else if (a == 21)
        {
            if (ego == 20)
            {
                FindObjectOfType<Penjelasan>().StartDialog(kalteng);
            }
            else if (ego == 21)
            {
                FindObjectOfType<Penjelasan>().StartDialog(kaltengEgo);
            }
        }
        else if (a == 22)
        {
            if (ego == 21)
            {
                FindObjectOfType<Penjelasan>().StartDialog(kalsel);
            }
            else if (ego == 22)
            {
                FindObjectOfType<Penjelasan>().StartDialog(kalselEgo);
            }
        }
        else if (a == 23)
        {
            if (ego == 22)
            {
                FindObjectOfType<Penjelasan>().StartDialog(kaltim);
            }
            else if (ego == 23)
            {
                FindObjectOfType<Penjelasan>().StartDialog(kaltimEgo);
            }
        }
        else if (a == 24)
        {
            if (ego == 23)
            {
                FindObjectOfType<Penjelasan>().StartDialog(kaltum);
            }
            else if (ego == 24)
            {
                FindObjectOfType<Penjelasan>().StartDialog(kaltumEgo);
            }
        }
        else if (a == 25)
 {
            if (ego == 24)
            {
                FindObjectOfType<Penjelasan>().StartDialog(sulbar);
            }
            else if (ego == 25)
            {
                FindObjectOfType<Penjelasan>().StartDialog(sulbarEgo);
            }
        }
        else if (a == 26)
        {
            if (ego == 25)
            {
                FindObjectOfType<Penjelasan>().StartDialog(sulsel);
            }
            else if (ego == 26)
            {
                FindObjectOfType<Penjelasan>().StartDialog(sulselEgo);
            }
        }
        else if (a == 27)
        {
            if (ego == 26)
            {
                FindObjectOfType<Penjelasan>().StartDialog(sultenggah);
            }
            else if (ego == 27)
            {
                FindObjectOfType<Penjelasan>().StartDialog(sultenggahEgo);
            }

        }
        else if (a == 28)
        {
            if (ego == 27)
            {
                FindObjectOfType<Penjelasan>().StartDialog(sulteng);
            }
            else if (ego == 28)
            {
                FindObjectOfType<Penjelasan>().StartDialog(sultengEgo);
            }

        }
        else if (a == 29)
        {
            if (ego == 28)
            {
                FindObjectOfType<Penjelasan>().StartDialog(gorontalo);
            }
            else if (ego == 29)
            {
                FindObjectOfType<Penjelasan>().StartDialog(gorontaloEgo);
            }

        }
        else if (a == 30)
        {
            if (ego == 29)
            {
                FindObjectOfType<Penjelasan>().StartDialog(sulut);
            }
            else if (ego == 30)
            {
                FindObjectOfType<Penjelasan>().StartDialog(sulutEgo);
            }

        }
        else if (a == 31)
        {
            if (ego == 30)
            {
                FindObjectOfType<Penjelasan>().StartDialog(malut);
            }
            else if (ego == 31)
            {
                FindObjectOfType<Penjelasan>().StartDialog(malutEgo);
            }

        }
        else if (a == 32)
        {
            if (ego == 31)
            {
                FindObjectOfType<Penjelasan>().StartDialog(maluku);
            }
            else if (ego == 32)
            {
                FindObjectOfType<Penjelasan>().StartDialog(malukuEgo);
            }
        }
        else if (a == 33)
        {
            if (ego == 32)
            {
                FindObjectOfType<Penjelasan>().StartDialog(papbar);
            }
            else if (ego == 33)
            {
                FindObjectOfType<Penjelasan>().StartDialog(papbarEgo);
            }

        }
        else if (a == 34)
        {
            if (ego == 33)
            {
                FindObjectOfType<Penjelasan>().StartDialog(papua);
            }
            else if (ego == 34)
            {
                FindObjectOfType<Penjelasan>().StartDialog(papuaEgo);
            }
        
    	}
    }
}
