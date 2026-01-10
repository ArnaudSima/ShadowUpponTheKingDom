using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentClassDisplayer 
{
    private int _currentHeroeIndex;
    private List<Heroes> _heroList;
    public void IncrementIndex()
    {
        _currentHeroeIndex++;
    }
    public void DecrementIndex() 
    {
        if (_currentHeroeIndex == 0)
        {
            _currentHeroeIndex = _heroList.Count - 1;
        }
        _currentHeroeIndex--;
    }
}
