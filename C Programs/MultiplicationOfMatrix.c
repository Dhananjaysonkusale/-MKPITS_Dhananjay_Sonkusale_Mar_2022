#include<stdio.h>
#include<conio.h>
void main()
{
    int a[2][2],b[2][2], res[2][2], sum=0, i, j, k;
    
    printf("Enter elements of 1st matrix \n");
    for(i=0; i<2; i++)
    {
        for(j=0; j<2; j++)
        {
            printf("a[%d][%d]= ",i,j);
            scanf("%d",&a[i][j]);
        }
    }

    printf("Enter elements of 2nd matrix \n");
    for(i=0; i<2; i++)
    {
        for(j=0; j<2; j++)
        {
            printf("b[%d][%d]= ",i,j);
            scanf("%d",&b[i][j]);
        }
    }

    for(i=0; i<2; i++)
    {
        for(j=0; j<2; j++)
        {
            for(k=0; k<2; k++)
            {
                sum=sum+(a[i][j]*b[k][j]);
            }
            res[i][j]=sum;
            sum=0;
        }
    }

    printf("Matrix after Multiplication : \n");
    for(i=0; i<2; i++)
    {
        for(j=0; j<2; j++)
        {
            printf("%d ",res[i][j]);
            if(j==1)
            printf("\n");
        }
    }
}