#include<stdio.h>
#include<conio.h>
void main()
{
	float pi=3.14;
	float r,t,v;
	printf("Enter value of radius: ");
	scanf("%f",&r);
	printf("Enter value of t: ");
	scanf("%f",&t);
	v=2*pi*r/t;
	printf("tangential Velocity is %f",v);
}
