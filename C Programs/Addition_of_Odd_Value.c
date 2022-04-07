#include<stdio.h>
#include<conio.h>
void main()
{
	int num,a,b,c,d,e,odd=0;
	printf("Enter any number five digit number : ");
	scanf("%d",&num);
	
	a=num%10;
	num=num/10;
	
	b=num%10;
	num=num/10;
	
	c=num%10;
	num=num/10;
	
	d=num%10;
	num=num/10;
	
	e=num%10;
	
	if(a%2==!0)
	{
		odd=odd+a;
	}
	if(b%2==!0)
	{
		odd=odd+b;
	}
	if(c%2==!0)
	{
		odd=odd+c;
	}
	if(d%2==!0)
	{
		odd=odd+d;
	}
	if(e%2==!0)
	{
		odd=odd+e;
	}
	

	printf("Addition of Odd No. %d\n",odd);
	
	
}