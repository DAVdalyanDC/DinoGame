using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkedListNode<T>
{
    public T Val { get; set;}

    public LinkedListNode<T> Next {get; set;}
    public LinkedListNode<T> Previous { get; set; }
}
