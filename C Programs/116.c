/*Write a C program to print on screen the output of adding,subtracting,multiplying
and dividing of two numbers which will be entered by the user.*/
#include<stdio.h>
#include<conio.h>
void main()
{
	int a,b,sum,sub,mul,div;
	printf("Enter the 1st number : ");
	scanf("%d",&a);
	printf("Enter the 2nd number : ");
	scanf("%d",&b);	
	sum=a+b;
	sub=a-b;
	mul=a*b;
	div=a/b;
	printf("Addition = %d\n",sum);
	printf("Substraction = %d\n",sub);
	printf("Multiplication = %d\n",mul);
	printf("Division = %d",div);
}