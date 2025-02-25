using UnityEngine;
using UnityEngine.UI;

public class BulletText : MonoBehaviour
{
    public Text bulletText;
    public Slingshot Slingshot;
    public int bullet;
    void Start()
    {
        bullet = Slingshot.bullets;
    }

    void Update()
    {
        if(Slingshot.bullets != bullet)
        {
            SubBullet();
        }
    }

    public void SubBullet()
    {
        bullet = Slingshot.bullets;
        UpdateBulletUI();
    }

    private void UpdateBulletUI()
    {
        if (bulletText != null)
        {
            bulletText.text = "Bullet: " + bullet;
        }
    }
}
