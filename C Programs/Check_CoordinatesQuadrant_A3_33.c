#include<stdio.h>
#include<conio.h>
void main()
{
	int x,y;
	printf("Enter coordinates x : ");
	scanf("%d",&x);
	printf("Enter coordinates y : ");
	scanf("%d",&y);
	
	if(x>0 && y>0)
	{
		printf("Coordinates is in I-Quadrant !");
	}
	else
	if(x<0 && y>0)
	{	
		printf("Coordinates is in II-Quadrant !");
	}
	else
	if(x<0 && y<0)
	{
		printf("Coordinates is in III-Quadrant !");
	}
	else
	if(x>0 && y<0)
	{
		
		printf("Coordinates is in IV-Quadrant !");
	}
}