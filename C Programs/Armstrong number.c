#include<stdio.h>
#include<conio.h>
void main()
{
	int num,a,b,c,res,a1;
	printf("Enter any 3 digit number : ");
	scanf("%d",&num);
	a1=num;
	a=a1%10;
	a1=a1/10;
	b=a1%10;
	a1=a1/10;
	c=a1%10;
	
	res=(a*a*a)+(b*b*b)+(c*c*c);
	if(num==res)
		{
			printf("Number is armstrong");
		}
	else
		{
		printf("Number is not armstrong");
		}
	
}