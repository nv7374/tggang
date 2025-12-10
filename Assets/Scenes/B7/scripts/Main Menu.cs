using Codice.Client.Commands;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            Invoke("OpenStory", 1.5f);
        }
        void OpenMenual()
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
        public void BtnBack(int num)
        {
            switch (num)
            {
                case 0: //menual
                    Manual.GetComponent<Animator>().SetTrigger("Close");
                    Invoke("OpenMenuBack", 1.5f);
                    break;
                case 1: //story
                    Story.GetComponent<Animator>().SetTrigger("Close");
                    Invoke("OpenMenuBack", 1.5f);
                    break;
            }
        }
        public void BtnStart()
        {
            SceneManager.LoadScene("stage01");
        }
        public void BtnExit()
        {
            Application.Quit();
        }
    }
}
