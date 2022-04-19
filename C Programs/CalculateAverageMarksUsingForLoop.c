#include<stdio.h>
#include<conio.h>
void main()
{
	int i,a,sum=0,num,ave;
	printf("Enter Number of Students : ");
	scanf("%d",&a);
	
	for(i=0;i<a;i++)
	{
		printf("Enter Marks Student : ");
		scanf("%d",&num);
		
		sum=sum+num;
	}
	ave=sum/a;
	printf("Average Marks Obtained in Mathematics = %d",ave);
	
}