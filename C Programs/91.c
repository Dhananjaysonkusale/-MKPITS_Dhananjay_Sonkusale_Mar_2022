//Write a C program to compute the sum of the two given integers. If the sum is in the range 10, 20 inclusive return 30
#include<stdio.h>
#include<conio.h>
void main()
{
	int sum,n1,n2;
	printf("Enter 1st Number ");
	scanf("%d",&n1);
	printf("Enter 2nd Number ");
	scanf("%d",&n2);
	
	sum=n1+n2;
	
	if(sum>=10 && sum<=20)
	{
		printf("Is in range ");
	}
	else
	{
		printf("Not in Range ");
	}
}