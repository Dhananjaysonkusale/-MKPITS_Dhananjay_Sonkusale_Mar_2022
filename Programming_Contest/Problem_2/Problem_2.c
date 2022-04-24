#include<stdio.h> 
#include<string.h>
void main ()
{
  char a[1000];
  int i,n, j, count = 0;
  char ch = '0';
  printf("Enter a given string to find the frequency of each digit in the given string : \n");
  scanf("%s", a);
  
  for (i = 0; a[i] != '\0';++i);
  
  n = i;         
  for (i = 0; i < 10; i++)
    {
          for (j = 0; j < n; j++)
    	  {
    	    if (a[j] == ch)
    	    {
    	      count++;
    	    }
    	  }
      printf("%d ", count);
      count = 0;
      ch++;
    }

}