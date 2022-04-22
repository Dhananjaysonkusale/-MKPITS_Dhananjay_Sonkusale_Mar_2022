#include<stdio.h>
#include<conio.h>
void main()
{
	int i,a[9];
	int even=0,odd=0;
	printf("Calculate Total Even Odd Number \n");
	for (i=0;i<=9;i++)
	{
		printf("Enter any No : ");
		scanf("%d",&a[i]);
		
		if(a[i]%2 == 0)
		{
			even=even+1;
		}
		else
		{
			odd=odd+1 ;
		}
		
	}
		printf("Even = %d \n ",even);
		
		printf("Odd = %d \n",odd);
}
