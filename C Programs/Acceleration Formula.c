#include<stdio.h>
#include<conio.h>
void main()
{
	float a,v,u,t;
	printf("Formula for Acceleration = v-u/t \n");
	printf("Where v=final velocity,u=initial velocity, t=time \n");
	printf("Enter value Of final velocity : ");
	scanf("%f",&v);
	printf("Enter value Of Initial velocity : ");
	scanf("%f",&u);
	printf("Enter value Of time : ");
	scanf("%f",&t);
	a=(v-u)/t;
	printf("Acceleration is : %f",a);
	

}
