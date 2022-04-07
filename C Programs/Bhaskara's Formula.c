#include<stdio.h>
#include<math.h>
void main()
{
	float a,b,c,res;  	
	printf("Enter first number : "); 
    scanf("%f",&a);
    printf("Enter second number : "); 
    scanf("%f",&b);
    printf("Enter third number : "); 
    scanf("%f",&c);
    res=(b*b)-(4*(a)*(c));
	if(res>0&&a!=0) 
	{
		float x, y;
		res=sqrt(res);
		x = (-b + res)/(2*a);
		y = (-b - res)/(2*a);
		printf("1st Root = %.2f\n", x);
		printf("2nd Root = %.2f\n", y);
	} 
	else
	{
		printf("Roots Are not found !");
	}
	
}
