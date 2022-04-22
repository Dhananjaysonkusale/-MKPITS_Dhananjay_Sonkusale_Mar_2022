#include<stdio.h>
#include<conio.h>
void main() 
{
	float s=0,j=1,t,i;
	printf(" Value of s : \n where S = 1+ 3/2 + 5/4 + 7/8 \n ");

	for(i=1; i<=7; i=i+2)
	{
		t=i/j;
		s=s+t;
		j=j*2;
	}
    printf("s = %.2f",s);

}
