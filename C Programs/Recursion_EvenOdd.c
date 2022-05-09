#include<stdio.h>
#include<conio.h>

void EvenOdd(int n1, int n);
 
void main()
{
    int n;
    printf(" Input the number : ");
    scanf("%d", &n);
     
    printf("Even Numbers from 1 to %d are : ", n);
    EvenOdd(2, n);
    printf("\n");
    printf("Odd Numbers from 1 to %d are : ", n);
    EvenOdd(1, n);
     
}
void EvenOdd(int n1, int n)
{
    if( n1 > n)
    {
        return;
	}
    printf("%d  ",n1);
    EvenOdd(n1+2, n);
}