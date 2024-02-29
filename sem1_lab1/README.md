Лабораторна робота 1.
-------------------
# 1 Завдання (варіант 10):
    Write a program for tabulating the function y(x), display the values ​​of 
    x and y(x) on the screen.
    The user enters the value x0 (initial value) from the keyboard,
    xn (final value), n (number of intermediate values ​​from x0 to xn).
    y = x * sin(sqrt(x + b - 0.0084))
    x0 = -2.05; xk = -3.05; dx = -0.2; b = 3.4;



    We need to tabulate the function. Therefore, to begin with, you need to do a zero check. 
    Then I'll use a loop to find exactly that tab and output it.

--------------------
# 2 Завдання :
    Write a program that determines whether the number n is prime.


    To begin with, you need to check the input of such numbers as zero and one, 
    because there are no such numbers. 
    Then, through a loop, we check whether the number is prime.
    Prime numbers must be divisible by one and itself.

--------------------
# 3 Завдання :
    Write a program to calculate the factorial of the number n and the value x^n.


    To begin with, we must check whether the number we entered is greater than zero,
    because there is no factorial of negative numbers. Then, using the loop,
    we calculate the factorial to the entered number.


    For exponents, we use the math library to find the number in the exponent 
    that we entered.
--------------------
# 4 Завдання :
    The Math library contains a method that allows you to calculate the trigonometric 
    function sin(x).
    In this task, let's first assume that this method does NOT exist,
    and write the proper approximation sin(x),
    which will be implemented WITHOUT using library methods.
    Then, for 10 arbitrary values, we will check the results of the library function
    and own implementation of the function.
    The following formula should be used in the problem:
             a 
    sin(x) = Σ (-1)^n (x^2n+1)/(2n+1)! = x - x^3/3! + x^5/5! - x^7/7! +...x^(2a+1)/(2a+1)!
             n = 0



    To determine the sine without using the mathematician library,
    we create our own sine x
    function, which will calculate according to the following formula:
             a   
    sin(x) = Σ (-1)^n (x^2n+1)/(2n+1)! = x - x^3/3! + x^5/5! - x^7/7! +...x^(2a+1)/(2a+1)!
            n = 0

    And since you can't use the library for factorial and exponent, 
    I create my own factorial and exponent functions.





