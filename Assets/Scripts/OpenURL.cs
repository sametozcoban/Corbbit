using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public string githubURL1 = "https://github.com/sametozcoban?tab=repositories";
    public string githubURL2 = "https://github.com/Bengilata";
    public string linkedinURL1 = "linkedin.com/in/sametozcoban";
    public string linkedinURL2 = "https://tr.linkedin.com/in/bengisu-karpuzoglu-3a827024a";

    public void OpenGitHub()
    {
        Application.OpenURL(githubURL1);
        Application.OpenURL(githubURL2);
    }

    public void OpenLinkedIn()
    {
        Application.OpenURL(linkedinURL1);
        Application.OpenURL(linkedinURL2);
    }
}
