#include<stdio.h>
#include<conio.h>

void main() 
{
	int a,i,j=1,x;
	printf("Enter Number of lines: ");
	scanf("%d",&a);
	
	for(i=1;i<=a;i++)
	{
		for(x=0;x<3;x++) 
		{
			printf("%d ", j++);
		}
		x = 0;
		printf("\n");
	}
}