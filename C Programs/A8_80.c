//check given temperature is less than 0 or greater than 100
#include<stdio.h>
#include<conio.h>
void main()
{
	int n;
	printf("Enter Temperature :");
	scanf("%d",&n);
	
	if(n<0)
	{
		printf("Temperature is less than 0");
	}
	else 
	if(n>100)
	{
		printf("Temperature is greater than 100 ");
	}
	else
	{
		printf("Entered Temperature is not Between 0 and 100");
	}
}