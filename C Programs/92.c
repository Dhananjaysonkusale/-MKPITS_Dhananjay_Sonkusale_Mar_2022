//Write a C program that accept two integers and return true if either one is 5 or their sum or difference is 5.
#include<stdio.h>
#include<conio.h>
void main()
{
	int sum,diff,n1,n2;
	printf("Enter 1st Number ");
	scanf("%d",&n1);
	printf("Enter 2nd Number ");
	scanf("%d",&n2);
	
	sum=n1+n2;
	
	diff=n1-n2;
	
	if(n1==5 || n2==5 || sum==5 ||diff==5)
	{
		printf("True");
	}
	else
	{
		printf("False");
	}
}