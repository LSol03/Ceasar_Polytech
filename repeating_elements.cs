using System;
class Program {
  static void Main() {
    Console.Write("Enter your text: ");
    string str=Console.ReadLine();
    str+=" ";
    char[] chArray = str.ToCharArray();
    int sum = 0;
    for(int i=0;i<chArray.Length;i++){
        for(int j=i;j<chArray.Length;j++){
            if((char)chArray[i] == (char)chArray[j]){
                sum++;
            }else{
                Console.WriteLine($"{chArray[i]}->{sum} ");
                break;
            }
        }
        i= i+sum-1;
        sum=0;
    }
  }
}

