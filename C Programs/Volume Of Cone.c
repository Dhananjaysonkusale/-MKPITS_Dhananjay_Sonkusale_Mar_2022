#include<stdio.h>
#include<conio.h>
void main()
{
	float b,h,v;
	printf("Enter radius : ");
	scanf("%f",&b);
	printf("Enter height : ");
	scanf("%f",&h);
	v=b*h/3;
	printf("Volume of cone is %f",v);
}
