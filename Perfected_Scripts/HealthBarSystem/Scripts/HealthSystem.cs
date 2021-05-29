using System;
using UnityEngine;
public class HealthSystem : MonoBehaviour
{
    public event EventHandler OnDamaged;
    public event EventHandler OnHealed;
    [SerializeField] FloatVariable health;
    [SerializeField] FloatReference maxHealth;
    [SerializeField] bool resetHealthAtStart;
    private int healthAmount;
    private void Awake() {
        if(resetHealthAtStart)
            health.value = maxHealth.ConstantValue;
    }
        
    public void Damage(float amount)
    {
        health.value -= amount;
        if(health.value < 0)
            health.value = 0;
        if(OnDamaged != null) OnDamaged (this, EventArgs.Empty);
    }
    public void Heal(float amount)
    {
        health.value += amount;
        if(health.value > maxHealth.Value)
            health.value = maxHealth.Value;
        if(OnHealed != null) OnHealed(this,EventArgs.Empty);
    }
    public float GetHealth()
    {
        return this.health.value;
    }
}
