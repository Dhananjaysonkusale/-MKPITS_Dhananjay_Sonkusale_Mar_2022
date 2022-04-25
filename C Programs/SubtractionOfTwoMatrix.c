#include<stdio.h>
#include<conio.h>
void main()
{
	int i,j,m1[2][2],m2[2][2],res[2][2];
	printf("Enter 1st 2*2 Matrix :\n");
	//scan 1st matrix
	for(i=0;i<=1;i++)
	{
		for(j=0;j<=1;j++)
		{
			printf(" m1[%d][%d] = ",i,j);
			scanf("%d",&m1[i][j]);
		}
	}
	printf("Enter 2nd 2*2 Matrix : \n ");
	for(i=0;i<=1;i++)
	{
		for(j=0;j<=1;j++)
		{
			printf(" m2[%d][%d] = ",i,j);
			scanf("%d",&m2[i][j]);
		}
	}
	for(i=0;i<=1;i++)
	{
		for(j=0;j<=1;j++)
		{
			res[i][j]=m1[i][j]-m2[i][j];
		}
	}
	
	printf("Result Of Matrix is : \n");
	for(i=0;i<=1;i++)
	{
		for(j=0;j<=1;j++)
		{
			printf(" [%d][%d] = %d \n ",i,j,res[i][j]);
		}
	}
	
}