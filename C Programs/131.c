/*Write a C program to check a given array of integers and return true 
if every 5 that appears in the given array is next to another 5.*/
#include<stdio.h>
#include<conio.h>
void main()
{
    int n,i,f=0;
    printf("Enter the size of array : ");
    scanf("%d",&n);
    int a[n];
    printf("Enter the array element : ");
    for(i=0;i<n;i++)
    {
        scanf("%d",&a[i]);
    }
    for (i = 0; i < n; i++)
    {
        if (a[i] == 5)
        {
            if ((i > 0 && a[i - 1] == 5) || (i < n - 1 && a[i + 1] == 5)) 
            {
                f= 1;
            }
            else if (i == n - 1) 
            {
                f = 0;
            }
            else 
            {
                f=0;
            }
        }
    }
    
    if(f==1)
    {
        printf("TRUE");
    }
    else
    {
        printf("FALSE");
    }
}