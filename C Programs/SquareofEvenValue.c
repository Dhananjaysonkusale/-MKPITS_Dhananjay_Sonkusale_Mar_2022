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
		even=even+(a*a);
	}

	
	if(b%2==0)
	{
		even=even+(b*b);
	}

	
	if(c%2==0)
	{
		even=even+(c*c);
	}

	
	if(d%2==0)
	{
		even=even+(d*d);
	}

	
	if(a%2==0)
	{
		even=even+(e*e);
	}
	
	printf("Addition of even No. %d\n",even);
	
}