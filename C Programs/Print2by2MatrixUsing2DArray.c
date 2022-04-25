#include<stdio.h>
#include<conio.h>
void main()
{
	int i,j,m1[2][2];
	printf("Enter 2*2 Matrix :\n");
	//scan
	for(i=0;i<=1;i++)
	{
		for(j=0;j<=1;j++)
		{
			printf("m1[%d][%d] = ",i,j);
			scanf("%d",&m1[i][j]);
		}
	}
	printf("\nResult Of Matrix :\n");
	//display
	for(i=0;i<=1;i++)
	{
		for(j=0;j<=1;j++)
		{
		//	if(i==j) ----Diagonal element 
			printf(" m1[%d][%d] = %d \n ",i,j,m1[i][j]);
		}
	}
}