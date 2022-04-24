#include<stdio.h>
#include<conio.h>
void main() 
{
    int n,i,j,h,d;
    printf("Enter Any Number From Pattern You Want : ");
    
    scanf("%d", &n);
    
	h = (n*2)-1;
    
    for(i=0;i<h;i++)
	{
        for(int j=0;j<h;j++)
		{
			if(i<j)
			{
				d=i;
			}
			else
			{
				d=j;
			}
			if(d>h-i)
			{
				d=h-i-1;
			}
            if(d>h-j-1)
            {
            	d=h-j-1;
			}
            printf("%d""  ", n-d);
        }
        printf("\n");
    }
    
}
