using System;
using System.Collections.Generic;

class TreeNode
{
  public List<TreeNode> children; // 가변가능한 List 
  public string Name{get; set;}
  public TreeNode(string name)
  {
    Name = name;
    children = new List<TreeNode>();
  }

  public void AddChild(TreeNode c)
  {
    children.Add(c);  // List의 Add함수
  }
}

class Tree
{
  public TreeNode Root { get; set; }
  
  public string IterativeDFS(TreeNode node, Action<string> callback)  
  // 자주쓰는 패턴 스택을이용한 DFS
  {
    string s = "";
    Stack<TreeNode> stack = new Stack<TreeNode>();
    stack.Push(node);

    while(stack.Count > 0)
    {
      TreeNode n = stack.Pop();
      s += n.Name + " ";
     // callback(n.Name);

      for(int i = n.children.Count-1; i >= 0; i--)
        stack.Push(n.children[i]);
    }
    return s;
  }

  public string RecursiveDFS(TreeNode node) // 재귀호출을 이용한 DFS방식출력
  {
    string s = node.Name + " ";
    foreach(var n in node.children)
      s += RecursiveDFS(n);
    return s;
  }

  public string IterativeBFS(TreeNode node, Action<string> callback) // 큐를 이용한 BFS (재귀호출은 불가능) 작성해오기
  {
    
    string s = "";
    Queue<TreeNode> q = new Queue<TreeNode>();
    q.Enqueue(node);

    while(q.Count > 0)
    {
      TreeNode n = q.Dequeue();
      s += n.Name + " ";
      //callback(n.Name);

      for(int i = 0; i < n.children.Count; i++)
      q.Enqueue(n.children[i]);

    }
    return s;

  }

  public string Depth(TreeNode node, Action<string> callback)
  {
    return "";
  }

  public string Degree(TreeNode node, Action<string> callback)  
  {
    int chcount = 0;
    //int temp = 0;
    string s = "";
    Stack<TreeNode> stack = new Stack<TreeNode>();
    stack.Push(node);

    TreeNode n = stack.Pop();
    if(n.children.Count > 0)
    {
      chcount++;
      //temp = chcount;
      if( n.children.Count > chcount )
      {
        s += n.Name + " ";
        //Console.WriteLine(chcount);
      }        
    }  
    return s;
  }

}

class MainClass 
{
  public static void Main (string[] args) 
  {
    Action<object> print = Console.WriteLine;

    Tree tree = new Tree();
    TreeNode root = new TreeNode("root");
    TreeNode a = new TreeNode("a");
    TreeNode b = new TreeNode("b");
    TreeNode c = new TreeNode("c");
    TreeNode d = new TreeNode("d");
    TreeNode e = new TreeNode("e");
    TreeNode f = new TreeNode("f");
    TreeNode g = new TreeNode("g");
    TreeNode h = new TreeNode("h");
    TreeNode i = new TreeNode("i");
    tree.Root = root;
    
    root.AddChild(a); root.AddChild(b); root.AddChild(c);
    a.AddChild(d); a.AddChild(e);
    b.AddChild(f); b.AddChild(g);
    g.AddChild(h); g.AddChild(i); 

    //DFS == Stack방식
    //BFS == Queue방식

    print(tree.IterativeDFS(root, print) == "root a d e b f g h i c ");
    print(tree.RecursiveDFS(root) == "root a d e b f g h i c ");
    print(tree.IterativeBFS(root, print) == "root a b c d e f g h i ");
    print(tree.Degree(root, print) == "root ");
    print(tree.Depth(root, print));
  }
}


// Node depth, Tree degree, Tree height 만들어오기
// doubly linked list, foreachable 가능하게 만들어오기
// Tree, foreachable (DFS방식 이용)