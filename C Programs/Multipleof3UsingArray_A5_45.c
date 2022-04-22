#include<stdio.h>
#include<conio.h>
void main()
{
	int a[7],b,i;
	
	printf("Enter Number : ");
	scanf("%d",&b);
	
	for(i=0;i<7;i++)
	{
		a[i]=b;
		
		b=b*3;	
	
	}

	for(i=0;i<7;i++)
	{
		printf("a[%d]=%d \n",i,a[i]);
	}
}