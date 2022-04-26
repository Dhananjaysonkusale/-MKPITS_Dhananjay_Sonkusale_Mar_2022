#include<stdio.h>
#include<conio.h>
void main()
{
    int a[3][3], trans[3][3], i, j;
    printf("Enter matrix element \n");
    for(i=0; i<3; i++)
    {
        for(j=0; j<3; j++)
        {
            printf("a[%d][%d]= ",i,j);
            scanf("%d",&a[i][j]);
        }
    }
    
    for(i=0; i<3; i++)
    {
        for(j=0; j<3; j++)
        {
            if(i==j)
            {
                trans[i][j]=a[i][j];
            }
            else
            {
                trans[i][j]=a[j][i];
            }
        }
    }

    printf("transpose of matrix \n");
    for(i=0; i<3; i++)
    {
        for(j=0; j<3; j++)
        {
            printf("%d ",trans[i][j]);
            if(j==2)
            printf("\n");
        }
    }
}