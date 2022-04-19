#include<stdio.h>
#include<conio.h>
void main()
{
	int x,y,i,power=1;
	printf("Enter X & Y : ");
	scanf("%d %d",&x,&y);
	
	for(i=1;i<=y;i++)
	{
		power=power*x;
	}
	printf("%d",power);
}

