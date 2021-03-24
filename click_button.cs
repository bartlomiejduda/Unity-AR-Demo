using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class click_button : MonoBehaviour
{
    public int Current_health = 100;


    public void end_battle()
    {
        GameObject audio_battle_theme = GameObject.Find("Battle_theme_audiosource");
        audio_battle_theme.GetComponent<AudioSource>().Stop();
        

        GameObject audio_victory_theme = GameObject.Find("Victory_theme_audiosource (1)");
        audio_victory_theme.GetComponent<AudioSource>().Play();
    }


    public void attack_with_fists()
    {

        GameObject inputFieldGo = GameObject.Find("Health_Text");
        Text text_obj = inputFieldGo.GetComponent<Text>();

        Current_health -= 5;

        if (Current_health < 0)
            Current_health = 0;

        text_obj.text = "Health: " + Current_health.ToString() + "/100";
        inputFieldGo.GetComponent<Text>().text = text_obj.text;

        GameObject corona_obj = GameObject.Find("Corona_Text");
        corona_obj.GetComponent<Text>().text = "";

        int res = check_if_virus_dead();
    }



    public void attack_with_fireball()
    {

        GameObject inputFieldGo = GameObject.Find("Health_Text");
        Text text_obj = inputFieldGo.GetComponent<Text>();

        Current_health -= 10;

        if (Current_health < 0)
            Current_health = 0;

        text_obj.text = "Health: " + Current_health.ToString() + "/100";
        inputFieldGo.GetComponent<Text>().text = text_obj.text;

        GameObject corona_obj = GameObject.Find("Corona_Text");
        corona_obj.GetComponent<Text>().text = "";

        int res = check_if_virus_dead();
    }


    public int check_if_virus_dead()
    {
        if (Current_health <= 0)
        {
            GameObject inputFieldGo = GameObject.Find("You_Won_Text");
            Text text_obj = inputFieldGo.GetComponent<Text>();
            text_obj.text = "YOU WON!!!";
            inputFieldGo.GetComponent<Text>().text = text_obj.text;

            GameObject health_obj = GameObject.Find("Health_Text");
            health_obj.GetComponent<Text>().text = "";

            GameObject corona_obj1 = GameObject.Find("CoronaVir1");
            corona_obj1.GetComponent<VideoPlayer>().Stop();
            corona_obj1.GetComponent<VideoPlayer>().url = "Assets//coronavirus_dead2.mp4";
            corona_obj1.GetComponent<VideoPlayer>().Play();

            GameObject corona_obj2 = GameObject.Find("CoronaVir2");
            corona_obj2.GetComponent<VideoPlayer>().Stop();
            corona_obj2.GetComponent<VideoPlayer>().url = "Assets//coronavirus_dead2.mp4";
            corona_obj2.GetComponent<VideoPlayer>().Play();

            GameObject corona_obj3 = GameObject.Find("CoronaVir3");
            corona_obj3.GetComponent<VideoPlayer>().Stop();
            corona_obj3.GetComponent<VideoPlayer>().url = "Assets//coronavirus_dead2.mp4";
            corona_obj3.GetComponent<VideoPlayer>().Play();

            GameObject corona_obj4 = GameObject.Find("CoronaVir4");
            corona_obj4.GetComponent<VideoPlayer>().Stop();
            corona_obj4.GetComponent<VideoPlayer>().url = "Assets//coronavirus_dead2.mp4";
            corona_obj4.GetComponent<VideoPlayer>().Play();

            end_battle();

            return 1;
        }

        return 0;
    }


}
