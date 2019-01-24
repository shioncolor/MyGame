using UnityEngine;
using System.IO;
using System.Collections;
using SocialConnector;
using UnityEngine.UI;

public class ShareButton : MonoBehaviour {

    public void ButtonPush()
    {
#if UNITY_STANDALONE_WIN
        PcShare();
#elif UNITY_IPHONE
        share();
#endif
    }

    public void HigeScore()
    {
#if UNITY_STANDALONE_WIN
        string TweetText = Manager.text + "のハイスコア正解率は" + Mathf.Round(Manager.ScoreArray[3]*100).ToString() + "%です！";
        Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(TweetText));
#elif UNITY_IPHONE
        share();
#endif
    }

    private IEnumerator share()
    {
        string ImagName = "ScreenshotImag.png";

        //スクリーンショットを撮影
        Application.CaptureScreenshot(ImagName);
        yield return new WaitForEndOfFrame();

        string TweetText = "正解率" + Score.GetAnswerRate().ToString() + "%でした！";
        string URL = "https://twitter.com/";

        yield return new WaitForSeconds(1);

        //Shareする
        SocialConnector.SocialConnector.Share(TweetText, URL, ImagName);
    }

    private void PcShare()
    {
        string TweetText = "正解率" + Score.GetAnswerRate().ToString() + "%でした！";
        Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(TweetText));
    }
}
