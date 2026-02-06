//using Ad;
using UnityEngine;
using UnityEngine.UI;
using YG;

public class LanguageChanger : MonoBehaviour
{
	[SerializeField] private GameObject Pn_Exit;
	[SerializeField] private Text _textDino;
    private int _advertisementCount=0;
	private void Start()
	{
		_advertisementCount = PlayerPrefs.GetInt("RekCount", 1);

		if (_advertisementCount > 1)
		{
			//AdHandler.instance.ShowInterstitialAd();
			//AdHandler.instance.ShowBanner(true);
			//GameAnalytics.gameAnalytics.InterstitialAd();
			//print("показываем рекламу reklamacount"+reklamacount);

		}
		_advertisementCount++;
		PlayerPrefs.SetInt("RekCount", _advertisementCount);
	}
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (Pn_Exit.activeSelf == true)
			{
				Pn_Exit.SetActive(false);
			}
			else { Pn_Exit.SetActive(true); }
		}

	}
	
    private void OnGUI()
    {
       	if  (YG2.lang == "en")  {GetComponent<Text>().text = "EN";}
		else  {GetComponent<Text>().text = "RU";}
    }


    public void ChangeLanguage()
    {
        bool isEnglish = YG2.lang == "en";

        YG2.SwitchLanguage(isEnglish ? "ru" : "en");

        _textDino.text = isEnglish ? "Пазлы динозавры" : "Dinosaur puzzles";
    }

    public void Rate()
	{
		//PlayerPrefs.SetInt ("reklama", 1);
		//if (NewBanner!=null) NewBanner.Hide();
		Application.OpenURL("https://play.google.com/store/apps/details?id=com.Mamapapa.Dino");

		//	AppQuit();
	}
	public void onOpenWeb(string site)
	{
		Application.OpenURL(site);
	}
	
		public void Exit()
	{
		Application.Quit();
		//BigBanner.OnAdLoaded += OnBigBannerLoaded;
		//while (!BigBanner.IsLoaded()) {
			//yield return null;
		//}

	}
	
}

