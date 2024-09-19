using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITest<T>
{
    public string NameTest { get; set;}
    public void Log(T score);
}
