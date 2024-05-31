using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private Kirby player;
    private GameObject alien;

    public GameObject reloadButton;
    public GameObject winButton;
    public bool alienDeath = false;
    public bool kirbyDeath = false;

    public Slider kirbySlider;
    public Slider kirbyEnergy;

    public GameObject alienSlider;

    public GameObject waterIcon;
    public GameObject splashIcon;
    public GameObject slimeIcon;

    public GameObject VTCam;
    public GameObject lookAt;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Kirby>();
        alien = GameObject.FindGameObjectWithTag("Alien");

        reloadButton.SetActive(false);
        winButton.SetActive(false);

        kirbySlider.value = 0;
        kirbyEnergy.value = 0;

        alienSlider.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (alienDeath)
        {    
            winButton.SetActive(true);
        }
        if (kirbyDeath)
        {
            reloadButton.SetActive(true);
            winButton.SetActive(true);
        }

        if (player.energy >= 100)
        {
            waterIcon.SetActive(true);
        }
        else
        {
            waterIcon.SetActive(false);
        }
        if (player.splash)
        {
            splashIcon.SetActive(true);
        }
        if (player.poisonResist)
        {
            slimeIcon.SetActive(true);
        }

        kirbySlider.value = kirbySlider.maxValue - player.HP;   
        kirbyEnergy.value = player.energy;

        if (alien.GetComponent<Alien>().action == true)
        {
            alienSlider.SetActive (true);
            alienSlider.GetComponent<Slider>().value = alienSlider.GetComponent<Slider>().maxValue - alien.GetComponent<Alien>().HP;
            VTCam.GetComponent<CinemachineVirtualCamera>().Follow = lookAt.transform;
            VTCam.GetComponent<CinemachineVirtualCamera>().m_Lens.OrthographicSize = 9;
        }
        
    }
    public void WinButtonClick()
    {
        Application.Quit();
    }
    public void ReloadButtonClick()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }
}
