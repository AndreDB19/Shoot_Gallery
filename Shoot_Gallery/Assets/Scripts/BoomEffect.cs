using UnityEngine;

public class BoomEffect : MonoBehaviour
{
    // Tempo de vida do efeito (em segundos)
    public float lifetime = 2f;

    // Velocidade de rotação (graus por segundo)
    public float rotationSpeed = 360f;

    // Escala máxima que o objeto atingirá
    public float maxScale = 1.5f;

    // Tempo para atingir a escala máxima (em segundos)
    public float scaleUpTime = 0.5f;

    // Tempo para diminuir a escala até desaparecer (em segundos)
    public float scaleDownTime = 1f;

    private Vector3 initialScale;
    private float timer = 0f;

    private void Start()
    {
        // Guarda a escala inicial do objeto
        initialScale = transform.localScale;
    }

    private void Update()
    {
        // Rotaciona o objeto no eixo Z
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);

        // Atualiza o timer
        timer += Time.deltaTime;

        // Controla o aumento e diminuição da escala
        if (timer <= scaleUpTime)
        {
            // Aumenta a escala até o máximo
            float scaleProgress = timer / scaleUpTime;
            transform.localScale = Vector3.Lerp(initialScale, initialScale * maxScale, scaleProgress);
        }
        else if (timer <= scaleUpTime + scaleDownTime)
        {
            // Diminui a escala até zero
            float scaleProgress = (timer - scaleUpTime) / scaleDownTime;
            transform.localScale = Vector3.Lerp(initialScale * maxScale, Vector3.zero, scaleProgress);
        }

        // Reduz o tempo de vida
        lifetime -= Time.deltaTime;

        // Destrói o objeto quando o tempo de vida acabar
        if (lifetime <= 0f)
        {
            Destroy(gameObject);
            Debug.Log("Sprite destruído: " + gameObject.name);
        }
    }
}