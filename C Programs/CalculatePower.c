#include<stdio.h>
#include<conio.h>
void main()
{
	int x,y,i,power=1;
	printf("Enter X & Y : ");
	scanf("%d %d",&x,&y);
	
	i=1;
	while(i<=y)
	{
		
		power=power*x;
		i++;
		
	}
	printf("%d",power);
}