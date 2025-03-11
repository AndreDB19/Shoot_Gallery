using UnityEngine;
using UnityEngine.UI;
public class VidaUI : MonoBehaviour
{
    public Text lifeText;
    // Update is called once per frame
    void Update()
    {
        lifeText.text = "Vida: " + GameController.life;
    }
}
