# Prime Sifting

#### By Kirsten Opstad 

#### A Prime Sifting Console App

## Technologies Used

* C#
* .Net 6

## Description

### Objectives (MVP)

Given a number, return all of the prime numbers less than that number.

Use the Sieve of Eratosthenes to solve it. Here's how the Sieve of Eratosthenes works to find a number up to a given number:

* Create a list of numbers from 2 through n: 2, 3, 4, ..., number.
* Initially, let prime equal 2, the first prime number.
* Starting from prime, remove all multiples of prime from the list.
* Increment prime by 1.
* When you reach number, all the remaining numbers in the list are primes.


#### Drafting

1. Build list of number 2 to input
2. For (let prime = 2; prime > 7 ; prime++)
  - for >2,3,4,5,6,7... 
  - for 2,>3,5,7...
  - for 2,3,>5,7...
  - for 2,3,5,>7... 
  --> remove multiples of prime from list
3. What remains in list is a prime number


<!-- [x] Screenshots

![Screenshots](https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.03bZmDGXaBhBYyxxp3Ls3gHaEA%26pid%3DApi&f=1&ipt=e980d57210242747a51c41421e1f09a6de3b1fdaeaadd297496787bb64e80c88&ipo=images) -->

<!-- [Link to operational site](http://www.kirstenopstad.github.com/<REPOSITORY NAME>) -->

### Goals
1. Meet MVP
2. Goal 2
3. Goal 3

## Setup/Installation Requirements

* Clone this repo to your workspace.
* Navigate to the top level of the directory.
* Navigate to program directory ``` $ cd ProjectName ```
* Build the project with ``` $ dotnet build ```
* Run the project with ``` $ dotnet run ```

## Known Bugs

* No known bugs. If you find one, please email me at kirsten.opstad@gmail.com with the subject **[_Repo Name_] Bug** and include:
  * BUG: _A brief description of the bug_
  * FIX: _Suggestion for solution (if you have one!)_
  * If you'd like to be credited, please also include your **_github user profile link_**

## License
<!-- [Choose License](https://choosealicense.com/) -->

MIT License

Copyright (c) 2022 Kirsten Opstad

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
