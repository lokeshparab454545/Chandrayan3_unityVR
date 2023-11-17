using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private void Start()
    {
        videoPlayer.loopPointReached += OnVideoFinished;
        videoPlayer.Play();
    }

    private void OnVideoFinished(VideoPlayer vp)
    {
        // Video has finished playing, change the scene here
        SceneManager.LoadScene("LunarLandscape3D");
    }
}
