using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScrollingStory : MonoBehaviour {
    int i = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public void NextParagraph()
    {
        Text story = GetComponent<Text>();
        switch(i++)
        {
            case 0:
                story.text = "The camera glides into the cockpit coming to rest behind the character. He turns on a view screen and reads his briefing";
                FadeIn.SetFadeIn(true);
                break;
            case 1:
                story.text = "Briefing: Tenalp IV went silent 12 days ago. There has been no communication a no transports have been detected leaving. The alpha team arrived in orbit 3 days ago. They left orbit and went planetside once obital recon' produced nothing abnoral. We lost contact with the team when they entered the ionosphere and never reestablished communication.";
                break;
            case 2:
                story.text = "Briefing cont': The planet has a population of over 600,000. We need to know what has become of those people. Dr. Pepper believes there are two likely scanarios. A terraforming incident may have release hazardous chemicals in to the atmo' or an enemy factions has release a chemical or biological attack. Regardless, use your environment suit until you establish otherwise.";
                break;
            case 3:
                Application.LoadLevel("Descent");
                break;
        }
    }
    public void LoadTheNextLevel()
    {
        Application.LoadLevel("1");
    }
   
}
