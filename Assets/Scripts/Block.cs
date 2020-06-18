using UnityEngine;

public class Block : MonoBehaviour
{
    private void Start() {
        Damagable damagable = GetComponent<Damagable>();
        BlockLevel level = FindObjectOfType<BlockLevel>();

        Spawnable spawnable = GetComponent<Spawnable>();
        spawnable.RegisterOnSpawn(() => level.addBlock());

        Audible audible = GetComponent<Audible>();
        damagable.RegisterOnKilled((score) => audible.playSound());
        damagable.RegisterOnKilled((score) => level.removeBlock());

        Animatable animatable = GetComponent<Animatable>();
        damagable.RegisterOnDamaged((healthRemaining) => animatable.changeSprite(healthRemaining));
    }
}
