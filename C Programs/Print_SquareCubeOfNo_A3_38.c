#include<stdio.h>
#include<conio.h>
void main() 
{
	int a,i;
	printf("Input number of lines: ");
	scanf("%d",&a);
	i=0;
	
    while(i<=a) 
	{
		i++;
		printf("%d %d %d\n",i,i*i,i*i*i);
	}
	
}