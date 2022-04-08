#include<stdio.h>
#include<conio.h>
void main()
{
	int a,b,c,d,e,odd=0;
    system("cls");
    printf("Enter 1st Number : ");
    scanf("%d",&a);
    printf("Enter 2nd Number : ");
    scanf("%d",&b);
    printf("Enter 3rd Number : ");
    scanf("%d",&c);
    printf("Enter 4th Number : ");
    scanf("%d",&d);
    printf("Enter 5th Number : ");
    scanf("%d",&e);
	
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