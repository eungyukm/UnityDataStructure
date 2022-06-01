using UnityEngine;

public class LinkedList : MonoBehaviour
{
    private LinkedListClass _linkedListClass = new LinkedListClass();
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            int randNumber = Random.Range(0, 100);
            Debug.Log(randNumber);
            _linkedListClass.InsertFront(randNumber);   
        }
        
        _linkedListClass.Print();
    }
}

public class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

public class LinkedListClass
{
    public Node head;

    public void InsertFront(int data)
    {
        Node node = new Node(data);
        node.next = head;
        head = node;
    }
    
    // 전체 노드를 순회하면서, 출력
    public void Print()
    {
        Node node = head;
        while (node != null)
        {
            Debug.Log(node.data);
            node = node.next;
        }
    }
}
