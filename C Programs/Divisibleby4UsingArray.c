#include<stdio.h>
#include<conio.h>
void main()
{
	int i,a[4];

	printf("Enter Any 5 number :\n");
	
	for(i=0;i<=4;i++)
	{
		printf("Enter Number : ");
		scanf("%d",&a[i]);
		
	}
	
	for(i=0;i<=4;i++)
	{
		
	if(a[i]%4==0)
		{
			printf(" \n No Divisible by 4 is %d \n \n ",a[i]);
			
		}
	}
}