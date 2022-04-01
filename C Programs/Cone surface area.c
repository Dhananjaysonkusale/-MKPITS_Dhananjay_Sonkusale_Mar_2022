#include<stdio.h>
#include<conio.h>
void main()
{
	float pi=3.147;
	float r,l,a;
	printf("Formula for cone surface area = pi*r*l \n");
	printf("Where r=radius \n l=length \n");
	printf("Enter value Of radius : ");
	scanf("%f",&r);
	printf("Enter value Of length : ");
	scanf("%f",&l);
	a=pi*r*l;
	printf("%f",a);
}
