using System;
class Program {
    static void Main(string[] args) {
      Console.Write("Enter your text:");
      string str=Console.ReadLine();
      char[] ch=str.ToCharArray();
      Console.Write("Key:");
      int key=Int32.Parse(Console.ReadLine());
      for(int i =0;i<ch.Length;i++){
        ch[i] += (char)key;
        Console.Write(ch[i]);
      }
    }
}
