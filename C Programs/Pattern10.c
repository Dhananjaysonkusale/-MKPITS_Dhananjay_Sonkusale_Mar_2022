#include<stdio.h>
#include<conio.h>
void main()
{
	char r,c;
	for(r='D';r>='A';r--)
	{
		for(c='A';c<=r;c++)
		{
			if(r%2==0)
			printf("%c",c);
			else
			printf("%c",c+32);
		}
		printf("\n");
	}
}