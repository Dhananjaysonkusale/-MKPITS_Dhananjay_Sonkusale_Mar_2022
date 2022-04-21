#include<stdio.h>
#include<conio.h>
void main()
{
	int r,c,d=1;
	for(r=1;r<5;r++)
	{
		for(c=1;c<=r;c++)
		{
			printf(" %d",d++);
		}
		printf("\n");
	}
}