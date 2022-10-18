using System;
class Program {
  static void Main() {
    char[] frstArr = {'A','a','N','n','K','k'};
    char[] secArr = {'l','B','o','p','P','Q'};
    Console.Write("Enter your text: ");
    string str = Console.ReadLine();
    char[] strChar = str.ToCharArray();
    for(int i=0;i<frstArr.Length;i++){
        for(int j=0;j<strChar.Length;j++){
            if(strChar[j] == frstArr[i]){
                strChar[j] = secArr[i];
            }
        }
    }
    Console.WriteLine("Answer text: ");
    for(int i=0;i<strChar.Length;i++){
        Console.Write(strChar[i]);   
    }
    
  }
}
