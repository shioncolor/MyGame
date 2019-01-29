using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class Ads : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //あぷりＩＤ
        string appId = "ca-app-pub-7436871571325810~8814802988";

        MobileAds.Initialize(appId);
        Banner();
    }

    private void Banner()
    {

        // 広告ID 
        string adUnitId = "ca-app-pub-7436871571325810/6265619121";

       
        BannerView bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        
        AdRequest adRequest = new AdRequest.Builder().Build();

       
        bannerView.LoadAd(adRequest);

    }
}