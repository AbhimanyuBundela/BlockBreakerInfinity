using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdManager : MonoBehaviour
{
    public static AdManager instance;

    private string appID = "";

    private BannerView bannerAdView;
    private string bannerAdID = "";

    private InterstitialAd fullScreenAdView;
    private string interstitialAdID = "";

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void RequestBanner()
    {
        bannerAdView = new BannerView(bannerAdID, AdSize.Banner, AdPosition.Bottom);

        AdRequest request = new AdRequest.Builder().Build();

        bannerAdView.LoadAd(request);

        bannerAdView.Show();
    }

    public void HideBanner()
    {
        bannerAdView.Hide();
    }

    public void RequestFullScreenAd()
    {
        fullScreenAdView = new InterstitialAd(interstitialAdID);

        AdRequest request = new AdRequest.Builder().Build();

        fullScreenAdView.LoadAd(request);
    }

    public void ShowFullScreenAd()
    {
        if (fullScreenAdView.IsLoaded())
        {
            fullScreenAdView.Show();
        }
        else
        {
            Debug.Log("Full screen Ad not Loaded");
        }
    }
}
