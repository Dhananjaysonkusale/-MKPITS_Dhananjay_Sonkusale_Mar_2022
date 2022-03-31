#include<stdio.h>
#include<conio.h>
void main()
{
	int m,v,x;
	float k;
	printf("Enter Value of mass");
	scanf("%d",&m);
	printf("Enter value of velocity");
	scanf("%d",&v);
	x=m*(v*v);
	k=x/2;
	printf("Kinetic energy is %f",k);
}
