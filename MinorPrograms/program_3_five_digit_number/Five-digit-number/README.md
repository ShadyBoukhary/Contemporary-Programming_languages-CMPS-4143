## Program 3 - Five Digit Number
***
### Information
* **Shady Boukhary**
* **CMPS 4143: Contemporary Programming Languages**
* **September 5th, 2018**
* **Dr. Stringfellow**
* **Description: A simple program that reads a 5-digit integer from the console, 
 then displays its digits separately. The program assumes valid input.**

### Questions
```
What happens when you execute the app and type a number with more than 5 digits?
```
Only the least significant 5 digits will be displayed.

```
What happens when you execute the app with fewer than five digits?
```
If `n = number of digits` , the digits will be displayed with `5 - n` zeroes occupying the missing digits (to the left of the digits).
