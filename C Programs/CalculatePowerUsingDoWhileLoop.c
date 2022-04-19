#include<stdio.h>
#include<conio.h>
void main()
{
	int x,y,i,power=1;
	printf("Enter X & Y : ");
	scanf("%d %d",&x,&y);
	
	i=1;
	do
	{
		power=power*x;
		i++;
	}
	while(i<=y);
	printf("%d",power);
}

