#include<stdio.h>
#include<conio.h>
void main()
{
	float d,f,res;
	printf("Enter total Distance (in Km.): ");
	scanf("%f",&d);
	printf("Enter fuel spent (in ltr.) : ");
	scanf("%f",&f);
	
	res=d/f;
	printf("Bike Average is %.2f km/ltr",res);
}