using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   [SerializeField] private int _health = 100;
   [SerializeField] private Bar _healthBar;
   [SerializeField] private int _maxhealth = 100;
   
   public void Heal()
   {
	   int heal = Random.Range(20,30);
	   
	   _health = Mathf.Min(_health + heal, _maxhealth);
	   
	   UpdateHealthBar();
   }
   
   public int CurrentHleath()
   {
	   return _health;
   }
   
   public void UpdateHealthBar()
   {
	   _healthBar.SetBar((float)_health, (float) _maxhealth);
   }
}
