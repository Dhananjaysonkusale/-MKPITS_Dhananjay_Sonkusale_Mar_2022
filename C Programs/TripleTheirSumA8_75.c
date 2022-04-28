//if enter digit are same then print return triple their sum
#include<stdio.h>
#include<conio.h>
void main()
{
	int n1,n2,sum;
	printf("Enter 1st digit : ");
	scanf("%d",&n1);
	printf("Enter 2nd Digit : ");
	scanf("%d",&n2);
	
	if(n1==n2)
	{
		sum=(n1+n2)*3;
		printf("Result = %d",sum);
	}
	else
	{
		printf("Enter Digit are Not Same !");
	}
}