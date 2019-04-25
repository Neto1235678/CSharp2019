using System;
using System.Collections;
using System.Collections.Generic;

class TreeNode
{
  public TreeNode parent;
  public List<TreeNode> children; // 가변가능한 List 
  public string Name{get; set;}
  public TreeNode(string name)
  {
    Name = name;
    children = new List<TreeNode>();
    parent = null;
  }

  public void AddChild(TreeNode c)
  {
    children.Add(c);  // List의 Add함수
    c.parent = this;
  }
  public int Degree {
    get {
      return children.Count;
    }
  }

  // public bool isLeaf {
  //   get {
    
  //   }
  // }
}

class Tree
{
  public TreeNode Root { get; set; }
  
  public string IterativeDFS(TreeNode node, Action<TreeNode> callback)  
  // 자주쓰는 패턴 스택을이용한 DFS
  {
    string s = "";
    Stack<TreeNode> stack = new Stack<TreeNode>();
    stack.Push(node);

    while(stack.Count > 0)
    {
      TreeNode n = stack.Pop();
      s += n.Name + " ";
      callback(n);

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

  public string IterativeBFS(TreeNode node, Action<TreeNode> callback) // 큐를 이용한 BFS (재귀호출은 불가능) 작성해오기
  {
    
    string s = "";
    var q = new Queue<TreeNode>();
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

  // public int Height(TreeNode node, Action<string> callback) {
  //   int hcount = 0;
  //   int s = 0;

  //   Stack<TreeNode> stack = new Stack<TreeNode>();
  //   stack.Push(node);

  //   while(stack.Count > 0)
  //   {
  //     TreeNode n = stack.Pop();
  //     for(int i =; i < n.children.Count; i++)
  //       stack.Push(n.children[i]);

  //       if(n.children.Count > 0)
  //       {
  //         hcount++;
  //         for(int j = 0; j < hcount; j++)
  //         if(n.children.Count < j)
  //         {
  //            s = n.children.Count -1;
  //         }
  //       }
  //   }
  //   return s;

  // }

  public int Depth(TreeNode node) {
    int dcount = 0;
    TreeNode current = node;
    while(current.parent != null) {
      dcount++;
      current = current.parent;
    }
    return dcount;
  }

  // public int Degree(TreeNode node, Action<string> callback)  
  // {
  //   int chcount = 0;
  //   int s = 0;
  //   Stack<TreeNode> stack = new Stack<TreeNode>();
  //   stack.Push(node);

  //   while(stack.Count > 0)
  //   {
  //     TreeNode n = stack.Pop();
  //     if(n.children.Count > 0)
  //     {
  //       chcount++;     
  //       // Console.WriteLine(chcount);   
  //       if(n.children.Count > chcount)
  //       {
  //           s = n.children.Count;  
  //       }  
  //     }
  //     for(int i = 0; i < n.children.Count; i++)
  //       stack.Push(n.children[i]);

  //   }
  //   return s;
  // }

  public int Degree {
    get {
      int maxDegree = 0;
      IterativeBFS(Root, node => {
        if(node.Degree > maxDegree)
        maxDegree = node.Degree;
      });
      return maxDegree;
    }
  }

  // public int Height {
  //   get {
  //     int maxDepth = 0;
  //     IterativeBFS(Root, node => {
  //       if(node.isLeaf) {
  //       int d = Depth(node);
  //       if(d > maxDepth)
  //         maxDepth = d;
  //       }
  //     });
  //     return maxDepth;
  //   }
  // }

  public int HeightFast {
    get {
      int maxDepth = 0;
      Stack<TreeNode> stack = new Stack<TreeNode>();
      stack.Push(Root);
      while(stack.Count > 0) {
        if(stack.Count > maxDepth) {
          maxDepth = stack.Count-1;
          TreeNode n = stack.Pop();

        for (int i = n.children.Count-1; i >=0; i--)
        stack.Push(n.children[i]);
        }
      return maxDepth;
      }
    }
  }

  public IEnumerator GetEnumerator() {
    //using List<> Enumerator
    var list = new List<TreeNode>();
    IterativeDFS( Root, node=>list.Add(node));
    return list.GetEnumerator();
    // return new TreeNodeEnumerator(this);
  }

  // 3: using yield return
  public IEnumerable<TreeNode> EnumDFS(TreeNode node) {
    var stack = new Stack<TreeNode>();
    stack.Push(node);
    while(stack.Count > 0) {
      TreeNode n = stack.Pop();
      yield return n;
      for(int i = n.children.Count-1; i >= 0; i--)
      stack.Push(n.children[i]);
    }
  }

  class TreeNodeEnumerator : IEnumerator {
    Tree tree;
    List<TreeNode> list;
    int position = -1;
    public TreeNodeEnumerator(Tree _tree) {
      tree = _tree;
      list = new List<TreeNode>();
      tree.IterativeDFS(tree.Root, node => list.Add(node));
      // or tree.IterativeBFS(tree.Root, node => list.Add(node));
    }

    public bool MoveNext() {
      if (position < list.Count-1) {
        position++;
        return true;
      } else {
        return false;
      }
    }

    public object Current {
      get {
        return list[position];
      }

    }

    public void Reset() {
      position = -1;
    }
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

    print(tree.IterativeDFS(root, node=>{}) == "root a d e b f g h i c ");
    print(tree.RecursiveDFS(root) == "root a d e b f g h i c ");
    print(tree.IterativeBFS(root, node=>{}) == "root a b c d e f g h i ");
    
    
   // print(tree.Degree(root, print) == 3);
    print(tree.Depth(root) == 0);
    print(tree.Height(root));

    string str = "";
    foreach(var n in tree) 
      str += n + " ";
    print( str == "root a d e b f g h i c ");

    str = "";
    foreach(var n in tree.EnumDFS(tree.Root))
    str += n + " ";
    print( str == "root a d e b f g h i c ");

  }
}


// Node depth, Tree degree, Tree height 만들어오기
// doubly linked list, foreachable 가능하게 만들어오기
// Tree, foreachable (DFS방식 이용)
// 비선형 자료는 선형화 시켜서 돌려야된다.