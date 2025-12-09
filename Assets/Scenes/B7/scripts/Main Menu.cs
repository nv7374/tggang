using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace B7
{
    public class MainMenu : MonoBehaviour
    {
        public GameObject MenuBack;
        public GameObject Manual;
        public GameObject Story;
        
        public void BtnManual()
        {
            MenuBack.GetComponent<Animator>().SetTrigger("Close");
            Invoke("OpenMenual", 1.5f);
        }
        public void BtnStory()
        {
            MenuBack.GetComponent<Animator>().SetTrigger("Close");
            Invoke("OpneStory", 1.5f);
        }
        void OpenMunual()
        {
            Manual.SetActive(true);
            Manual.GetComponent<Animator>().SetTrigger("Open");
        }
        void OpenMenuBack()
        {
            MenuBack.GetComponent<Animator>().SetTrigger("Open");
        }
        void OpenStory()
        {
            Story.SetActive(true);
            Story.GetComponent<Animator>().SetTrigger("Open");
        }
    }
}
