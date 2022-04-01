#include<stdio.h>
#include<conio.h>
void main()
{
	float pi=3.147;
	float r,h,h1;
	printf("Formula for Hemisphere = 2/3*pi*r^3 \n");
	printf("Where r=radius \n");
	printf("Enter value Of radius : ");
	scanf("%f",&r);
	h=2*(pi*r*r*r);
	h1=h/3;
	printf("Area Of Hemisphere %f",h1);
}
