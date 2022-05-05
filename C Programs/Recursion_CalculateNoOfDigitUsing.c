#include<stdio.h>
#include<conio.h>

int Digits(int n1);
void main()
{
  	int n1,count;
    printf(" Enter  a number : ");
    scanf("%d",&n1);

    count = Digits(n1);

    printf(" The number of digits in the number is :  %d",count);
}

int Digits(int n1)
{
    static int count=0;

    if(n1!=0)
    {
        count++;
        Digits(n1/10);
    }

    return count;
}