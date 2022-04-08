#include<stdio.h>
#include<conio.h>
void main()
{
	
	int a,b,c,d,e,even=0;
	printf("Enter 1st Number :");
	scanf("%d",&a);
	printf("Enter 2nd Number :");
	scanf("%d",&b);
	printf("Enter 3rd Number :");
	scanf("%d",&c);
	printf("Enter 4th Number :");
	scanf("%d",&d);
	printf("Enter 5th Number :");
	scanf("%d",&e);
	
	if(a%2==0)
	{
		even=(a*a);
		printf("%d \n",even);
	}

	
	if(b%2==0)
	{
		even=(b*b);
		printf("%d \n",even);
	}

	
	if(c%2==0)
	{
		even=(c*c);
		printf("%d \n",even);
	}

	
	if(d%2==0)
	{
		even=(d*d);
		printf("%d \n",even);
	}

	
	if(e%2==0)
	{
		even=(e*e);
		printf("%d \n",even);
	}
	
}