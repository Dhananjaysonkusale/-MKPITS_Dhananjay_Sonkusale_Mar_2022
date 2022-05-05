#include<stdio.h>
#include<conio.h>
int sum1(int n);

void main() 
{
    int n, sum;

    printf("Enter a Number : ");
    scanf("%d", &n);

    sum = sum1(n);

    printf("Sum Of Natural Number is = %d", sum);
}

int sum1(int n1) 
{
    if (n1 != 0)
    {
        return n1 + sum1(n1-1); 
	}
    else
    {
        return n1;
	}
}