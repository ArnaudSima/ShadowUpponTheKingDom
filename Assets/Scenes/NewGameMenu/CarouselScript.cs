using Heroes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarouselScript : MonoBehaviour
{
    
    private int _currentHeroeIndex;
    List<Hero> HeroDisplayList = new List<Hero> { new Ogre(Resources.Load("HeroesAssets/HeroesIcons/OgreMouth"))};

    public void IncrementIndex()
    {
        if (_currentHeroeIndex == HeroDisplayList.Count - 1)
        {
            _currentHeroeIndex = 0;
            return;
        }
        _currentHeroeIndex++;
    }
    public void DecrementIndex() 
    {
        if (_currentHeroeIndex == 0)
        {
            _currentHeroeIndex = HeroDisplayList.Count - 1;
            return;
        }
        _currentHeroeIndex--;
    }
}
