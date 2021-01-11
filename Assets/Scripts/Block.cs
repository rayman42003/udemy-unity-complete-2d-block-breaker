using UnityEngine;

public class Block : MonoBehaviour
{
    private void Start() {
        Damagable damagable = GetComponent<Damagable>();
        BlockLevel level = FindObjectOfType<BlockLevel>();

        Audible audible = GetComponent<Audible>();
        damagable.RegisterOnKilled((d) => audible.playSound());
        damagable.RegisterOnKilled((d) => level.removeBlock(d));

        Animatable animatable = GetComponent<Animatable>();
        damagable.RegisterOnDamaged((healthRemaining) => animatable.changeSprite(healthRemaining));
    }
}
