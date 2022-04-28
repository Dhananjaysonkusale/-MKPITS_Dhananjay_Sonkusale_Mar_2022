//check given integer either is in range 100 to 200
#include<stdio.h>
#include<conio.h>
void main() 
{
	int n;
	printf("Enter 1st Number :");
	scanf("%d",&n);
	
	if(100<=n && 200>=n)
	{
		printf("Enter Number is in Range !");
	}
	else
	{
		printf("Entered Number is Not in Range :");
	}
}
