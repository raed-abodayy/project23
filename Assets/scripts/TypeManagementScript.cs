using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
namespace Assignmaent29
{
public class TypeManagementScript : MonoBehaviour
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Debug.Log("Animal moves");
        }
        public void move()
        {
            Debug.Log("Animal moves");
        }
    }
    public interface ICanFight
    {
        void Attack();
    }
    public class Cat : Animal, ICanFight
    {
        public override void MakeSound()
        {
            Debug.Log("MEOW!");
        }
        public new void move()
        {
            Debug.Log("Cat moves");
        }
        public void Attack()
        {
            Debug.Log("Cat attacks with claws!");
        }
    }
    public class Warrior : ICanFight
    {
        public void Attack()
        {
            Debug.Log("Warrior attacks with a sword!");
        }


    }
    void Start()
    {
        Animal animal = new Cat();
        animal.move();
        animal.MakeSound();
        Animal animal2 = new Animal();
        Cat car = (Cat)animal;
        car.move();
        car.MakeSound();
        List<ICanFight> canFights = new List<ICanFight> { new Cat(), new Warrior()};
        foreach (var canfight in canFights)
        {
            canfight.Attack();
            if(canfight is Cat)
            Debug.Log("The object is a Cat");
            else if(canfight is Warrior)
            Debug.Log("The object is a Warrior");
        }
    }
}
}