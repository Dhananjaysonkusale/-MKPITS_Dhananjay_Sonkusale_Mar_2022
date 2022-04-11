#include<stdio.h>
#include<conio.h>
void main()
{
	float a,b,div;
	printf("Enter 1st number : ");
    scanf("%f",&a);
	printf("Enter 2nd number : ");
    scanf("%f",&b);

    if(b!=0)
    {
        div=a/b;
        printf("Answer is %.1f ",div);
    }
	else
    {
        printf("Division is not Possible !");
    }
}