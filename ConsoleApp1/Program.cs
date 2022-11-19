// See https://aka.ms/new-console-template for more information
using System;

public class ElevatorTotalStop
{
    //A is the weight of person
    //B is the floor person need to go
    //X is the capacity of no of person elevator can carry
    //Y is the capacity of weight elevator can carry 
    //M is the building Height
    public int solution(int[]A, int[]B,int X,int Y,  int M)
    {
        int temp = 0;
        int tempcapacity = 0;
        int tempweight = 0;
        List<int> list = new List<int>();
        int Result = 0;
        Boolean Restart= true;

        while(temp<A.Length)
        { 
            if(tempcapacity<X && tempweight<Y)
            {
                tempweight = A[temp] + tempweight;
                tempcapacity=tempcapacity+1;
                list.Add(B[temp]);
               
                if(temp==A.Length-1)
                Restart = false;
                temp++;
            }
            else
            {
                //Restart=true;
                if(tempweight>Y)
                list.Remove(temp - 1);

                Result = list.Distinct().Count()+1+Result;
                tempweight =0; tempcapacity=0;
                list.Clear();
            }
            if (!Restart)
            {
                Result = list.Distinct().Count() + Result;
            }
            
        }
        
        return Result;
    }
    
}
public class mainclass
{
    public static void Main(string[] args)
    {
        ElevatorTotalStop totalStop = new ElevatorTotalStop();
        int[] A = { 40,40,100,80,20};
        int[] B = { 3, 3, 2, 2, 3 };
        int Y = 200;
        int X = 3;
        int M = 10;

        Console.WriteLine(totalStop.solution(A, B, X, Y, M));
       
    }
}