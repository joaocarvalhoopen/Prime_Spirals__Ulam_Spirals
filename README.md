# Prime Spirals - Ulam Spirals

## Description
This is a simple implementation of a Prime Spirals or Ulam Spirals after the great Polish Physicist Stanislaw Ulam, that participated in Manhattan project. <br>
It is said that he discovered this spiral patterns in 1963 after he returned to academia, while attending a lecture that was boring. He started to draw a spiral of integer numbers and circle the prime numbers.<br>
He then saw a emerging pattern of lines of primes spiral out of the page in lines. <br>                                                         
<br>

## Ulam Spirals process
```
    17 16  15 14 13
    18  5   4  3 12
    19  6   1  2 11
    20  7   8  9 10
    21 22  23
```
Now if we only map the prime numbers:<br>
```
    17           13
        5      3
    19      1  2 11
        7
           23
```

Ulam is also known for is work on Monte Carlo Methods applied to physics. <br>
This program is an attempt to draw this in an image in a bigger scale so that the line patterns emerge. <br> 
Each pixel is one point starting from the center of the image number 1. <br>
See file [PrimeSpiral.cs](./PrimeSpiral.cs) <br>
   
## The first 250.000 natural numbers, white pixel if it is a prime, black if not. See the line pattens?
![Prime Spiral for the first 250.000 numbers](./primes_spiral_ulam_spiral.png?raw=true "Prime Spiral for the first 250.000 numbers") <br>

## Reference links to see
* [Prime Spirals - Numberphile](https://www.youtube.com/watch?v=iFuR97YcSLM)
* [41 and more Ulam's Spiral - Numberphile](https://www.youtube.com/watch?v=3K-12i0jclM)
* [Stanislaw Ulam - Wikipedia](https://en.wikipedia.org/wiki/Stanislaw_Ulam)

## Note
This classes are part my implementation of The Ray Tracer Challenger of the book with the same name and I added the PrimeSpiral class for this small project.   

## License
MIT Open Source License

## Have fun!
Best regards, <br>
Joao Nuno Carvalho