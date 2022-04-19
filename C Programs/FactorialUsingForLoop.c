#include<stdio.h>
#include<conio.h>
void main()
{
	int num,i,fact=1;
	printf("Enter Number : ");
	scanf("%d",&num);
	
	for(i=num;i>=1;i--)
	{
		fact=fact*i;
	}
	printf("Factorial is %d ",fact);
}
