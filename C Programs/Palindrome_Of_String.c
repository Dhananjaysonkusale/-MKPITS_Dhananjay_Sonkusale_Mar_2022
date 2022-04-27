#include<stdio.h>
#include<conio.h>
#include<string.h> 
void main()
{
    char str1[20],str2[20];  
   
    printf("Enter any name : ");
    scanf("%s",str1);
    strcpy(str2,str1);
    strrev(str2);
    if(!strcmp(str1,str2))
    {
 		printf("Palindrome");
	}
    else
    {
        printf("Not Palindrome");
    }
    
}
