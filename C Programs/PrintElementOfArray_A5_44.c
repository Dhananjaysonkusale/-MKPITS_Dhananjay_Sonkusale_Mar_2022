#include<stdio.h>
#include<conio.h>
void main()
{
	int a[7],b,i;
	for(i=0;i<7;i++)
	{
		printf("Enter Number : ");
		scanf("%d",&b);
		
		if(b>0)
		{
			a[i]=b;
		}
		else
		{
			a[i]=100;
		}
	}

	for(i=0;i<7;i++)
	{
		printf("a[%d]=%d \n",i,a[i]);
	}
}