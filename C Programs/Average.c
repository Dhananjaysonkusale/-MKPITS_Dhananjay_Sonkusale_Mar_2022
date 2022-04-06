#include<stdio.h>
#include<conio.h>
void main ()
{
	float i1,i2,p1,p2,ave;
	printf("Enter weight of 1st Item : ");
	scanf("%f",&i1);
	printf("Enter weight of 2nd Item : ");
	scanf("%f",&i2);
	printf("Enter number of purchase of 1st Item : ");
	scanf("%f",&p1);
	printf("Enter number of purchase of 2nd Item : ");
	scanf("%f",&p2);
	
	ave=((i1*p1)+(i2*p2))/(p1+p2);
	
	printf("%.2f",ave);
}