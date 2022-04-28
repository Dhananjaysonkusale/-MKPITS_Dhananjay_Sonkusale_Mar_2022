//check given integer and print true if it is within 10 of 100 or 200
#include<stdio.h>
#include<conio.h>
void main()
{
	int n;
	printf("Enter Any Number : ");
	scanf("%d",&n);
	
	if((100-n)<=10 || (200-n)<=10)
	{
		printf(" TRUE !");
	}
	else
	{
		printf(" False !");
	}
}