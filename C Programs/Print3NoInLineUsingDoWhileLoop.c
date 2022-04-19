#include<stdio.h>
#include<conio.h>

void main() 
{
	int a,i,j=1,x=0;
	printf("Enter Number of lines: ");
	scanf("%d",&a);
	i=1;
	do
	{
		i++;
		do
		{
			printf("%d ", j++);
			x++;
		}
		while(x<3);
		x = 0;
		printf("\n");
	}
	while(i<=a);
}