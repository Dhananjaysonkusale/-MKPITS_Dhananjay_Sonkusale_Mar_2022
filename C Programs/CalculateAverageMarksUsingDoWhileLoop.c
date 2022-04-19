#include<stdio.h>
#include<conio.h>
void main()
{
	int i,a,sum=0,num,ave;
	printf("Enter Number of Students : ");
	scanf("%d",&a);
	
	i=0;
	do
	{
		i++;
		printf("Enter Marks Student : ");
		scanf("%d",&num);
		
		sum=sum+num;
		
	}
	while(i<a);
	
	ave=sum/a;
	printf("Average Marks Obtained in Mathematics = %d",ave);
	
}