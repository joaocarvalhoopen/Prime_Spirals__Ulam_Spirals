using System;
using System.Collections.Generic;

public class PrimeSpiral
{
    enum Direction
    {
        Right,
        Up,
        Left,
        Down
    }

    private static bool isPrime(int num){
        if (num == 2 || num == 3 || num == 5 )
            return true;
        else if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0 || num < 2)
            return false;
        for(int i = (int) (num/5); i > 2; --i){
            if (num % i == 0)
                return false;
        }
        return true;
    }

    private static List<int> calcPrimeNumbers(int maxNumber){
        List<int> primesList = new List<int>(maxNumber);    
        for (int i = 0; i <= maxNumber; i++){
            if (isPrime(i) == true){
                primesList.Add(i);
            }
        }
        return primesList;
    }

    private static IEnumerable<Direction> nextDirection(){
        int index = 0;
        while(true){
            index++;
            for(int i = 0; i < index; i++)
                yield return Direction.Right;
            for(int i = 0; i < index; i++)
                yield return Direction.Up;
            index++;
            for(int i = 0; i < index; i++)
                yield return Direction.Left;
            for(int i = 0; i < index; i++)
                yield return Direction.Down;
        }
    }

    public static void draw(){
        Console.WriteLine("Drawing Primes Spiral - Ulam Spiral...");

        const int width  = 500;
        const int height = 500; 
        int maxNumber = (width-10) * (height-10); 
        // const int margin = 5;
        Canvas canv = new Canvas(width, height);

        Color white = new Color(1, 1, 1);

        int xCenterPt = (int) (width / 2);
        int yCenterPt = (int) (height / 2);

        int x = xCenterPt;
        int y = yCenterPt;
        int i = 0;
        foreach(Direction dir in nextDirection()){
            if (i >= maxNumber)
                break;
            
            switch (dir){
                case Direction.Right:
                    x = x + 1;
                    // y = y;
                    break;
                case Direction.Up:
                    // x = x;
                    y = y + 1;
                    break;
                case Direction.Left:
                    x = x - 1;
                    // y = y;
                    break;
                case Direction.Down:
                    // x = x;
                    y = y-1;
                    break;
            }
            if (isPrime(i) == true){
                int xCanvas =          x ;
                int yCanvas = height - y;
                canv.writePixel(xCanvas, yCanvas, white);
            }
            i++;
        }

        string filename = @".\primes_spiral_ulam_spiral.ppm";
        canv.canvasToPpmFile(filename);
    }

  
}