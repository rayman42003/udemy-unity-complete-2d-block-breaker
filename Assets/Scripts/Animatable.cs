using UnityEngine;

public class Animatable : MonoBehaviour
{
    [SerializeField]
    private Sprite[] damageLevels = new Sprite[0];

    private SpriteRenderer spriteRenderer;

    public void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void changeSprite(int healthRemaining) {
        int spriteIndex = healthRemaining - 1;
        if (spriteIndex < damageLevels.Length) {
            spriteRenderer.sprite = damageLevels[spriteIndex];
        }
    }
}
