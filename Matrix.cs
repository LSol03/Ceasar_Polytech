using System;
class Program{
    static void Main(){
        string str = "123456789abcdef45555";
        bool[] stug= new bool[str.Length];
        double sqrt = Math.Sqrt(str.Length);
        object[,] mat = new object[(int)sqrt,(int)sqrt];
        int k=0;
        for(int i=0;i<(int)sqrt;i++){
            for(int j=0;j<(int)sqrt;j++){
                mat[i,j]=str[i+j+k]; 
                stug[i+j+k]=true;
                Console.Write(mat[i,j]+" ");
            }
            k=k+(int)sqrt-1;
            Console.WriteLine();
        }
        Console.WriteLine("The outside of chars...");
        for(int i=0;i<str.Length;i++){
            if(stug[i] != true){
                Console.Write(str[i] + " ");
            }
        }
        Console.WriteLine("\nNew Matrix...");
        for(int i=0;i<(int)sqrt;i++){
            for(int j=0;j<(int)sqrt;j++){
                if(i==j){
                    Console.Write(mat[i,j]+" ");
                }else{
                    Console.Write(mat[j,i]+" ");
                }
            }
            Console.WriteLine();
        }
    }
}