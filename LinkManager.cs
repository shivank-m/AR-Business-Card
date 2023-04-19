using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkManager : MonoBehaviour
{
   public void openTwitter()
   {
    Application.OpenURL("https://twitter.com/shivank__mittal?t=DmGQPj94VHuC7HvmZME83A&s=08");
   }
   public void openInstagram()
   {
    Application.OpenURL("https://instagram.com/shivankx11?igshid=ZDdkNTZiNTM=");
   }
   public void openLinkedin()
   {
    Application.OpenURL("https://www.linkedin.com/in/shivank-mittal-aba0b81a1");
   }
   public void openDiscord()
   {
    Application.OpenURL("https://discord.com/");
   }
   public void openGithub()
   {
    Application.OpenURL("https://github.com/shivank-m/");
   }
}
