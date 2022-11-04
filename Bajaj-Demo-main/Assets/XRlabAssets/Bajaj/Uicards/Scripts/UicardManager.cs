using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UicardManager : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Topic Text")]
    public string[] Englishtopictext;
    public string[] Hinditopictext;
    public string[] Maratitopictext;

    [Header("ContentText")]

    public string[] Englishcontenttext;
    public string[] Hindicontenttext;
    public string[] Maraticontenttext;

    [Header("Text Field")]
    public TextMeshProUGUI topictext;
    public TextMeshProUGUI contenttext;
    public int count=0;

    [Header("Audio Files")]
    public AudioSource uicardaudiosource;
    public AudioClip[] Englishaudioclip;
    public AudioClip[] Hindiaudioclip;
    public AudioClip[] Maratiaudioclip;

    [Header("StepText")]

    public string[] Englishsteptext;
    public string[] Hindisteptext;
    public string[] Maratisteptext;

    [Header("Step Text Field")]
    public TextMeshProUGUI[] steptext;
    public GameObject stepdown;
    public TextMeshProUGUI stepnumber;

   

    [Header("Progress")]
    public Slider progress;

    [Header("Buttons")]
    public GameObject[] NormalButtons;
    public GameObject[] ClickButtons;

    [Header("Language")]
    public string Lang;
    public float overallstepcount;
    public int stepcount;

    
    
    float percentValue;
   

    public void Start()
    {
        Lang = PlayerPrefs.GetString("SelectedLanguage");
     
    }

    public void Awake()
    {
        steptexts();
       
    }


    public void Enableuicards()
    {
        if(Lang=="English")
        {
            topictext.text = Englishtopictext[count];
            contenttext.text = Englishcontenttext[count];
            uicardaudiosource.clip = Englishaudioclip[count];
            count++;
            stepcount++;
            stepnumber.text = count.ToString()+"/"+Englishcontenttext.Length;
            if (stepcount >= 1)
            {
                steptext[stepcount - 1].transform.GetChild(0).gameObject.SetActive(true);
                steptext[stepcount - 1].transform.GetChild(1).gameObject.SetActive(false);
                progressbar();
                stepupdown();
            }
          
        }
        if (Lang == "Hindi")
        {
            topictext.text = Hinditopictext[count];
            contenttext.text = Hindicontenttext[count];
            uicardaudiosource.clip = Hindiaudioclip[count];
            count++;
            stepcount++;
            stepnumber.text = count.ToString() + "/" + Hindicontenttext.Length;
            if (stepcount >= 1)
            {
                steptext[stepcount - 1].transform.GetChild(0).gameObject.SetActive(true);
                steptext[stepcount - 1].transform.GetChild(1).gameObject.SetActive(false);
                progressbar();
                stepupdown();
            }
        }
        if (Lang == "Marati")
        {
            topictext.text = Maratitopictext[count];
            contenttext.text = Maraticontenttext[count];
            uicardaudiosource.clip = Maratiaudioclip[count];
            count++;
            stepcount++;
            stepnumber.text = count.ToString() + "/" + Hindicontenttext.Length;
            if (stepcount >= 1)
            {
                steptext[stepcount - 1].transform.GetChild(0).gameObject.SetActive(true);
                steptext[stepcount - 1].transform.GetChild(1).gameObject.SetActive(false);
                progressbar();
                stepupdown();
            }
        }

    }


    public void steptexts()
    {
       
        for(int i=0;i<steptext.Length;i++)
        {
            if (Lang == "English")
            {
                steptext[i].text = Englishsteptext[i];
            }
            if(Lang == "Hindi")
            {
                steptext[i].text = Hindisteptext[i];
            }
            if (Lang == "Marati")
            {
                steptext[i].text = Maratisteptext[i];
            }
        }
    }

    public void progressbar()
    {
        progress.value += 1f/overallstepcount;
    }

    public void stepupdown()
    {
       
       RectTransform rt= stepdown.GetComponent<RectTransform>();
       rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical,rt.rect.height-42);
    }


    public void Buttonstatechange(int change,bool stat)
    {
        for(int i=0;i<NormalButtons.Length;i++)
        {
           if(i==change && stat==true)
            {
                NormalButtons[i].SetActive(false);
                ClickButtons[i].SetActive(true);
            }
            if (i == change && stat ==false)
            {
                NormalButtons[i].SetActive(true);
                ClickButtons[i].SetActive(false);
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "RightHand" || gameObject.name == "LeftHand")
        {
            if (other.gameObject.name=="HomeButton")
            {
                Buttonstatechange(0,true);
            }
            if (other.gameObject.name == "MuteButton")
            {
                Buttonstatechange(1,true);
            }
            if (other.gameObject.name == "AudioButton")
            {
                Buttonstatechange(2,true);
            }
            if (other.gameObject.name == "NextButton")
            {
                Buttonstatechange(3,true);
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "RightHand" || gameObject.name == "LeftHand")
        {
            if (other.gameObject.name == "HomeButton")
            {
                Buttonstatechange(0, false);
            }
            if (other.gameObject.name == "MuteButton")
            {
                Buttonstatechange(1, false);
            }
            if (other.gameObject.name == "Icon button_default (2)")
            {
                Buttonstatechange(2, false);
            }
            if (other.gameObject.name == "NextButton")
            {
                Buttonstatechange(3, false);
            }
        }
    }



}
