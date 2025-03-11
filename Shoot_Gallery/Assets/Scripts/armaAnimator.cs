using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public Animator armaAnimator; // Referência ao Animator da arma
    public Slingshot sl;
    public float cooldownTime = 1f; // Tempo de cooldown em segundos
    private float nextFireTime = 0f; // Tempo em que o próximo disparo será permitido

    void Update()
    {
        // Verifica se o botão esquerdo do mouse foi pressionado e se o cooldown acabou
        if (Input.GetButtonDown("Fire1") && Time.time >= nextFireTime && sl.bullets != 0)
        {
            // Ativa o parâmetro "Shoot" para iniciar a animação
            armaAnimator.SetBool("Shoot", true);

            // Define o tempo do próximo disparo
            nextFireTime = Time.time + cooldownTime;
        }
        else
        {
            // Desativa o parâmetro "Shoot" após o término da animação
            armaAnimator.SetBool("Shoot", false);
        }
    }
}