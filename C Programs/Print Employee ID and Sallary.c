#include<stdio.h>
#include<conio.h>
void main ()
{
	int e,h,a;
	double res;
	printf("Enter Employee ID : ");
	scanf("%d",&e);
	printf("Amount you Receive per Hour : ");
	scanf("%d",&a);
	printf("Total Work hour of a Month : ");
	scanf("%d",&h);
	
	
	res=(a*h);
	
	printf("Employee Id: %d\nSallary =%.2lf",e,res);
	
}