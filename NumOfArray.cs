using System;
class Program {
  static void Main() {
    Console.Write("Enter the length of array: ");
    int length = Int32.Parse(Console.ReadLine());
    int[] arr = new int[length];
    Random rnd = new Random();
    for(int i=0;i<length;i++){
        arr[i] = rnd.Next(0,length-1);
    }
    for(int i=0;i<length;i++){
        Console.Write("number = ");
        int num=Int32.Parse(Console.ReadLine());
        bool t = false;
        for(int j=0;j<length;j++){
            if(num == arr[j]){
                Console.WriteLine("Your input number is in array...");
                t=true;
                break;
            }
        }
        if(t){
           break; 
        }else{
            Console.WriteLine("Try again...");
        }
    }
    Console.Write("Array ` ");
    for(int i=0;i<length;i++){
        Console.Write(arr[i]+" ");
    }
  }
}
