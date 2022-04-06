#include<stdio.h>
#include<conio.h>
void main()
{
	float p1,p2,res;
	printf("Enter a distance of point 1 : ");
	scanf("%f",&p1);
	printf("Enter a distance of point 2 : ");
	scanf("%f",&p2);
	res=p1-p2;
	printf("Distance Between Two Point is : %.1f",res);
}