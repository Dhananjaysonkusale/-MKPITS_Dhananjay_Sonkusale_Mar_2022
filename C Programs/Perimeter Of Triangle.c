#include<stdio.h>
#include<conio.h>
void main()
{
	float a,b,c,p;
	printf("Enter Any Number : ");
	scanf("%f",&a);
	printf("Enter Any Number : ");
	scanf("%f",&b);
	printf("Enter Any Number : ");
	scanf("%f",&c);
	
	if(a<(b+c)&&b<(a+c)&&c<(a+b))
	{
		p=a+b+c;
		printf("Perimeter of Triangle is : %f",p);
		
	}
	else
	{
		printf("It is not possible to make triangle : ");
	}
	
}
