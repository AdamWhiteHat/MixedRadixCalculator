# MixedRadixCalculator - 52:7:24:60:60:1000

Screenshot - http://2.bp.blogspot.com/-FGIEnHOY31Y/VhO5ux32orI/AAAAAAAAAUo/cvxWqchvjvQ/s1600/MixedRadixCalculator.PNG

  A numeral system (or system of numeration) is a writing system for expressing numbers. 

  The most familiar one is of course the decimal numeral system. This is a 10-base numbering system. Computers use a binary numeral system. The base is sometimes called the radix or scale.
  Not all numbering systems have just one base. Take for example, how we currently divide time: There are 60 seconds in a minute, 60 minutes in an hour, 24 hours in a day, and 365 days in a year. This is called a mixed radix numeral system, and one might express the above mixed radix system like: 365:24:60:60. I choose the left side to be the most significant side. This is merely a personal preference, and my MixedRadixSystem class supports displaying both alignments.
  Another feature lies in my RadixNumeral class. Each numeral, or place value, supports having its own dictionary of symbols

  https://en.wikipedia.org/wiki/Mixed_radix
 .
  http://mathworld.wolfram.com/Base.html

  My 'Mixed Radix Calculator' creates a counting system of radices (plural of radix), such as base 12 or mixed radices such as Minutes/Hours/Days/Years (60/60/24/365).

Uses:
  I haven't found a lot of use cases for it yet, but it is interesting. I originally built this because I wanted to experiment with numeral systems that uses increasing consecutive prime numbers for each radix, as well as experiment with some off-bases, such as base 3 or base 7.
 
  In a single base, say base 7, then 'round numbers' with only one place value having a 1 and the rest having zeros, such as 1:0:0:0:0 (in base 7), such numbers are powers of 7, and ever other number except for the 1's place value is a multiple of 7.

  A mixed radix numeral system can represent a polynomial, and possibly provide for a simpler way to visualize and reason about them.

  Yet another possible use is to make a numeral system with a base that is larger than and co-prime to some other target number (say 256) to make a bijective map from every value in a byte to some other value exactly once by repeatedly adding the value of the co-prime, modulus 256. This can appear rather random (or sometimes not at all) but the mapping is easily determined given the co-prime. I have talked about this notion before on my blog
  http://www.csharpprogramming.tips/search/label/Coprime

If you like this project you would probably like my project EquationFinder, it finds equations given constraints 
https://github.com/AdamRakaska/EquationFinder
