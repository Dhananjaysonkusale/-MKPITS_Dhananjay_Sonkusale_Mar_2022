#include<stdio.h>
#include<conio.h>
void main()
{
	int a,h,m,s;
	printf("Enter any Interger : ");
	scanf("%d",&a);
	
	h = (a/3600);
	printf("Hour = %d\n",h);
 
	m = (a -(3600*h))/60;
	printf("Minute = %d\n",m);
 	
	s = (a -(3600*h)-(m*60));
	printf("Seconds = %d",s);
	
}