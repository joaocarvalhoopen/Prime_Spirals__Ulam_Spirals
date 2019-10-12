/******************************************************************************
 *                                                                            *
 *  Prime Spirals - Ulam Spirals                                              *
 *                                                                            *
 ******************************************************************************
 * Author: Joao Nuno Carvalho                                                 *
 * Date: 2019.10.11                                                           *
 * License: MIT Open Source License                                           *
 * Description: This is a simple implementation of a Prime Spirals or Ulam    *
 *              Spirals after the great Polish Physicist Stanislaw Ulam, that *
 * participated in Manhatten project. It is said that he discovered this      *
 * spiral patterns in 1963 while he was in academia attending a lecture that  *
 * was boring, and he started to draw a spiral of integer numbers and circle  *
 * the prime numbers.                                                         *
 * He then saw a emerging pattern of lines of primes spiral out of the page   *
 * in lines.                                                                  *
 *                                                                            *
 * Ulam Spirals:                                                               *
 *   17 16  15 14 13                                                          *
 *   18  5   4  3 12                                                          *
 *   19  6   1  2 11                                                          *
 *   20  7   8  9 10                                                          *
 *   21 22  23                                                                *
 *                                                                            *
 * Now if we only map the prime numbers:                                      *
 *   17           13                                                          *
 *       5      3                                                             *
 *   19      1  2 11                                                          *
 *       7                                                                    *
 *          23                                                                *
 *                                                                            *
 * Ulam is also known for is work on MonteCarlo Methods applied to physics.   *
 * This program is an attempt to draw this in an image in a bigger scale so   *
 * that the line patterns emerge.                                             *
 * Each pixel is one point starting from the center of the image number 1.    *
 *                                                                            *
 * See references on the project page.                                        *
 ******************************************************************************
 * Note: This classes are part my implementation of The Ray Tracer Challenger *
 *       of the book with the same name and I added the Chaos class for this  *
 *       small project.                                                       *
 ******************************************************************************
*/  

using System;

public static class Constants
{
    public const double Epsilon = 0.00001; 
}

class Program
{
    static void Main(string[] args)
    {
        PrimeSpiral.draw();
    }
}
