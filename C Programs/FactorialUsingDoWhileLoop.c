#include<stdio.h>
#include<conio.h>
void main()
{
	int num,i,fact=1;
	printf("Enter Number : ");
	scanf("%d",&num);
	
	i=num;
	do
	{
		fact=fact*i;
		
		i--;
	}
	while(i>=1);
	printf("Factorial is %d ",fact);
}
