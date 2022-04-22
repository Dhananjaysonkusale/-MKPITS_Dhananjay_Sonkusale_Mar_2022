#include<stdio.h>
#include<conio.h>
void main()
{
	int i,a[4];
	printf("Enter Any 5 number :\n");
	
	for(i=0;i<=4;i++)
	{
		printf("Enter Number = ",i);
		scanf("%d",&a[i]);
	}
	for(i=4;i>=0;i--)
	{
		printf(" %d \n",a[i]);
	}
}