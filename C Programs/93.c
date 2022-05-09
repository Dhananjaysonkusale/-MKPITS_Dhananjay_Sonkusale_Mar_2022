////Write a C program to to test if a given non-negative number is a multiple of 13 or it is one more than multiple of 13
#include<stdio.h>
#include<conio.h>
void main()
{
	int n;
	printf("Enter Any Number ");
	scanf("%d",&n);
	
	if(n%13==0 || n%13==1 )
	{
		printf("Multiple Of 13");
	}
	else
	{
		printf("Not Multiple Of 13");
	}
}