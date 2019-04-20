using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Monetization;
//using UnityEngine.Advertisements;
public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public static bool GameIsPaused = false;
    public static bool pausaGame = false;
    public Text record;

    private string store_id = "2983554";
    private string rewardedVideo = "rewardedVideo";

    void Start()
    {
        //Monetization.Initialize(store_id, true);
        //Advertisement.Initialize(store_id, true);
    }
    // Update is called once per frame
    void Update()
    {
        if (pausaGame)
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        pausaGame = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        record.text = PlayerPrefs.GetInt("recorde").ToString();
        Time.timeScale = 0f;
        GameIsPaused = true;
        pausaGame = false;

        //if (Monetization.IsReady(rewardedVideo))
        //{
        //    ShowAdPlacementContent ad = null;
        //    ad = Monetization.GetPlacementContent(rewardedVideo) as ShowAdPlacementContent;
        //    if (ad != null)
        //        ad.Show();
        //}
        //if (Advertisement.IsReady("teste"))
        //{
        //    Advertisement.Banner.Show("teste");
        //}
        
    }
}
