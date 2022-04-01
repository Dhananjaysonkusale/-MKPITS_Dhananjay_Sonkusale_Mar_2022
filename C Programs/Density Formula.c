#include<stdio.h>
#include<conio.h>
void main()
{
	float d,m,v;
	printf("Formula for density = m/v \n");
	printf("Where d=density, m=mass,v=volume \n");
	printf("Enter value Of Mass : ");
	scanf("%f",&m);
	printf("Enter value Of Volume : ");
	scanf("%f",&v);
	d=m/v;
	printf("Density is : %f",d);
	

}
